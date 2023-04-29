using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RowVehiclePoolMVC.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Context
{
    public partial class RvpAppSecurityContext : DbContext
    {
        public RvpAppSecurityContext()
        {
        }

        public RvpAppSecurityContext(DbContextOptions<RvpAppSecurityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SystemSec> SystemSec { get; set; }
        public virtual DbSet<Users> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=E290-APP-61;Initial Catalog=Security;Trusted_Connection=yes;MultipleActiveResultSets=true;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemSec>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.Userid, e.Budget, e.FunctionalArea });

                entity.Property(e => e.SystemId)
                    .HasColumnName("SYSTEM_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Budget)
                    .HasColumnName("BUDGET")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalArea)
                    .HasColumnName("FUNCTIONAL_AREA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefaultPanel)
                    .IsRequired()
                    .HasColumnName("DEFAULT_PANEL")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasColumnName("PRIORITY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReceiveMail)
                    .HasColumnName("RECEIVE_MAIL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate)
                    .HasColumnName("UPD_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK_Users");

                entity.ToTable("users");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Budget)
                    .IsRequired()
                    .HasColumnName("BUDGET")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_NUMBER")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate)
                    .HasColumnName("UPD_DATE")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
