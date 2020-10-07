using System.ComponentModel.DataAnnotations.Schema;
using Web.Models.Identity;

namespace Web.Models.Cart
{
    public class CartItem
    {
        [ForeignKey(nameof(User))] // Optional in this case, but sometimes necessary
        public string UserId { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }

        // Navigation Properties
        public ApplicationUser User { get; set; }

        public Product Product { get; set; }
    }
}