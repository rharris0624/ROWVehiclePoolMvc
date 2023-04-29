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
    public partial class RvpAppBudContext : DbContext
    {
        private IConfiguration Configuration { get; set; }
        public RvpAppBudContext()
        {
        }
        public RvpAppBudContext(DbContextOptions<RvpAppBudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PahrMstr> PahrMstr { get; set; }
        public virtual DbSet<T101BudgetInf> T101BudgetInf { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=tcp:ardotdbsrv1.database.windows.net;Database=PAHR;User Id=HttpDevWeb;Password=Mh@Llifww@5;MultipleActiveResultSets=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PahrMstr>(entity =>
            {
                entity.HasKey(e => e.Ssno);

                entity.ToTable("PAHR_MSTR");

                entity.HasIndex(e => new { e.EmployeeNumber, e.EmployeeStatus })
                    .HasName("NonClusteredIndex-20170808-091313");

                entity.Property(e => e.Ssno)
                    .HasColumnName("SSNO")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccumedMerit)
                    .HasColumnName("ACCUMED_MERIT")
                    .HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AhpBasePay)
                    .HasColumnName("AHP_BASE_PAY")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.AhpCertAmount)
                    .HasColumnName("AHP_CERT_AMOUNT")
                    .HasColumnType("numeric(7, 2)");

                entity.Property(e => e.AhpCertDate)
                    .IsRequired()
                    .HasColumnName("AHP_CERT_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AhtdServicedt)
                    .IsRequired()
                    .HasColumnName("AHTD_SERVICEDT")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AltAddress)
                    .IsRequired()
                    .HasColumnName("ALT_ADDRESS")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AltCity)
                    .IsRequired()
                    .HasColumnName("ALT_CITY")
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AltState)
                    .IsRequired()
                    .HasColumnName("ALT_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AltZip1)
                    .IsRequired()
                    .HasColumnName("ALT_ZIP_1")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AltZip2)
                    .IsRequired()
                    .HasColumnName("ALT_ZIP_2")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnnualSalary)
                    .HasColumnName("ANNUAL_SALARY")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.BiWklySalary)
                    .HasColumnName("BI_WKLY_SALARY")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasColumnName("BIRTH_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Budget)
                    .IsRequired()
                    .HasColumnName("BUDGET")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Citizenship)
                    .IsRequired()
                    .HasColumnName("CITIZENSHIP")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrewNo)
                    .IsRequired()
                    .HasColumnName("CREW_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuremployDate)
                    .IsRequired()
                    .HasColumnName("CUREMPLOY_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateInGrade)
                    .IsRequired()
                    .HasColumnName("DATE_IN_GRADE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatePresentjob)
                    .IsRequired()
                    .HasColumnName("DATE_PRESENTJOB")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateTsalChg)
                    .IsRequired()
                    .HasColumnName("DATE_TSAL_CHG")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeathDate)
                    .IsRequired()
                    .HasColumnName("DEATH_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DischargeDate)
                    .IsRequired()
                    .HasColumnName("DISCHARGE_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DivDistInd)
                    .IsRequired()
                    .HasColumnName("DIV_DIST_IND")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DlExpDate)
                    .IsRequired()
                    .HasColumnName("DL_EXP_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DlNumber)
                    .IsRequired()
                    .HasColumnName("DL_NUMBER")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DlState)
                    .IsRequired()
                    .HasColumnName("DL_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EeoRemovaldate)
                    .IsRequired()
                    .HasColumnName("EEO_REMOVALDATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EicIndicator)
                    .IsRequired()
                    .HasColumnName("EIC_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerAddr)
                    .IsRequired()
                    .HasColumnName("EMER_ADDR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerCity)
                    .IsRequired()
                    .HasColumnName("EMER_CITY")
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerHomePhone)
                    .IsRequired()
                    .HasColumnName("EMER_HOME_PHONE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerName)
                    .IsRequired()
                    .HasColumnName("EMER_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerRelation)
                    .IsRequired()
                    .HasColumnName("EMER_RELATION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerState)
                    .IsRequired()
                    .HasColumnName("EMER_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerWorkPhone)
                    .IsRequired()
                    .HasColumnName("EMER_WORK_PHONE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmerZip)
                    .IsRequired()
                    .HasColumnName("EMER_ZIP")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpDeleteFlag)
                    .IsRequired()
                    .HasColumnName("EMP_DELETE_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_NUMBER")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeStatus)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_STATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EngNo)
                    .IsRequired()
                    .HasColumnName("ENG_NO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FedAmount)
                    .HasColumnName("FED_AMOUNT")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.FedExemp)
                    .HasColumnName("FED_EXEMP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FedMarital)
                    .IsRequired()
                    .HasColumnName("FED_MARITAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FedtaxMethod)
                    .IsRequired()
                    .HasColumnName("FEDTAX_METHOD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FicaIndicator)
                    .IsRequired()
                    .HasColumnName("FICA_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Filler)
                    .IsRequired()
                    .HasColumnName("FILLER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullPartCd)
                    .IsRequired()
                    .HasColumnName("FULL_PART_CD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullPartDate)
                    .IsRequired()
                    .HasColumnName("FULL_PART_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasColumnName("GRADE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeFunction)
                    .IsRequired()
                    .HasColumnName("HOME_FUNCTION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomephAreacd)
                    .IsRequired()
                    .HasColumnName("HOMEPH_AREACD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomephNum)
                    .IsRequired()
                    .HasColumnName("HOMEPH_NUM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomephPrefix)
                    .IsRequired()
                    .HasColumnName("HOMEPH_PREFIX")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HourlyRate)
                    .HasColumnName("HOURLY_RATE")
                    .HasColumnType("numeric(9, 6)");

                entity.Property(e => e.InsurancePretaxed)
                    .HasColumnName("INSURANCE_PRETAXED")
                    .HasMaxLength(1)
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

                entity.Property(e => e.LastFourSsno)
                    .HasColumnName("LAST_FOUR_SSNO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastTaxChange)
                    .IsRequired()
                    .HasColumnName("LAST_TAX_CHANGE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LicEndorsemt)
                    .IsRequired()
                    .HasColumnName("LIC_ENDORSEMT")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LicenseType)
                    .IsRequired()
                    .HasColumnName("LICENSE_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MeritFiscalytd)
                    .HasColumnName("MERIT_FISCALYTD")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.MeritLastChg)
                    .IsRequired()
                    .HasColumnName("MERIT_LAST_CHG")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MilEndRank)
                    .IsRequired()
                    .HasColumnName("MIL_END_RANK")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MilitaryBranch)
                    .IsRequired()
                    .HasColumnName("MILITARY_BRANCH")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MilitaryStatus)
                    .IsRequired()
                    .HasColumnName("MILITARY_STATUS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MultiPositnbr)
                    .IsRequired()
                    .HasColumnName("MULTI_POSITNBR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameAka)
                    .IsRequired()
                    .HasColumnName("NAME_AKA")
                    .HasMaxLength(25)
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

                entity.Property(e => e.NameMiddle)
                    .IsRequired()
                    .HasColumnName("NAME_MIDDLE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OccupCategory)
                    .IsRequired()
                    .HasColumnName("OCCUP_CATEGORY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OffStep)
                    .IsRequired()
                    .HasColumnName("OFF_STEP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrgCode)
                    .IsRequired()
                    .HasColumnName("ORG_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrigHireDate)
                    .IsRequired()
                    .HasColumnName("ORIG_HIRE_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OvertimeStatus)
                    .IsRequired()
                    .HasColumnName("OVERTIME_STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PersMarital)
                    .IsRequired()
                    .HasColumnName("PERS_MARITAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrAhtdDays)
                    .IsRequired()
                    .HasColumnName("PR_AHTD_DAYS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrAhtdMon)
                    .IsRequired()
                    .HasColumnName("PR_AHTD_MON")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrAhtdYrs)
                    .IsRequired()
                    .HasColumnName("PR_AHTD_YRS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrOthMon)
                    .IsRequired()
                    .HasColumnName("PR_OTH_MON")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrOthServdays)
                    .IsRequired()
                    .HasColumnName("PR_OTH_SERVDAYS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrOthYrs)
                    .IsRequired()
                    .HasColumnName("PR_OTH_YRS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RaceCode)
                    .IsRequired()
                    .HasColumnName("RACE_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReasonTsalCh)
                    .IsRequired()
                    .HasColumnName("REASON_TSAL_CH")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RehireConsider)
                    .IsRequired()
                    .HasColumnName("REHIRE_CONSIDER")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResidCounty)
                    .IsRequired()
                    .HasColumnName("RESID_COUNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RetirementDate)
                    .IsRequired()
                    .HasColumnName("RETIREMENT_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SectionId)
                    .IsRequired()
                    .HasColumnName("SECTION_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SexCode)
                    .IsRequired()
                    .HasColumnName("SEX_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShopMechFlag)
                    .IsRequired()
                    .HasColumnName("SHOP_MECH_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpouseBirthday)
                    .IsRequired()
                    .HasColumnName("SPOUSE_BIRTHDAY")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpouseName)
                    .IsRequired()
                    .HasColumnName("SPOUSE_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpouseSex)
                    .IsRequired()
                    .HasColumnName("SPOUSE_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpouseSsno)
                    .IsRequired()
                    .HasColumnName("SPOUSE_SSNO")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateAmount)
                    .HasColumnName("STATE_AMOUNT")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.StateExemp)
                    .HasColumnName("STATE_EXEMP")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.StateMarital)
                    .IsRequired()
                    .HasColumnName("STATE_MARITAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatetaxMethod)
                    .IsRequired()
                    .HasColumnName("STATETAX_METHOD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Step)
                    .IsRequired()
                    .HasColumnName("STEP")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervryClass)
                    .IsRequired()
                    .HasColumnName("SUPERVRY_CLASS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TermDate)
                    .IsRequired()
                    .HasColumnName("TERM_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TermReasonCd)
                    .IsRequired()
                    .HasColumnName("TERM_REASON_CD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TexarkInd)
                    .IsRequired()
                    .HasColumnName("TEXARK_IND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TypeDischarge)
                    .IsRequired()
                    .HasColumnName("TYPE_DISCHARGE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkCounty)
                    .IsRequired()
                    .HasColumnName("WORK_COUNTY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkExtension)
                    .IsRequired()
                    .HasColumnName("WORK_EXTENSION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkphAreacd)
                    .IsRequired()
                    .HasColumnName("WORKPH_AREACD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkphNum)
                    .IsRequired()
                    .HasColumnName("WORKPH_NUM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkphPrefix)
                    .IsRequired()
                    .HasColumnName("WORKPH_PREFIX")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zip1)
                    .IsRequired()
                    .HasColumnName("ZIP_1")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zip2)
                    .IsRequired()
                    .HasColumnName("ZIP_2")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<T101BudgetInf>(entity =>
            {
                entity.HasKey(e => e.T101BudgetInfPrimaryKey);

                entity.ToTable("T101_BUDGET_INF");

                entity.Property(e => e.T101BudgetInfPrimaryKey)
                    .HasColumnName("T101_BUDGET_INF_PRIMARY_KEY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Budget)
                    .IsRequired()
                    .HasColumnName("BUDGET")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BudgetDesc)
                    .IsRequired()
                    .HasColumnName("BUDGET_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompBudget)
                    .IsRequired()
                    .HasColumnName("COMP_BUDGET")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdDate)
                    .HasColumnName("LAST_UPD_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.LastUpdTermid)
                    .IsRequired()
                    .HasColumnName("LAST_UPD_TERMID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdTime)
                    .HasColumnName("LAST_UPD_TIME")
                    .HasColumnType("time(0)");

                entity.Property(e => e.LastUpdUserid)
                    .IsRequired()
                    .HasColumnName("LAST_UPD_USERID")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MthEndDate)
                    .HasColumnName("MTH_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MthStartDate)
                    .HasColumnName("MTH_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PahrBudget)
                    .IsRequired()
                    .HasColumnName("PAHR_BUDGET")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrEndDate)
                    .HasColumnName("PAYR_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PayrStartDate)
                    .HasColumnName("PAYR_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TimerBudget)
                    .IsRequired()
                    .HasColumnName("TIMER_BUDGET")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
