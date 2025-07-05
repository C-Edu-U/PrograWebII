using HabitTrackerAPI.Models;
using HabitTrackerAPI.Business.Contracts;
using HabitTrackerAPI.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerAPI.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _IRolRepository;

        public RolService(IRolRepository tempI)
        {
            _IRolRepository = tempI;
        }

        public Task<List<Rol>> GetList() => _IRolRepository.GetList();

        public Task<Rol> AgregaActualiza(Rol l, string t) => _IRolRepository.AgregaActualiza(l, t);
    }
}
