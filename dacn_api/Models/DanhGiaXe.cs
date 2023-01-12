namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhGiaXe")]
    public partial class DanhGiaXe
    {
        [Key]
        public int MaDanhGia { get; set; }

        public int MaThanhVien { get; set; }

        public int? MaXe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDanhGia { get; set; }

        [StringLength(255)]
        public string NoiDung { get; set; }

        public double? Diem { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
