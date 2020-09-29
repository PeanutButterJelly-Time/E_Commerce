using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IProduct
    {
        IEnumerable<Cereal> GetCereals();
        object GetCereal(int id);
        object GetCerealName(string name);
    }
}
