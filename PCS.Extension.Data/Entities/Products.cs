using System;
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
        public int SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        /// quy đổi thành giá trị tiền việt
        /// </summary>
        public decimal ExchangePice
        {
            get
            {
                decimal price = 0;
                if (CurrencyId == Currency.CurencyId)
                {
                    price = decimal.Parse(Price) * Currency.ExchangeRate;
                    price = Math.Ceiling(price);
                }
                return price;
            }
        }

        public string ClientCardId { get; set; }
        public ClientCard ClientCard { get; set; }
    }
}
