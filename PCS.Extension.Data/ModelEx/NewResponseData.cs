using System;
using System.Collections.Generic;
using System.Text;

namespace PCS.Extension.Data.ModelEx
{
    public class NewResponseData
    {
        public int Id { get; set; }
        public string UserName { set; get; }
        public string ProductTitle { get; set; }
        public string Url { get; set; }
        public string ProductImageSrc { get; set; }
        public string Availability { get; set; }
        public string Price { get; set; }
        public DateTime GetDate { get; set; }
        public string Status { get; set; }
        public string PageName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
