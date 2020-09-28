using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Cereal : Product
    {
        public override string Name { get; set; }
        public override string Manufacturer { get; set; }
        public string Type { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Sodium { get; set; }
        public double Fiber { get; set; }
        public double Carbo { get; set; }
        public double Sugars { get; set; }
        public double Potassium { get; set; }
        public int Vitamins { get; set; }
        public int Shelf { get; set; }
        public double Weight { get; set; }
        public double Cups { get; set; }
        public override double Rating { get; set; }
    }
   
}
