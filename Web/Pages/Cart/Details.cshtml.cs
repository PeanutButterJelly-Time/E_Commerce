using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models.Cart;

namespace Web.Pages.Cart
{
    public class DetailsModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;

        public DetailsModel(Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public CartItem CartItem { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CartItem = await _context.CartItems
                .Include(c => c.Product).FirstOrDefaultAsync(m => m.UserId == id);

            if (CartItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
