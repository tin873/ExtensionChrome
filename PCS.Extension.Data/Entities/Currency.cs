using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCS.Extension.Data.Entities
{
    public class Currency
    {
        [Key]
        public int CurencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime GetDateTime { set; get; }

        public ICollection<Products> Products { get; set; }
    }
}
