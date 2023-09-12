using SistemaFirmantes.Context;
using SistemaFirmantes.Models;

namespace SistemaFirmantes.Interfaces
{
    public interface IAuthService
    {
        Task<bool> AuthenticateUser(string usuario, string contrasena);
    }
}
