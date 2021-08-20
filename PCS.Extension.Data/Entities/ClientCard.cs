using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCS.Extension.Data.Entities
{
    public class ClientCard
    {
        /// <summary>
        /// mã định danh client mua sản phẩm
        /// </summary>
        [Key]
        public Guid ClientCardId { get; set; }
        /// <summary>
        /// trạng thái giỏ hàng
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// ngày đặt
        /// </summary>
        public DateTime CreateDate { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
