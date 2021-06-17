using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FindMeInSupermarket
{
    public partial class ProdukModel : DbContext
    {
        public ProdukModel()
            : base("name=ProdukModel")
        {
        }

        public virtual DbSet<Produk> Produks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
