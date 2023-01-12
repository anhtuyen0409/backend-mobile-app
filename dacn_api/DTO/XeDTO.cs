using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dacn_api.DTO
{
    public class XeDTO
    {
        public int MaXe { get; set; }
        public string TenXe { get; set; }
        public int? Gia { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public int? MaNhaSanXuat { get; set; }
        public int? MaLoaiXe { get; set; }
        public int? MaThanhVien { get; set; }
        public int? MaHinhThucDatXe { get; set; }
        public int? Status { get; set; }
        public string DiaChi { get; set; }
        public double? KinhDo { get; set; }
        public double? ViDo { get; set; }
        public int? DaXoa { get; set; }
    }
}