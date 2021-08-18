using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
