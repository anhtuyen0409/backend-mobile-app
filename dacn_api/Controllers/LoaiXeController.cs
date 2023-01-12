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
    public class LoaiXeController : ApiController
    {
        APIContext dbContext = new APIContext();

        //hiển thị toàn bộ loại xe
        [HttpGet]
        public List<LoaiXeDTO> hienThiToanBoLoaiXe()
        {
            var q = from c in dbContext.LoaiXes
                    where c.Status == 0
                    select new LoaiXeDTO
                    {
                        MaLoaiXe = c.MaLoaiXe,
                        TenLoaiXe = c.TenLoaiXe,
                        Status = c.Status
                    };
            return q.ToList();
        }
    }
}
