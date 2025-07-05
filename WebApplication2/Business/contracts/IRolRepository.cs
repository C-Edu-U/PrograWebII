using WebApplication2.models;

namespace WebApplication2.Business.contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
    }
}
