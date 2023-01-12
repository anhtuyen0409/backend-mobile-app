namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [Key]
        public int MaPhanQuyen { get; set; }

        public int? MaLoaiThanhVien { get; set; }

        [StringLength(255)]
        public string MaQuyen { get; set; }

        public string GhiChu { get; set; }

        public virtual LoaiThanhVien LoaiThanhVien { get; set; }

        public virtual Quyen Quyen { get; set; }
    }
}
