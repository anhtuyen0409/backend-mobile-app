namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiXe")]
    public partial class TaiXe
    {
        [Key]
        public int MaTaiXe { get; set; }

        [StringLength(255)]
        public string TenTaiXe { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(255)]
        public string HinhAnhTaiXe { get; set; }

        [StringLength(255)]
        public string KinhNghiem { get; set; }

        [StringLength(255)]
        public string BangLai { get; set; }

        public int? Status { get; set; }
    }
}
