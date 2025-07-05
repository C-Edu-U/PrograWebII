using Microsoft.AspNetCore.Mvc;
using HabitTrackerAPI.Models;
using HabitTrackerAPI.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly IRolService _IRolService;

        public RolController(IRolService iTemp)
        {
            _IRolService = iTemp;
        }

        [HttpGet]
        public async Task<List<Rol>> GetList()
        {
            return await _IRolService.GetList();
        }

        [HttpPost("AgregaActualiza")]
        public async Task<Rol> AgregaActualiza(int Id, string NombreRol, string t)
        {
            var rol = new Rol { Id = Id, NombreRol = NombreRol };
            return await _IRolService.AgregaActualiza(rol, t);
        }
    }
}
