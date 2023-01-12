namespace dacn_api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatXe")]
    public partial class DatXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatXe()
        {
            ChiTietDatXes = new HashSet<ChiTietDatXe>();
        }

        [Key]
        public int MaDatXe { get; set; }

        public DateTime? NgayDat { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int? MaHinhThuc { get; set; }

        public int? MaThanhVien { get; set; }

        [StringLength(255)]
        public string ViTriBatDau { get; set; }

        [StringLength(255)]
        public string ViTriKetThuc { get; set; }

        [StringLength(255)]
        public string HoTen { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatXe> ChiTietDatXes { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
