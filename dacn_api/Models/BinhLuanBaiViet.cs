namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuanBaiViet")]
    public partial class BinhLuanBaiViet
    {
        [Key]
        public int MaBinhLuanBaiViet { get; set; }

        public int? MaBaiViet { get; set; }

        public int? MaThanhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBinhLuan { get; set; }

        public string NoiDung { get; set; }

        public virtual BaiViet BaiViet { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
