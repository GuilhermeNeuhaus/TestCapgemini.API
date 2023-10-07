using CadastroPedido.Domain.Model;
using System.Threading.Tasks;

namespace CadastroPedido.Infra.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> BuscarTodos();
        Task<Usuario> BuscarPorId(int id);
        Task<Usuario> BuscarPorCPF(string cpf);
        Task<Usuario> Adicionar(Usuario usuario);
        Task<Usuario> Atualizar(Usuario usuario);
        Task Remover(Usuario usuario);
    }
}
