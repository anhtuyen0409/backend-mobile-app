using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dacn_api.DTO
{
    public class UserDTO
    {
        public int MaThanhVien { get; set; }
        public string MatKhau { get; set; }
        public string XacNhanMatKhau { get; set; }
        public string Email { get; set; }
        public string TenHienThi { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public int? MaLoaiThanhVien { get; set; }
        public int? Status { get; set; }
        public string HinhAnh { get; set; }
    }
}