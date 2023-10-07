using CadastroPedido.Domain.Model;
using CadastroPedido.Infra.Data;
using CadastroPedido.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroPedido.Infra.Repository.Implementation
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly CadastroPedidoDBContext _dbContext;

        public TelefoneRepository(CadastroPedidoDBContext cadastroPedidoDBContext)
        {
            _dbContext = cadastroPedidoDBContext;
        }

        public async Task<Telefone> BuscarPorId(int id)
        {
            try
            {
                return await _dbContext.Telefones.FirstOrDefaultAsync(u => u.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o Telefone pelo ID", ex);
            }
        }

        public async void Adicionar(Telefone telefone)
        {
            try
            {
                await _dbContext.Telefones.AddAsync(telefone);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar um novo Telefone", ex);
            }
        }

        public async void Atualizar(Telefone telefone)
        {
            try
            {
                _dbContext.Telefones.Update(telefone);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar um Telefone", ex);
            }
        }

        public async void Apagar(Telefone telefone)
        {
            try
            {
                _dbContext.Telefones.Remove(telefone);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar um Telefone", ex);
            }
        }
    }
}
