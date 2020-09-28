using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class ProductRepo : IProduct
    {
        private readonly List<Cereal> Cereals = new List<Cereal>
        {
            new Cereal
            {
                Name = "Something",
                Manufacturer = "Quakers Bitch Ass",
                Rating = 0.2,
            },
            new Cereal
            {
                Name = "Something Else",
                Manufacturer = "General Mills",
                Rating = 1.2,
            },
        };
        public IEnumerable<Cereal> GetCereals()
        {
            return Cereals;
        }
    }
}
