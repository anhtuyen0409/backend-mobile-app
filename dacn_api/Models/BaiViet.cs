namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiViet()
        {
            BinhLuanBaiViets = new HashSet<BinhLuanBaiViet>();
        }

        [Key]
        public int MaBaiViet { get; set; }

        public string TieuDeChinh { get; set; }

        public string NoiDungChinh { get; set; }

        public string TieuDe1 { get; set; }

        public string NoiDung1 { get; set; }

        public string TieuDe2 { get; set; }

        public string NoiDung2 { get; set; }

        public string TieuDe3 { get; set; }

        public string NoiDung3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        public int? SoLuotXem { get; set; }

        public int? SoLuotThich { get; set; }

        public int? MaThanhVien { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        public int? MaChuDe { get; set; }

        public int? Status { get; set; }

        public virtual ChuDe ChuDe { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuanBaiViet> BinhLuanBaiViets { get; set; }
    }
}
