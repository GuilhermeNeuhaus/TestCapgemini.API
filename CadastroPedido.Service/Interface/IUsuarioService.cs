using CadastroPedido.Domain.Model;

namespace CadastroPedido.Domain.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> BuscarTodos();
        Task<Usuario> BuscarPorId(int id);
        Task<Usuario> BuscarPorCPF(string cpf);
        Task<Usuario> Adicionar(Usuario usuario, List<Telefone> telefones);
        Task<Usuario> Atualizar(Usuario usuario, List<Telefone> telefones);
        Task Remover(int usuarioId);
    }
}
