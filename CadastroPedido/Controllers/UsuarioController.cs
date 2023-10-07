using CadastroPedido.Domain.Model;
using CadastroPedido.Domain.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroPedido.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> BuscarTodos()
        {
            List<Usuario> usuarios = await _usuarioService.BuscarTodos();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Usuario>>> BuscarPorId(int id)
        {
            Usuario usuario = await _usuarioService.BuscarPorId(id);

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(Usuario usuario)
        {
            var novoUsuario = await _usuarioService.Adicionar(usuario, null);

            return Ok(novoUsuario);
        }

        [HttpPut]
        public async Task<ActionResult> Atualizar(Usuario usuario)
        {
            var usuarioAtualizado = await _usuarioService.Atualizar(usuario, null);

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remover(int id)
        {
            await _usuarioService.Remover(id);

            return Ok();
        }
    }
}
