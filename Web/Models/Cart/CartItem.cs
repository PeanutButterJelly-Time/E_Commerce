using Web.Models.Identity;

namespace Web.Models.Cart
{
    public class CartItem
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
