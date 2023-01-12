using dacn_api.DTO;
using dacn_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace dacn_api.Controllers
{
    public class XeController : ApiController
    {
        APIContext dbContext = new APIContext();
        //hiển thị toàn bộ xe tự lái gia re
        [HttpGet]
        public List<XeDTO> HienThiXeTuLaiNoiBat()
        {
            var q = (from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 &&c.Status == 0
                    orderby c.Gia
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    }).Take(5);
            return q.ToList();

        }

        //hiển thị toàn bộ xe tự lái mới nhất
        [HttpGet]
        public List<XeDTO> HienThiXeTuLaiMoiNhat()
        {
            var q = (from c in dbContext.Xes
                     where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0
                     orderby c.MaXe descending
                     select new XeDTO
                     {
                         MaXe = c.MaXe,
                         TenXe = c.TenXe,
                         Gia = c.Gia,
                         HinhAnh = c.HinhAnh,
                         MoTa = c.MoTa,
                         MaNhaSanXuat = c.MaNhaSanXuat,
                         MaLoaiXe = c.MaLoaiXe,
                         MaThanhVien = c.MaThanhVien,
                         Status = c.Status,
                         DiaChi = c.DiaChi,
                         KinhDo = c.KinhDo,
                         ViDo = c.ViDo
                     }).Take(5);
            return q.ToList();

        }

        //hiển thị toàn bộ xe co tai xe mới nhất
        [HttpGet]
        public List<XeDTO> HienThiXeCoTaiXeMoiNhat()
        {
            var q = (from c in dbContext.Xes
                     where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0
                     orderby c.MaXe descending
                     select new XeDTO
                     {
                         MaXe = c.MaXe,
                         TenXe = c.TenXe,
                         Gia = c.Gia,
                         HinhAnh = c.HinhAnh,
                         MoTa = c.MoTa,
                         MaNhaSanXuat = c.MaNhaSanXuat,
                         MaLoaiXe = c.MaLoaiXe,
                         MaThanhVien = c.MaThanhVien,
                         Status = c.Status,
                         DiaChi = c.DiaChi,
                         KinhDo = c.KinhDo,
                         ViDo = c.ViDo
                     }).Take(5);
            return q.ToList();

        }

        //hiển thị toàn bộ xe có tài xế gia re
        [HttpGet]
        public List<XeDTO> HienThiXeCoTaiXeNoiBat()
        {
            var q = (from c in dbContext.Xes
                     where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0
                     orderby c.Gia
                     select new XeDTO
                     {
                         MaXe = c.MaXe,
                         TenXe = c.TenXe,
                         Gia = c.Gia,
                         HinhAnh = c.HinhAnh,
                         MoTa = c.MoTa,
                         MaNhaSanXuat = c.MaNhaSanXuat,
                         MaLoaiXe = c.MaLoaiXe,
                         MaThanhVien = c.MaThanhVien,
                         Status = c.Status,
                         DiaChi = c.DiaChi,
                         KinhDo = c.KinhDo,
                         ViDo = c.ViDo
                     }).Take(5);
            return q.ToList();
        }
        
        //hiển thị toàn bộ xe tự lái
        [HttpGet]
        public List<XeDTO> HienThiToanBoXeTuLai()
        {
            //List<Xe> dsXeTuLai = dbContext.Xes.Where(t => t.MaHinhThucDatXe == 2).ToList();
            //return dsXeTuLai;

            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0

                    select new XeDTO{
                        MaXe = c.MaXe, 
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //hiển thị toàn bộ xe có tài xế
        [HttpGet]
        public List<XeDTO> HienThiToanBoXeCoTaiXe()
        {
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //hiển thị chi tiết xe tự lái
        [HttpGet]
        public Xe ChiTietXeTuLai(int id)
        {
            Xe xe = dbContext.Xes.FirstOrDefault(x => x.MaXe == id && x.MaHinhThucDatXe == 2 && x.DaXoa == 0 && x.Status == 0);
           
            return xe;
        }
        
        //lấy chi tiết xe tự lái theo tên xe
        [HttpGet]
        public Xe LayChiTietXeTuLaiTheoTen(string ten)
        {
            Xe xe = dbContext.Xes.FirstOrDefault(x => x.TenXe == ten && x.MaHinhThucDatXe == 2 && x.DaXoa == 0 && x.Status == 0);
            return xe;
        }

        //tìm xe tự lái theo tên
        [HttpGet]
        public List<XeDTO> TimKiemXeTuLaiTheoTen(string ten)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.TenXe.Contains(ten) && x.MaHinhThucDatXe == 2).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0 && c.TenXe.Contains(ten)
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //tìm xe tự lái theo địa chỉ
        [HttpGet]
        public List<XeDTO> TimKiemXeTuLaiTheoDiaChi(string diaChi)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.TenXe.Contains(ten) && x.MaHinhThucDatXe == 2).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DiaChi.Contains(diaChi)
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }


        //tìm xe có tài xế theo tên
        [HttpGet]
        public List<XeDTO> TimKiemXeCoTaiXeTheoTen(string ten)
        {
            // List<Xe> xes = dbContext.Xes.Where(x => x.TenXe.Contains(ten) && x.MaHinhThucDatXe == 1).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0 && c.TenXe.Contains(ten)
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }



        //lọc xe tự lái theo loại xe
        [HttpGet]
        public List<XeDTO> LocXeTuLaiTheoLoaiXe(int maLoai)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.MaLoaiXe == maLoai && x.MaHinhThucDatXe == 2).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0 && c.MaLoaiXe == maLoai
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //lọc xe có tài xế theo loại xe
        [HttpGet]
        public List<XeDTO> LocXeCoTaiXeTheoLoaiXe(int maLoai)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.MaLoaiXe == maLoai && x.MaHinhThucDatXe == 1).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0 && c.MaLoaiXe == maLoai
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //lọc xe tự lái theo hãng xe
        [HttpGet]
        public List<XeDTO> LocXeTuLaiTheoHangXe(int maHangXe)
        {
            // List<Xe> xes = dbContext.Xes.Where(x => x.MaNhaSanXuat == maHangXe && x.MaHinhThucDatXe == 2).ToList();
            // return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0 && c.MaNhaSanXuat == maHangXe
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //lọc xe có tài xế theo hãng xe
        [HttpGet]
        public List<XeDTO> LocXeCoTaiXeTheoHangXe(int maHangXe)
        {
            // List<Xe> xes = dbContext.Xes.Where(x => x.MaNhaSanXuat == maHangXe && x.MaHinhThucDatXe == 1).ToList();
            // return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0 && c.MaNhaSanXuat == maHangXe
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //lọc xe tự lái theo giá
        [HttpGet]
        public List<XeDTO> LocXeTuLaiTheoGia(int gia)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.Gia <= gia && x.MaHinhThucDatXe == 2).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 2 && c.DaXoa == 0 && c.Status == 0 && c.Gia <= gia
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //lọc xe có tài xế theo giá
        [HttpGet]
        public List<XeDTO> LocXeCoTaiXeTheoGia(int gia)
        {
            //List<Xe> xes = dbContext.Xes.Where(x => x.Gia <= gia && x.MaHinhThucDatXe == 1).ToList();
            //return xes;
            var q = from c in dbContext.Xes
                    where c.MaHinhThucDatXe == 1 && c.DaXoa == 0 && c.Status == 0 && c.Gia <= gia
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        [HttpGet]
        public List<XeDTO> HienThiXeTheoMaThanhVien(int maThanhVien)
        {
            
            var q = from c in dbContext.Xes
                    where c.MaThanhVien == maThanhVien && c.DaXoa == 0 
                    select new XeDTO
                    {
                        MaXe = c.MaXe,
                        TenXe = c.TenXe,
                        Gia = c.Gia,
                        HinhAnh = c.HinhAnh,
                        MoTa = c.MoTa,
                        MaNhaSanXuat = c.MaNhaSanXuat,
                        MaLoaiXe = c.MaLoaiXe,
                        MaThanhVien = c.MaThanhVien,
                        Status = c.Status,
                        DiaChi = c.DiaChi,
                        KinhDo = c.KinhDo,
                        ViDo = c.ViDo
                    };
            return q.ToList();
        }

        //chỉnh sửa thông tin xe
        [HttpGet]
        public bool ChinhSuaThongTinXe(int maXe, string tenXe, int gia, string diaChi, string hinhAnh)
        {
            try
            {
                Xe xe = dbContext.Xes.FirstOrDefault(x => x.MaXe == maXe);
                if (xe != null)
                {
                    xe.TenXe = tenXe;
                    xe.Gia = gia;
                    xe.DiaChi = diaChi;
                    xe.HinhAnh = hinhAnh;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        //xử lý thêm xe tu lai
        [HttpGet]
        public bool ThemXeTuLai(int maThanhVien,  string tenXe, int maHangXe, int maLoaiXe, int gia, 
            string diaChi, string moTa, string hinhAnh)
        { 
            try
            {
                Xe xe = new Xe();
                xe.MaThanhVien = maThanhVien;
                xe.TenXe = tenXe;
                xe.MaNhaSanXuat = maHangXe;
                xe.MaLoaiXe = maLoaiXe;
                xe.Gia = gia;
                xe.DiaChi = diaChi;
                xe.MoTa = moTa;
                xe.HinhAnh = hinhAnh;
                xe.MaHinhThucDatXe = 2;
                xe.Status = 0;
                xe.DaXoa = 0;
                xe.KinhDo = 0;
                xe.ViDo = 0;
                dbContext.Xes.Add(xe);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                
            }
            return false;
        }

        //hien thi xe yeu cau theo ma thanh vien
        [HttpGet]
        public List<YeuCauDTO> HienThiXeYeuCauTheoMaThanhVien(int maThanhVien)
        {

            var q = from x in dbContext.Xes
                    where x.MaThanhVien == maThanhVien && x.DaXoa == 0 && x.Status == 1
                    join ct in dbContext.ChiTietDatXes 
                    on x.MaXe equals ct.MaXe 
                    join dx in dbContext.DatXes
                    on ct.MaDatXe equals dx.MaDatXe
                    join tv in dbContext.ThanhViens
                    on dx.MaThanhVien equals tv.MaThanhVien
                    select new YeuCauDTO
                    {  
                         MaThanhVien = dx.MaThanhVien,
                         MaDatXe = dx.MaDatXe,
                         TenHienThi = tv.TenHienThi,
                         HinhAnh = tv.HinhAnh,
                         ViTriBatDau = dx.ViTriBatDau,
                         ViTriKetThuc = dx.ViTriKetThuc,
                         TongThanhToan = ct.TongThanhToan
                    };
            return q.ToList();

        }

        //hien thi xe yeu cau theo ma thanh vien
        [HttpGet]
        public List<YeuCauDTO> HienThiChiTietYeuCauTheoMaDatXe(int maDatXe)
        {

            var q = from x in dbContext.DatXes
                    where x.MaDatXe == maDatXe
                    join tv in dbContext.ThanhViens
                    on x.MaThanhVien equals tv.MaThanhVien
                    join ct in dbContext.ChiTietDatXes
                    on x.MaDatXe equals ct.MaDatXe
                    select new YeuCauDTO
                    {
                        MaThanhVien = tv.MaThanhVien,
                        MaDatXe = x.MaDatXe,
                        TenHienThi = tv.TenHienThi,
                        HinhAnh = tv.HinhAnh,
                        ViTriBatDau = x.ViTriBatDau,
                        ViTriKetThuc = x.ViTriKetThuc,
                        TongThanhToan = ct.TongThanhToan
                    };
            return q.ToList();

        }

        //upload sửa ảnh xe
        [HttpPost]
        public HttpResponseMessage UploadSua()
        {
            try
            {
                var request = HttpContext.Current.Request;
                //var description = request.Form["description"];
                var photo = request.Files["photo"];
                photo.SaveAs(HttpContext.Current.Server.MapPath("~/Assets/images/xe/" + photo.FileName));
                //dbContext.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

        }

        //hiển thị chủ xe theo xe
        [HttpGet]
        public ThanhVien HienThiChuXe(int maThanhVien)
        {
            ThanhVien tv = dbContext.ThanhViens.FirstOrDefault(x => x.MaThanhVien == maThanhVien);

            return tv;
        }


        //upload thêm ảnh xe
        [HttpPost]
        public HttpResponseMessage UploadThem()
        {
            try
            {
                var request = HttpContext.Current.Request;
                //var description = request.Form["description"];
                var photo = request.Files["photo"];
                photo.SaveAs(HttpContext.Current.Server.MapPath("~/Assets/images/xe/" + photo.FileName));
                //dbContext.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

        }
    }
}
