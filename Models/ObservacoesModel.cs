namespace Api.Models
{
    public class ObservacoesModel
    {
        public int ObservacaoId { get; set; }

        public string ObservacaoDescricao { get; set; } = string.Empty;

        public string ObservacaoLocal { get; set; } = string.Empty;

        public DateTime ObservacaoData { get; set; } = DateTime.MinValue;

        public int AnimaisId { get; set; }

        public int UsuarioId { get; set; }

        public static implicit operator List<object>(ObservacoesModel v)
        {
            throw new NotImplementedException();
        }
    }
}
