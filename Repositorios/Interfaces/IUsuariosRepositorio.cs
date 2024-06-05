using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Task<List<UsuariosModel>> GetAll();

        Task<UsuariosModel> GetById(int id);

        Task<UsuariosModel> InsertUsuario(UsuariosModel usuario);

        Task<UsuariosModel> UpdateUsuario(UsuariosModel usuario, int id);

        Task<bool> DeleteUsuario(int id);
    }
}
