using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDangKyViec
{
    public partial class DatabaseDangKy : DbContext
    {
        public DatabaseDangKy()
            : base("name=DatabaseDangKy")
        {
        }

        public virtual DbSet<DANGKY> DANGKies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
