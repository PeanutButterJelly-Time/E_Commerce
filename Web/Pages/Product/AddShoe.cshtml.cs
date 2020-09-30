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
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProductModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
          
        }
       
        public IActionResult OnPostAsync()
        {
            if(ModelState.IsValid)
            {
               _context.Products.Add(new Shoe() { Name = Input.Name, Manufacturer = Input.Manufacturer });
               _context.SaveChanges();
              
            }
            return Page();
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public string Name { get; set; }
            public string Manufacturer { get; set; }

        }
    }
}
