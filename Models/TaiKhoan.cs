using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Models
{
    public class TaiKhoan
    {
        [Key]
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaNV { get; set; }
        public string Role { get; set; }
    }
}
