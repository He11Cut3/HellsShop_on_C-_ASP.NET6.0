namespace H_Shop.Models
{
    public class HShopProduct
    {
        public long HShopProductID { get; set; }
        public string HShopProductName { get; set; }

        public string HShopProductDescription { get; set; }

        public decimal HShopProductCost { get; set; }

        public byte[] HShopProductImage { get; set; }
    }
}
