using System.ComponentModel.DataAnnotations;

namespace PCS.Extension.Data.Entities
{
    public class Products
    {
        /// <summary>
        /// mã sản phẩm
        /// </summary>
        [Key]
        public int ProductId { get; set; }
        /// <summary>
        /// tên sản phẩm
        /// </summary>
        public string ProductTitle { get; set; }
        /// <summary>
        /// đường dẫn 
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// đường dẫn ảnh
        /// </summary>
        public string ProductImageSrc { get; set; }
        public string Availability { get; set; }
        /// <summary>
        /// giá
        /// </summary>
        public string Price { get; set; }

        public decimal? LastPrice { get; set; }
        public bool? Status { get; set; }
        public int SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public string ClientCardId { get; set; }
        public ClientCard ClientCard { get; set; }
    }
}
