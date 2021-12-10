using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace qlks.Models
{
    public partial class QLKSDbContext :DbContext
    {
        public QLKSDbContext() :base("name=QLKSDbContext")
            {
            }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<ThuePhong> ThuePhongs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        
    }
}