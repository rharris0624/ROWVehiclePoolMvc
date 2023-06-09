﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RowVehiclePoolMVC.Context;

namespace RowVehiclePoolMVC.Migrations
{
    [DbContext(typeof(RvpAppContext))]
    [Migration("20221215174012_IdentityAdded")]
    partial class IdentityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RowVehiclePoolMVC.Models.InterfaceErrorLogging", b =>
                {
                    b.Property<int>("ErrorCode")
                        .HasColumnName("Error Code")
                        .HasColumnType("int");

                    b.Property<string>("ErrorMessage")
                        .HasColumnName("Error Message")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.ToTable("InterfaceErrorLogging");
                });

            modelBuilder.Entity("RowVehiclePoolMVC.Models.Vehicle", b =>
                {
                    b.Property<string>("TagNumber")
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("Mileage")
                        .HasColumnType("numeric(6, 0)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime?>("OutOfServiceBegin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("OutOfServiceEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("OwnerBudget")
                        .IsRequired()
                        .HasColumnType("char(3)")
                        .IsFixedLength(true)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal>("VehYear")
                        .HasColumnType("numeric(4, 0)");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("TagNumber");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("RowVehiclePoolMVC.Models.VehicleAssignment", b =>
                {
                    b.Property<int>("VehReqNo")
                        .HasColumnType("int");

                    b.Property<decimal>("AssignNo")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<DateTime>("AssignDepartDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("AssignReturnDate")
                        .HasColumnType("datetime");

                    b.Property<string>("AssignTagNo")
                        .IsRequired()
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("VehReqNo", "AssignNo");

                    b.HasIndex("VehReqNo")
                        .IsUnique()
                        .HasName("IX_VehicleAssignment");

                    b.HasIndex("VehReqNo", "AssignNo", "Comments", "AssignTagNo", "AssignDepartDate", "AssignReturnDate")
                        .HasName("NonClusteredIndex-20170815-094707");

                    b.ToTable("VehicleAssignment");
                });

            modelBuilder.Entity("RowVehiclePoolMVC.Models.VehicleFunction", b =>
                {
                    b.Property<string>("Func")
                        .HasColumnName("FUNC")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("FunctionDesc")
                        .HasColumnName("FUNCTION_DESC")
                        .HasColumnType("char(20)")
                        .IsFixedLength(true)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Func");

                    b.ToTable("VehicleFunction");
                });

            modelBuilder.Entity("RowVehiclePoolMVC.Models.VehicleRequisition", b =>
                {
                    b.Property<int>("VehReqNo")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Duties")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastChangeUserid")
                        .IsRequired()
                        .HasColumnType("char(7)")
                        .IsFixedLength(true)
                        .HasMaxLength(7)
                        .IsUnicode(false);

                    b.Property<decimal>("NoInParty")
                        .HasColumnType("decimal(2, 0)");

                    b.Property<string>("NotificationDivHead")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NotificationMan")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ReqBudget")
                        .IsRequired()
                        .HasColumnType("char(3)")
                        .IsFixedLength(true)
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("ReqComments")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("ReqDepartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ReqDivision")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ReqFap")
                        .IsRequired()
                        .HasColumnName("ReqFAP")
                        .HasColumnType("char(11)")
                        .IsFixedLength(true)
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.Property<string>("ReqFunction")
                        .IsRequired()
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("ReqJobNo")
                        .IsRequired()
                        .HasColumnType("char(6)")
                        .IsFixedLength(true)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<DateTime>("ReqReturnDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ReqSectionId")
                        .IsRequired()
                        .HasColumnName("ReqSectionID")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Requestor")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Userid")
                        .IsRequired()
                        .HasColumnType("char(8)")
                        .IsFixedLength(true)
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<DateTime>("VehReqDate")
                        .HasColumnType("datetime");

                    b.Property<string>("VehReqStatus")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("VehType")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("VehReqNo");

                    b.ToTable("VehicleRequisition");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
