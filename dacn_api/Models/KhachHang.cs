namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        [StringLength(255)]
        public string TenKhachHang { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(255)]
        public string SDT { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? MaThanhVien { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
