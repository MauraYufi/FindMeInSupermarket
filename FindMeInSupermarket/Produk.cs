namespace FindMeInSupermarket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TB_Produk")]
    public partial class Produk
    {
        [Key]
        [StringLength(20)]
        public string Kategori { get; set; }

        [StringLength(30)]
        public string Merk { get; set; }

        [StringLength(10)]
        public string Ukuran { get; set; }

        [StringLength(10)]
        public string Harga { get; set; }

        [StringLength(10)]
        public string Diskon { get; set; }

        [StringLength(10)]
        public string Lokasi { get; set; }
    }
}
