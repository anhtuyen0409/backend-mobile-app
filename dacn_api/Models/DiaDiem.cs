namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaDiem")]
    public partial class DiaDiem
    {
        [Key]
        public int MaDiaDiem { get; set; }

        public string TenDiaDiem { get; set; }

        public string NoiDung { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }
    }
}
