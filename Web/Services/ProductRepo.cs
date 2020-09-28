using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class ProductRepo : IProduct
    {
        private readonly List<Cereal> Cereals = new List<Cereal>
        
        {
          
        };
        private static string path = Environment.CurrentDirectory;
        private static string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\cereal.csv"));
        private static string[] myFile = File.ReadAllLines(newPath);
        

        public IEnumerable<Cereal> GetCereals()
        {
            foreach(string line in myFile)
            {
                string[] column = line.Split(",");
                Cereals.Add(new Cereal
                {
                    Name = column[0],
                    Manufacturer = column[1],
                    Type = column[2],
                    Calories = Convert.ToDouble(column[3]),
                    Protein = Convert.ToDouble(column[4]),
                    Fat = Convert.ToDouble(column[5]),
                    Sodium = Convert.ToDouble(column[6]),
                    Fiber = Convert.ToDouble(column[7]),
                    Carbo = Convert.ToDouble(column[8]),
                    Sugars = Convert.ToDouble(column[9]),
                    Potassium = Convert.ToDouble(column[10]),
                    Vitamins = Convert.ToInt32(column[11]),
                    Shelf = Convert.ToInt32(column[12]),
                    Weight = Convert.ToDouble(column[13]),
                    Cups = Convert.ToDouble(column[14]),
                    Rating = Convert.ToDouble(column[15]),
                });
                
            }
            return Cereals;
        }
    }
}
