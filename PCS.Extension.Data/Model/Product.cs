namespace PCS.Extension.Data.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string ProductImageSrc { set; get; }
    }
}
