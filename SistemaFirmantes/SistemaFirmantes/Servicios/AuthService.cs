using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaFirmantes.Context;
using SistemaFirmantes.Interfaces;
using SistemaFirmantes.Models;

public class AuthService : IAuthService
{
    private readonly DB_Context _context;

    public AuthService(DB_Context context)
    {
        _context = context;
    }

    public async Task<bool> AuthenticateUser(string usuario, string contrasena)
    {
        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.usuario == usuario);

        if (cliente == null)
        {
            return false; // Usuario no encontrado
        }

        // Aquí puedes implementar la lógica de validación de contraseña
        // Puedes utilizar librerías de encriptación o comparar las contraseñas en texto plano

        // Ejemplo de validación básica de contraseña en texto plano
        return cliente.contrasena == contrasena;
    }
}
