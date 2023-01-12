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
    public class DanhGiaController : ApiController
    {
        //đánh giá xe
        APIContext dbContext = new APIContext();
        [HttpGet]
        public bool DanhGia(int maThanhVien, int maXe, string noiDung, float diem)
        {
            try
            {
                DanhGiaXe dg = new DanhGiaXe();
                dg.MaThanhVien = maThanhVien;
                dg.MaXe = maXe;
                dg.NoiDung = noiDung;
                dg.Diem = diem;
                dbContext.DanhGiaXes.Add(dg);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }

        //hiển thị toàn bộ đánh giá theo mã xe
        [HttpGet]
        public List<DanhGiaDTO> HienThiDanhGiaTheoMaXe(int maXe)
        {

            var q = from dg in dbContext.DanhGiaXes
                    where dg.MaXe == maXe 
                    join tv in dbContext.ThanhViens
                    on dg.MaThanhVien equals tv.MaThanhVien
                    select new DanhGiaDTO
                    {
                        HinhAnh = tv.HinhAnh,
                        TenHienThi = tv.TenHienThi,
                        Diem = dg.Diem,
                        NoiDung = dg.NoiDung
                        
                    };
            return q.ToList();

        }
    }
}
