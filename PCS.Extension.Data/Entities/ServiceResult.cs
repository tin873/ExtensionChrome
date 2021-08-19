using PCS.Extension.Data.Enum;
using System.Collections.Generic;

namespace PCS.Extension.Data.Entities
{
    /// <summary>
    /// thông tin trả về kết quả API
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// trạng thái thao tác (true- thành công . false-thất bại)
        /// </summary>
        public bool IsSuccess { get; set; } = true;
        /// <summary>
        /// dữ liệu trả về
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// danh sách thông báo lỗi cho người dùng
        /// </summary>
        public List<string> UserMsg { get; set; }
        /// <summary>
        /// thông báo lỗi cho dev
        /// </summary>
        public string DevMsg { get; set; }
        /// <summary>
        /// mã code lỗi
        /// </summary>
        public ExtensionCode ExtensionCode { get; set; }

        public ServiceResult()
        {
            this.UserMsg = new List<string>();
        }
    }
}
