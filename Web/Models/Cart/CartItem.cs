namespace Web.Models.Cart
{
    public class CartItem
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
