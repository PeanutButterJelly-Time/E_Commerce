using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IProductRepository
    {
        IEnumerable<Cereal> GetCereals(string sortBy, string name);
        object GetCereal(int id);
        object GetCerealName(string name);
    }
}
