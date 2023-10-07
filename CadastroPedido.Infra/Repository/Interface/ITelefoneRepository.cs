using CadastroPedido.Domain.Model;

namespace CadastroPedido.Infra.Repository.Interfaces
{
    public interface ITelefoneRepository
    {
        Task<Telefone> BuscarPorId(int id);
        void Adicionar(Telefone telefone);
        void Atualizar(Telefone telefone);
        void Apagar(Telefone telefone);
    }
}
