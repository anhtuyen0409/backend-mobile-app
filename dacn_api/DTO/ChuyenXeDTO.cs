using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dacn_api.DTO
{
    public class ChuyenXeDTO
    {
        public int MaDatXe { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? TongThanhToan { get; set; }
        public string TenHinhThuc { get; set; }
    }
}