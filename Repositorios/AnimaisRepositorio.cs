using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class AnimaisRepositorio : IAnimaisRepositorio
    {
        private readonly Contexto _dbContext;

        public AnimaisRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AnimaisModel>> GetAll()
        {
            return await _dbContext.Animais.ToListAsync();
        }

        public async Task<AnimaisModel> GetById(int id)
        {
            return await _dbContext.Animais.FirstOrDefaultAsync(x => x.AnimaisId == id);
        }

        public async Task<AnimaisModel> InsertAnimal(AnimaisModel animal)
        {
            await _dbContext.Animais.AddAsync(animal);
            await _dbContext.SaveChangesAsync();
            return animal;
        }

        public async Task<AnimaisModel> UpdateAnimal(AnimaisModel animal, int id)
        { 
            AnimaisModel animais = await GetById(id);
            if (animais == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                animais.AnimalNome = animal.AnimalNome;
                animais.AnimalRaca = animal.AnimalRaca;
                animais.AnimalTipo = animal.AnimalTipo;
                animais.AnimalCor = animal.AnimalCor;
                animais.AnimalSexo = animal.AnimalSexo;
                animais.AnimalObservacao = animal.AnimalObservacao;
                animais.AnimalFoto = animal.AnimalFoto;
                animais.AnimalDataDesaparecimento = animal.AnimalDataDesaparecimento;
                animais.AnimalDataEncontro = animal.AnimalDataEncontro;
                animais.AnimalStatus = animal.AnimalStatus;
                animais.UsuarioId = animal.UsuarioId;
                _dbContext.Animais.Update(animais);
                await _dbContext.SaveChangesAsync();
            }
            return animais;

        }

        public async Task<bool> DeleteAnimal(int id)
        {
            AnimaisModel animais = await GetById(id);
            if (animais == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Animais.Remove(animais);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
