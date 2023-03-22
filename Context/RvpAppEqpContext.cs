using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using RowVehiclePoolMVC.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Context
{
    public partial class RvpAppEqpContext : DbContext
    {
        private IConfiguration Configuration { get; set; }
        public RvpAppEqpContext()
        {
        }

        public RvpAppEqpContext(DbContextOptions<RvpAppEqpContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<OrainfEquipmentTemp> OrainfEquipmentTemp { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Equipment_ConnectionString"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrainfEquipmentTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Budget).IsFixedLength();

                entity.Property(e => e.DriveHome).IsFixedLength();

                entity.Property(e => e.License).IsFixedLength();

                entity.Property(e => e.PreviousLicense).IsFixedLength();

                entity.Property(e => e.SerialCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vehmake).IsUnicode(false);

                entity.Property(e => e.Vehmodel).IsUnicode(false);

                entity.Property(e => e.Vehyear).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
