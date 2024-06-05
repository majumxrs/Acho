namespace Api.Models
{
    public class UsuariosModel
    {
        public int UsuarioId { get; set; }

        public string UsuarioNome { get; set; } = string.Empty;

        public string UsuarioTelefone { get; set; } = string.Empty;

        public string UsuarioEmail { get; set; } = string.Empty;

        public string UsuarioSenha { get; set; } = string.Empty;


        public static implicit operator List<object>(UsuariosModel v)
        {
            throw new NotImplementedException();
        }
    }
}
