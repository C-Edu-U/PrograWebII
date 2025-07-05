using WebApplication2.Business.Clases;
using WebApplication2.Business.contracts;
using WebApplication2.models;
using WebApplication2.Services.Contracts;

namespace WebApplication2.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _repository;
        public RolService(IRolRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Rol>> GetList()
        {
            return _repository.GetList();
        }

    }
}
