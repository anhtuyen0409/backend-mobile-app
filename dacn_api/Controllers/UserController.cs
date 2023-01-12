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
    public class UserController : ApiController
    {
        APIContext dbContext = new APIContext();
        

        //đăng ký thành viên
        [HttpGet]
        public bool DangKy(string tenHienThi, string email, string matKhau, string xacNhanMatKhau)
        {
            try
            {
                ThanhVien tv = new ThanhVien();
                
                if (dbContext.ThanhViens.Count(x => x.Email == email) > 0)
                {
                    return false;
                }
                else
                {
                    tv.Email = email;
                    tv.MatKhau = matKhau;
                    tv.TenHienThi = tenHienThi;
                    tv.XacNhanMatKhau = xacNhanMatKhau;
                    tv.HinhAnh = "user2.jpg";
                    tv.MaLoaiThanhVien = 2;
                    dbContext.ThanhViens.Add(tv);
                    
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;

        }

        //đăng ký thành chủ xe
        [HttpGet]
        public bool DangKyChuXe(string email, string matKhau, string xacNhanMatKhau, string tenHienThi, string hoTen, DateTime ngaySinh, string sdt)
        {
            try
            {
                ThanhVien tv = new ThanhVien();
                if (dbContext.ThanhViens.Count(x => x.Email == email) > 0)
                {
                    return false;
                }
                else
                {
                    tv.Email = email;
                    tv.MatKhau = matKhau;
                    tv.TenHienThi = tenHienThi;
                    tv.XacNhanMatKhau = xacNhanMatKhau;
                    tv.HoTen = hoTen;
                    tv.NgaySinh = ngaySinh;
                    tv.DienThoai = sdt;
                    tv.MaLoaiThanhVien = 3;
                    dbContext.ThanhViens.Add(tv);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;

        }

        //đăng ký tài xế
        [HttpGet]
        public bool DangKyTaiXe(string email, string matKhau, string xacNhanMatKhau, string tenHienThi, string hoTen, DateTime ngaySinh, string sdt)
        {
            try
            {
                ThanhVien tv = new ThanhVien();
                if (dbContext.ThanhViens.Count(x => x.Email == email) > 0)
                {
                    return false;
                }
                else
                {
                    tv.Email = email;
                    tv.MatKhau = matKhau;
                    tv.TenHienThi = tenHienThi;
                    tv.XacNhanMatKhau = xacNhanMatKhau;
                    tv.HoTen = hoTen;
                    tv.NgaySinh = ngaySinh;
                    tv.DienThoai = sdt;
                    tv.MaLoaiThanhVien = 7;
                    dbContext.ThanhViens.Add(tv);
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
        public string DangNhap(string email, string matKhau)
        {
            try
            {
                ThanhVien tv = dbContext.ThanhViens.FirstOrDefault(n => n.Email == email && n.MatKhau == matKhau);
                if (tv != null)
                {
                    if (tv.LoaiThanhVien.MaLoaiThanhVien == 1)
                    {
                        return "admin";
                    }
                    else if (tv.LoaiThanhVien.MaLoaiThanhVien == 2)
                    {
                        return "khachhang";
                    }
                    else if (tv.LoaiThanhVien.MaLoaiThanhVien == 3)
                    {
                        return "chuxe";
                    }
                    else if (tv.LoaiThanhVien.MaLoaiThanhVien == 4)
                    {
                        return "taixe";
                    }
                   
                }
            }
            catch
            {

            }
            return null;
        }

        [HttpGet]
        public ThanhVien LayUserKhiDangNhap(string email, string matKhau)
        {
            try
            {
                ThanhVien tv = dbContext.ThanhViens.FirstOrDefault(n => n.Email == email && n.MatKhau == matKhau);
                if (tv != null)
                {
                    return tv;
                }
            }
            catch
            {

            }
            return null;
        }

        //sửa thông tin cá nhân
        [HttpGet]
        public bool SuaThongTinCaNhan(int maThanhVien, string hoTen, string tenHienThi, string sdt, DateTime ngaySinh, string hinhAnh)
        {
            try
            {
                ThanhVien tv = dbContext.ThanhViens.FirstOrDefault(x => x.MaThanhVien == maThanhVien);
                if (tv != null)
                {
                    tv.HoTen = hoTen;
                    tv.TenHienThi = tenHienThi;
                    tv.DienThoai = sdt;
                    tv.NgaySinh = ngaySinh;
                    tv.HinhAnh = hinhAnh;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;

        }

        //upload ảnh đại diện
        [HttpPost]
        public HttpResponseMessage Upload()
        {
            try
            {
                var request = HttpContext.Current.Request;
                //var description = request.Form["description"];
                var photo = request.Files["photo"];
                photo.SaveAs(HttpContext.Current.Server.MapPath("~/Assets/images/user/" + photo.FileName));
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
