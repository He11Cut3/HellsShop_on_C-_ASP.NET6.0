namespace H_Shop.Models
{
    public class CartItem
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total
        {
            get { return Quantity * Price; }
        }

        public byte[] Images { get; set; }

        public CartItem()
        {
        }

        public CartItem(HShopProduct product)
        {
            ProductId = product.HShopProductID;
            ProductName = product.HShopProductName;
            Price = product.HShopProductCost;
            Quantity = 1;
            Images = product.HShopProductImage;
        }

    }
}
