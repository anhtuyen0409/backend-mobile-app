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
    public class DatXeController : ApiController
    {
        APIContext dbContext = new APIContext();
        [HttpGet]
        public bool DatXeTuLai(int maThanhVien, DateTime ngayDat, DateTime ngayKetThuc, string viTriXe, string viTriNhanXe, int maHinhThuc)
        {
            try
            {
                DatXe dx = new DatXe();
                dx.MaThanhVien = maThanhVien;
                dx.NgayDat = ngayDat;
                dx.NgayKetThuc = ngayKetThuc;
                dx.ViTriBatDau = viTriXe;
                dx.ViTriKetThuc = viTriNhanXe;
                dx.MaHinhThuc = maHinhThuc;
                dx.Status = 0;
                dbContext.DatXes.Add(dx);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }

        [HttpGet]
        public DatXe LayThongTinKhiDatXe(int maThanhVien, DateTime ngayDat, DateTime ngayKetThuc, string viTriXe, string viTriNhanXe)
        {
            try
            {
                DatXe dx = dbContext.DatXes.FirstOrDefault(n => n.MaThanhVien == maThanhVien && 
                n.NgayDat == ngayDat && n.NgayKetThuc == ngayKetThuc && n.ViTriBatDau == viTriXe &&
                n.ViTriKetThuc == viTriNhanXe);
                if (dx != null)
                {
                    return dx;
                }
            }
            catch
            {

            }
            return null;
        }

        [HttpGet]
        public bool ThemChiTietDatXe(int maDatXe, int maXe, int tongThanhToan)
        {
            try
            {
                Xe xe = dbContext.Xes.FirstOrDefault(x => x.MaXe == maXe);
                ChiTietDatXe ctdx = new ChiTietDatXe();
                if (dbContext.ChiTietDatXes.Count(x => x.MaDatXe == maDatXe && x.MaXe == maXe) > 0)
                {
                   return false;
                }
                else
                {
                    if(xe != null)
                    {
                        ctdx.MaXe = maXe;
                        ctdx.TongThanhToan = tongThanhToan;
                        ctdx.MaDatXe = maDatXe;
                        xe.Status = 1;
                        ctdx.Status = 0;
                        ctdx.DaThanhToan = 0;
                        dbContext.ChiTietDatXes.Add(ctdx);
                        dbContext.SaveChanges();
                        return true;
                    }
                    
                }
                
            }
            catch
            {

            }
            return false;
        }

        //sửa status xe = 0 khi chủ xe từ chối yêu cầu đặt xe
        [HttpGet]
        public bool TuChoiYeuCau(int maThanhVien)
        {
            try
            {
                Xe xe = dbContext.Xes.FirstOrDefault(x => x.MaThanhVien == maThanhVien && x.Status == 1);
                if (xe != null)
                {
                    xe.Status = 0;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        [HttpGet]
        public bool KetThucChuyen(int maXe)
        {
            try
            {
                Xe xe = dbContext.Xes.FirstOrDefault(x => x.MaXe == maXe && x.Status == 1);
                if (xe != null)
                {
                    xe.Status = 0;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        //sửa status datxe = 1 khi chủ xe chap nhan yêu cầu đặt xe
        [HttpGet]
        public bool ChapNhanYeuCau()
        {
            try
            {
                DatXe datXe = dbContext.DatXes.FirstOrDefault(x => x.Status == 0);
                ChiTietDatXe chiTietDatXe = dbContext.ChiTietDatXes.FirstOrDefault(x => x.Status == 0);
                if (datXe != null && chiTietDatXe != null)
                {
                    datXe.Status = 1;
                    chiTietDatXe.Status = 1;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        //hiển thị chuyến xe đang diễn ra phía khách hàng
        [HttpGet]
        public List<ChuyenXeDTO> HienThiChuyenXeDangDienRaCuaKhachHang(int maThanhVien)
        {
            var q = from dx in dbContext.DatXes
                     where dx.MaThanhVien == maThanhVien && dx.Status == 1 //khi chủ xe chấp nhận yc mới hiển thị
                     join ct in dbContext.ChiTietDatXes
                     on dx.MaDatXe equals ct.MaDatXe
                     join ht in dbContext.HinhThucThanhToans
                     on dx.MaHinhThuc equals ht.MaHinhThuc
                     select new ChuyenXeDTO
                     {
                         MaDatXe = dx.MaDatXe,
                         NgayDat = dx.NgayDat,
                         NgayKetThuc = dx.NgayKetThuc,
                         TongThanhToan = ct.TongThanhToan,
                         TenHinhThuc = ht.TenHinhThuc
                     };
            return q.ToList();

        }

        //xem lịch sử địch xe phía khách hàng

    }
}
