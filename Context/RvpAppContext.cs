using System;
using Microsoft.EntityFrameworkCore;
using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.ViewModels;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Context
{
    public partial class RvpAppContext : DbContext
    {
        public RvpAppContext()
        {
        }

        public RvpAppContext(DbContextOptions<RvpAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InterfaceErrorLogging> InterfaceErrorLogging { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleAssignment> VehicleAssignment { get; set; }
        public virtual DbSet<VehicleFunction> VehicleFunction { get; set; }
        public virtual DbSet<VehicleRequisition> VehicleRequisition { get; set; }
        public virtual DbSet<VwRowEmployees> VwRowEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:ardotdbsrv1.database.windows.net;Database=RowVehiclePool;User Id=HttpDevWeb;Password=Mh@Llifww@5;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InterfaceErrorLogging>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ErrorMessage).IsUnicode(false);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.TagNumber)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Make).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.OwnerBudget)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VehicleType).IsUnicode(false);
            });

            modelBuilder.Entity<VehicleAssignment>(entity =>
            {
                entity.HasKey(e => new { e.VehReqNo, e.AssignNo });

                entity.HasIndex(e => e.VehReqNo)
                    .HasName("IX_VehicleAssignment")
                    .IsUnique();

                entity.HasIndex(e => new { e.VehReqNo, e.AssignNo, e.Comments, e.AssignTagNo, e.AssignDepartDate, e.AssignReturnDate })
                    .HasName("NonClusteredIndex-20170815-094707");

                entity.Property(e => e.AssignTagNo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<VehicleFunction>(entity =>
            {
                entity.Property(e => e.Func)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FunctionDesc)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VehicleRequisition>(entity =>
            {
                entity.Property(e => e.VehReqNo).ValueGeneratedNever();

                entity.Property(e => e.Destination).IsUnicode(false);

                entity.Property(e => e.Duties).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.LastChangeUserid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NotificationDivHead).IsUnicode(false);

                entity.Property(e => e.NotificationMan).IsUnicode(false);

                entity.Property(e => e.ReqBudget)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqComments).IsUnicode(false);

                entity.Property(e => e.ReqDivision).IsUnicode(false);

                entity.Property(e => e.ReqFap)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqFunction)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqJobNo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqSectionId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Requestor).IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VehReqStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VehType).IsUnicode(false);
            });

            modelBuilder.Entity<VwRowEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ROW_Employees");

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_NUMBER")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameFirst)
                    .IsRequired()
                    .HasColumnName("NAME_FIRST")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameLast)
                    .IsRequired()
                    .HasColumnName("NAME_LAST")
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SectionDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SectionId)
                    .IsRequired()
                    .HasColumnName("SECTION_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });


        OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<RowVehiclePoolMVC.ViewModels.RequestDetailVM> RequestDetailVM { get; set; }

        public DbSet<RowVehiclePoolMVC.ViewModels.VehicleRequisitionVM> VehicleRequisitionVM { get; set; }
    }
}
