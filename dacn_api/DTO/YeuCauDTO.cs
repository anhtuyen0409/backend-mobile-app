using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dacn_api.DTO
{
    public class YeuCauDTO
    {
        public int? MaThanhVien { get; set; }
        public int? MaDatXe { get; set; }
        public string TenHienThi { get; set; }
        public string HinhAnh { get; set; }
        public string ViTriBatDau { get; set; }
        public string ViTriKetThuc { get; set; }
        public int? TongThanhToan { get; set; }
    }
}