using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Data;
using Web.Models;

namespace Web.Pages.Product
{
    public class ProductsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProductsModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Shoe> List = new List<Shoe>();
        public void OnGet()
        {
            foreach (var product in _context.Products)
            {
                if(product.Discriminator == "Shoe")
                    List.Add(new Shoe(){ Id = product.Id, Name = product.Name, Manufacturer = product.Manufacturer});
            }
        }
    }
}
