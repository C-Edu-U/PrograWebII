using HabitTrackerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerAPI.Services.Contracts
{
    public interface IRolService
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);
    }
}
