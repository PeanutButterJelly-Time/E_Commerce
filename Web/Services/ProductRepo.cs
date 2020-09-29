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
        private static string path = Environment.CurrentDirectory;
        private static string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot/cereal.csv"));
        private static string[] myFile = File.ReadAllLines(newPath);
        private readonly List<Cereal> Cereals = new List<Cereal>();
        public ProductRepo()
        {
            int x = 1;
            foreach (string line in myFile)
            {
                string[] column = line.Split(",");
                var cereal = new Cereal
                {
                    Id = x++,
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
                };

                cereal = TypeOfCereal(cereal);

                Cereals.Add(Manufacturer(cereal));

            }
        }

        private Cereal Manufacturer(Cereal cereal)
        {
            if (cereal.Manufacturer == "A")
                cereal.Manufacturer = "American Home Food Products";
            else if (cereal.Manufacturer == "G")
                cereal.Manufacturer = "General Mills";
            else if (cereal.Manufacturer == "K")
                cereal.Manufacturer = "Kelloggs";
            else if (cereal.Manufacturer == "N")
                cereal.Manufacturer = "Nabisco";
            else if (cereal.Manufacturer == "P")
                cereal.Manufacturer = "Post";
            else if (cereal.Manufacturer == "Q")
                cereal.Manufacturer = "Quaker Oats";
            else if (cereal.Manufacturer == "R")
                cereal.Manufacturer = "Ralston Purina";

            return cereal;
         }
        private Cereal TypeOfCereal(Cereal cereal)
        {
            if (cereal.Type == "H")
                cereal.Type = "Hot";
            else cereal.Type = "Cold";
            return cereal;
        }
        

        public IEnumerable<Cereal> GetCereals(string sortBy, string name, string searchParam)
        {
            if(name != null)
            {
                switch(searchParam)
                {
                    case "Name":
                        return Cereals.Where(c => c.Name.ToLower() == name.ToLower());
                    case "Manufacturer":
                        return Cereals.Where(c => c.Manufacturer.ToLower() == name.ToLower());
                }
                
            }
            switch (sortBy)
            {
                case "Ascending":
                    return Cereals.OrderBy(c => c.Name);
                case "Descending":
                    return Cereals.OrderByDescending(c => c.Name);
                default:
                    return Cereals;
            }
            
            
        }
        public object GetCereal(int id)
        {
            return Cereals.FirstOrDefault(c => c.Id == id);
        }

        public object GetCerealName(string name)
        {
            return Cereals.FirstOrDefault(c => c.Name == name);
        }

        public Cereal GetCereal(string name)
        {
            return Cereals.FirstOrDefault(c => c.Name == name);
        }
    }
}
