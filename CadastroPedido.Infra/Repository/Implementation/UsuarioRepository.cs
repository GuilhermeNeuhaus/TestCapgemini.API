using CadastroPedido.Domain.Model;
using CadastroPedido.Infra.Data;
using CadastroPedido.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroPedido.Infra.Repository.Implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CadastroPedidoDBContext _dbContext;

        public UsuarioRepository(CadastroPedidoDBContext cadastroPedidoDBContext)
        {
            _dbContext = cadastroPedidoDBContext;
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            try
            {
                return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            } 
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o Usuário pelo ID", ex);
            }
        }

        public async Task<Usuario> BuscarPorCPF(string cpf)
        {
            try
            {
                return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.CPF.Equals(cpf));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o Usuário pelo CPF", ex);
            }
        }

        public async Task<List<Usuario>> BuscarTodos()
        {
            try
            {
                return await _dbContext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar todos os Usuários", ex);
            }           
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            try
            {
                await _dbContext.Usuarios.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar um novo Usuário", ex);
            }
        }

        public async Task<Usuario> Atualizar(Usuario usuario)
        {
            try
            {
                _dbContext.Usuarios.Update(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar um Usuário", ex);
            }
        }

        public async Task Remover(Usuario usuario)
        {
            try
            {
                _dbContext.Usuarios.Remove(usuario);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar um Usuário", ex);
            }
        }
    }
}
