using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dacn_api.DTO
{
    public class LoaiXeDTO
    {
        public int MaLoaiXe { get; set; }
        public string TenLoaiXe { get; set; }
        public int? Status { get; set; }
    }
}