namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuXe")]
    public partial class ChuXe
    {
        [Key]
        public int MaChuXe { get; set; }

        [StringLength(255)]
        public string TenChuXe { get; set; }

        [StringLength(255)]
        public string SoDienThoai { get; set; }

        [StringLength(255)]
        public string TenXe { get; set; }

        public int? MaLoaiXe { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        public int? Status { get; set; }

        public virtual LoaiXe LoaiXe { get; set; }
    }
}
