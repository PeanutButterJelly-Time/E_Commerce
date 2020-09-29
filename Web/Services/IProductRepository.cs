using System.Collections.Generic;
using Web.Models;

namespace Web.Services
{
    public interface IProductRepository
    {
        IEnumerable<Cereal> GetCereals(string sortBy, string name);

        Cereal GetCereal(int id);

        Cereal GetCerealName(string name);
    }
}