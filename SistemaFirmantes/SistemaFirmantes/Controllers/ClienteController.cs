using SistemaFirmantes.Context;
using Microsoft.AspNetCore.Mvc;
using SistemaFirmantes.Interfaces;
using SistemaFirmantes.Models;

namespace SistemaFirmantes.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly InterfaceCliente _clienteService;

        public ClienteController(InterfaceCliente clienteService)
        {
            _clienteService = clienteService;
        }
        [HttpPost] //Task<ActionResult<Cliente>> [FromBody] 
        public async Task<RegisterModelResponse> CrearCliente(RegisterModel cliente)
        {
            var nuevoUsuario = new dtoCliente();
            nuevoUsuario.usuario = cliente.Usuario;
            nuevoUsuario.contrasena = cliente.Contrasena;
            nuevoUsuario.nombre=cliente.Nombre;
            nuevoUsuario.email=cliente.CorreoElectronico;
            nuevoUsuario.telefono=cliente.Telefono;
            nuevoUsuario.razon_social=cliente.RazonSocial;
            nuevoUsuario.cargo=cliente.Cargo;
            try
            {
                var nuevoCliente = await _clienteService.Create(nuevoUsuario);
                return new RegisterModelResponse { Message = "Exito" };
            }
            catch (Exception ex)
            {
                return new RegisterModelResponse { Message = ex.ToString() };
            }
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetClientes()
        {
            var clientes = _clienteService.getAll();
            return Ok(clientes);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cliente cliente)
        {
            if (id != cliente.id)
            {
                return BadRequest();
            }

            await _clienteService.Update(id, cliente);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clienteService.GetCliente(id);
            if (cliente == null)
                {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clienteService.DeleteCliente(id);
            return NoContent();
        }

    }

}
