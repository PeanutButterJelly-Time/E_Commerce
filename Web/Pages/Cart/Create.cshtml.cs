using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Data;
using Web.Models.Cart;

namespace Web.Pages.Cart
{
    public class CreateModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;

        public CreateModel(Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Discriminator");
            return Page();
        }

        [BindProperty]
        public CartItem CartItem { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CartItems.Add(CartItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
