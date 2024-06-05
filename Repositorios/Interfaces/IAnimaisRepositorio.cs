using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IAnimaisRepositorio
    {
        Task<List<AnimaisModel>> GetAll();

        Task<AnimaisModel> GetById(int id);

        Task<AnimaisModel> InsertAnimal(AnimaisModel animal);

        Task<AnimaisModel> UpdateAnimal(AnimaisModel animal, int id);

        Task<bool> DeleteAnimal(int id);
    }
}
