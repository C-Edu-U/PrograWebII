﻿using HabitTrackerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerAPI.Business.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);
    }
}
