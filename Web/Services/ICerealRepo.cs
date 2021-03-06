﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface ICerealRepo
    {
        IEnumerable<Cereal> GetCereals(string sortBy, string name, string searchParam);
        Cereal GetCereal(int id);
        IEnumerable<Cereal> PopulateCerealsTable();
    }
}
