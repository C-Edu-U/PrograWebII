using WebApplication2.models;

namespace WebApplication2.Services.Contracts
{
    public interface IRolService
    {
        Task<List<Rol>> GetList();
    }
}
