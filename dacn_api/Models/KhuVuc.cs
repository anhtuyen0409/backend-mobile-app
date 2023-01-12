namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuVuc")]
    public partial class KhuVuc
    {
        [Key]
        public int MaKhuVuc { get; set; }

        [StringLength(255)]
        public string TenKhuVuc { get; set; }
    }
}
