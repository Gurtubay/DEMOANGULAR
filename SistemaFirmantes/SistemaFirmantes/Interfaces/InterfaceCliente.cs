using SistemaFirmantes.Context;
using SistemaFirmantes.Models;
namespace SistemaFirmantes.Interfaces
{
    public interface InterfaceCliente
    {
        List<Cliente> getAll();
        Cliente GetCliente(int id);
        Task<Cliente> Create(dtoCliente cliente);
        void DeleteCliente(int id);
        Task<Cliente> Update(int id, Cliente cliente);

    }
}
