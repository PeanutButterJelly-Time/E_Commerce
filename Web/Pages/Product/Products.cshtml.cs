using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models.Cart;
using Web.Models.Identity;

namespace Web.Pages.Product
{
    public class ProductsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public ProductsModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
            

        }
       
        public List<Models.Product> List = new List<Models.Product>();

        public void OnGet()
        {
            List = _context.Products.ToList();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var userId = userManager.GetUserId(User);

                var existingCartItem = await _context.CartItems
                    .FirstOrDefaultAsync(c =>
                        c.ProductId == Input.ProductId &&
                        c.UserId == userId
                    );

                if (existingCartItem == null)
                {
                    var item = new CartItem()
                    {
                        UserId = userId,
                        ProductId = Input.ProductId,
                        Quantity = Input.Quantity,
                    };
                    _context.CartItems.Add(item);
                }
                else
                {
                    existingCartItem.Quantity += Input.Quantity;
                }

                await _context.SaveChangesAsync();
                return LocalRedirect("/Product/Products");
            }

            return Page();
        }

        [BindProperty]
        public ProductInput Input { get; set; }
        public class ProductInput
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }


    
}