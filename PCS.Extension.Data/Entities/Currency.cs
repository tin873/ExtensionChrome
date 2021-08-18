using System;
using System.Collections.Generic;
using System.Text;

namespace PCS.Extension.Data.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime GetDateTime { set; get; }
    }
}
