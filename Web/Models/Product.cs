using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract double Rating { get; set; }
        
    }
}
