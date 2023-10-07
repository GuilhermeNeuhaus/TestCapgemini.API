using CadastroPedido.Domain.Enum;
using System.Xml.Linq;

namespace CadastroPedido.Domain.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
