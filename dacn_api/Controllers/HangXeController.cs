using dacn_api.DTO;
using dacn_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dacn_api.Controllers
{
    public class HangXeController : ApiController
    {
        APIContext dbContext = new APIContext();

        //hiển thị toàn bộ hãng xe
        [HttpGet]
        public List<HangXeDTO> hienThiToanBoHangXe()
        {
            var q = from c in dbContext.NhaSanXuats
                    select new HangXeDTO
                    {
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        TenNhaSanXuat = c.TenNhaSanXuat
                    };
            return q.ToList();
        }
    }
}
