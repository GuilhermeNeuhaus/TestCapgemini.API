using CadastroPedido.Domain.Model;
using CadastroPedido.Domain.Service.Interfaces;
using CadastroPedido.Infra.Repository.Interfaces;

namespace CadastroPedido.Domain.Service.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<Usuario>> BuscarTodos()
        {
            return await _usuarioRepository.BuscarTodos();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuarioRepository.BuscarPorId(id);
        }

        public async Task<Usuario> BuscarPorCPF(string cpf)
        {
            if (cpf == string.Empty)
            {
                throw new Exception("Erro de sistema.");
            }

            return await _usuarioRepository.BuscarPorCPF(cpf);
        }

        public async Task<Usuario> Adicionar(Usuario usuario, List<Telefone> telefones)
        {
            if (usuario is null)
            {
                throw new Exception("Erro de sistema.");
            }

            var usuarioPorCPF = await _usuarioRepository.BuscarPorCPF(usuario.CPF);

            if (usuarioPorCPF is null)
            {
                return await _usuarioRepository.Adicionar(usuario);
            }
            else
            {
                throw new Exception("Já existe um usuário cadastrado com este CPF.");
            }
        }

        public async Task<Usuario> Atualizar(Usuario usuario, List<Telefone> telefones)
        {
            if (usuario is null)
            {
                throw new Exception("Erro de sistema.");
            }

            var usuarioPorId = await _usuarioRepository.BuscarPorId(usuario.Id);

            if (usuarioPorId is null)
            {
                throw new Exception("Usuário a ser alterado não foi encontrado na base de dados.");
            }
            else
            {
                var usuarioPorCPF = await _usuarioRepository.BuscarPorCPF(usuario.CPF);

                if (usuarioPorCPF is null || usuarioPorCPF.Id != usuario.Id)
                {
                    usuarioPorId.Nome = usuario.Nome;
                    usuarioPorId.CPF = usuario.CPF;
                    usuarioPorId.Celular = usuario.Celular;
                    usuarioPorId.Email = usuario.Email;
                    usuarioPorId.Endereco = usuario.Endereco;
                    usuarioPorId.Cidade = usuario.Cidade;
                    usuarioPorId.DataNascimento = usuario.DataNascimento;
                    usuarioPorId.Sexo = usuario.Sexo;
                }

                return await _usuarioRepository.Atualizar(usuarioPorId);
            }
        }

        public async Task Remover(int usuarioId)
        {
            if (usuarioId <= 0)
            {
                throw new Exception("Erro de sistema.");
            }

            var usuarioPorId = await _usuarioRepository.BuscarPorId(usuarioId);

            if (usuarioPorId is null)
            {
                throw new Exception("Usuário a ser alterado não foi encontrado na base de dados.");
            }
            else
            {
                await _usuarioRepository.Remover(usuarioPorId);
            }
        }
    }
}
