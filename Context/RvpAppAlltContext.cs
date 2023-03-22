using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RowVehiclePoolMVC.Models;
using Microsoft.Extensions.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Context
{
    public partial class RvpAppAlltContext : DbContext
    {
        private IConfiguration Configuration { get; set; }
        public RvpAppAlltContext()
        {
        }

        public RvpAppAlltContext(DbContextOptions<RvpAppAlltContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<AllotDetail> AllotDetail { get; set; }
        public virtual DbSet<AllotMaster> AllotMaster { get; set; }
        public virtual DbSet<AllotTran> AllotTran { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=e290-app-61;Database=Allotments;Trusted_Connection=Yes;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllotDetail>(entity =>
            {
                entity.HasKey(e => new { e.JobNum, e.Func, e.FapNum });

                entity.Property(e => e.JobNum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Func)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FapNum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepFlag)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FuncType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrintFlag)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AllotMaster>(entity =>
            {
                entity.Property(e => e.JobNum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CoCode1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CoCode2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CoCode3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CoCode4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comm1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comm2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DelCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dist)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fap1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fap2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fap3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fap4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FundInfo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobDesc)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobSys)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MinOrder)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PeJobnum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Route)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sect)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AllotTran>(entity =>
            {
                entity.HasKey(e => new { e.TransDatetime, e.TransType });

                entity.Property(e => e.TransType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepFlag)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FapNum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Func)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FuncType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobNum)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrintFlag)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
