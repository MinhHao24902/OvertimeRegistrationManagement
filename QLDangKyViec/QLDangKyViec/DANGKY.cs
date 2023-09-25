namespace QLDangKyViec
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGKY")]
    public partial class DANGKY
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TUNGAY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DENNGAY { get; set; }

        [StringLength(10)]
        public string TUGIO { get; set; }

        [StringLength(10)]
        public string DENGIO { get; set; }

        [StringLength(100)]
        public string NGUOIDANGKY { get; set; }

        [StringLength(200)]
        public string LYDO { get; set; }
    }
}
