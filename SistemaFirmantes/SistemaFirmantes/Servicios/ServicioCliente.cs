using SistemaFirmantes.Context;
using SistemaFirmantes.Interfaces;
using SistemaFirmantes.Models;
namespace SistemaFirmantes.Servicios
{
    public class ServicioCliente : InterfaceCliente
    {
        private readonly DB_Context contexto;
        public ServicioCliente(DB_Context _contexto)
        {
            contexto = _contexto;
        }
        public List<Cliente> getAll()
        {
            return contexto.Clientes.ToList();
        }
        public async Task<Cliente> Create(dtoCliente cliente)
        {
            var nuevoCliente = new Cliente();
            /*nuevoCliente.id = cliente.id;*/
            nuevoCliente.usuario = cliente.usuario;
            nuevoCliente.nombre = cliente.nombre;
            nuevoCliente.contrasena = cliente.contrasena;
            nuevoCliente.email = cliente.email;
            nuevoCliente.telefono = cliente.telefono;
            nuevoCliente.razon_social = cliente.razon_social;
            nuevoCliente.cargo = cliente.cargo;
/*            nuevoCliente.requiere_factura = cliente.requiere_factura;
            nuevoCliente.tipo_persona = cliente.tipo_persona;
            nuevoCliente.cfdi = cliente.cfdi;
            nuevoCliente.domicilio_fiscal = cliente.domicilio_fiscal;
            nuevoCliente.regimen_fiscal = cliente.regimen_fiscal;
            nuevoCliente.rfc = cliente.rfc;
            nuevoCliente.razon_social = cliente.razon_social;*/
            contexto.Add(nuevoCliente);
            await contexto.SaveChangesAsync();
            return nuevoCliente;
        }

        public async Task<Cliente> Update(int id, Cliente cliente)
        {
            var clienteExistente = await contexto.Clientes.FindAsync(id);
            if(clienteExistente==null)
            {
                throw new Exception("Usuario no encontrado");
            }

            clienteExistente.usuario = cliente.usuario;
            clienteExistente.nombre = cliente.nombre;
            clienteExistente.contrasena = cliente.contrasena;
            clienteExistente.email = cliente.email;
            clienteExistente.telefono = cliente.telefono;
            clienteExistente.cargo = cliente.cargo;
            clienteExistente.requiere_factura = cliente.requiere_factura;
            clienteExistente.tipo_persona = cliente.tipo_persona;
            clienteExistente.cfdi = cliente.cfdi;
            clienteExistente.domicilio_fiscal = cliente.domicilio_fiscal;
            clienteExistente.regimen_fiscal = cliente.regimen_fiscal;
            clienteExistente.rfc = cliente.rfc;
            clienteExistente.razon_social = cliente.razon_social;

            await contexto.SaveChangesAsync();
            return clienteExistente;
        }

        public Cliente GetCliente(int id)
        {
/*            var usuarioExistente = await contexto.Usuarios.FindAsync(id);
            if (usuarioExistente == null)
            {
                throw new Exception("Usuario no encontrado");
            }*/
            return contexto.Clientes.FirstOrDefault(u => u.id == id);
        }

        public void DeleteCliente(int id)
        {
            var cliente = contexto.Clientes.FirstOrDefault(u => u.id == id);
            if(cliente != null)
            {
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await contexto.SaveChangesAsync();
        }
        public bool UsuarioExists(int id)
        {
            return contexto.Clientes.Any(u => u.id == id);
        }
            
    }
}
