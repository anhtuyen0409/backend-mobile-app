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
    public class HinhThucThanhToanController : ApiController
    {
        APIContext dbContext = new APIContext();

        //hiển thị toàn bộ hinh thuc thanh toan
        [HttpGet]
        public List<HinhThucThanhToanDTO> hienThiToanBoHinhThucThanhToan()
        {
            var q = from c in dbContext.HinhThucThanhToans
                    select new HinhThucThanhToanDTO
                    {
                        MaHinhThuc = c.MaHinhThuc,
                        TenHinhThuc = c.TenHinhThuc
                    };
            return q.ToList();
        }

    }
}
