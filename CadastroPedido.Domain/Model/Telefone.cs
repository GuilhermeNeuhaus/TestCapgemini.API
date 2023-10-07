namespace CadastroPedido.Domain.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
