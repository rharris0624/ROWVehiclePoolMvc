using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("ALLOT_MASTER")]
    public partial class AllotMaster
    {
        [Key]
        [Column("JOB_NUM")]
        [StringLength(6)]
        public string JobNum { get; set; }
        [Required]
        [Column("MIN_ORDER")]
        [StringLength(8)]
        public string MinOrder { get; set; }
        [Required]
        [Column("JOB_TYPE")]
        [StringLength(1)]
        public string JobType { get; set; }
        [Column("P_DATE_R", TypeName = "datetime")]
        public DateTime PDateR { get; set; }
        [Required]
        [Column("DIST")]
        [StringLength(2)]
        public string Dist { get; set; }
        [Required]
        [Column("SECT")]
        [StringLength(3)]
        public string Sect { get; set; }
        [Required]
        [Column("PE_JOBNUM")]
        [StringLength(6)]
        public string PeJobnum { get; set; }
        [Column("BEG_BAL", TypeName = "money")]
        public decimal BegBal { get; set; }
        [Column("TOT_BAL", TypeName = "money")]
        public decimal TotBal { get; set; }
        [Required]
        [Column("JOB_SYS")]
        [StringLength(12)]
        public string JobSys { get; set; }
        [Required]
        [Column("DEL_CODE")]
        [StringLength(1)]
        public string DelCode { get; set; }
        [Required]
        [Column("JOB_NAME")]
        [StringLength(50)]
        public string JobName { get; set; }
        [Required]
        [Column("FUND_INFO")]
        [StringLength(60)]
        public string FundInfo { get; set; }
        [Required]
        [Column("COMM_1")]
        [StringLength(60)]
        public string Comm1 { get; set; }
        [Required]
        [Column("COMM_2")]
        [StringLength(60)]
        public string Comm2 { get; set; }
        [Required]
        [Column("JOB_DESC")]
        [StringLength(28)]
        public string JobDesc { get; set; }
        [Required]
        [Column("ROUTE")]
        [StringLength(5)]
        public string Route { get; set; }
        [Required]
        [Column("CO_CODE_1")]
        [StringLength(2)]
        public string CoCode1 { get; set; }
        [Required]
        [Column("FAP_1")]
        [StringLength(11)]
        public string Fap1 { get; set; }
        [Required]
        [Column("CO_CODE_2")]
        [StringLength(2)]
        public string CoCode2 { get; set; }
        [Required]
        [Column("FAP_2")]
        [StringLength(11)]
        public string Fap2 { get; set; }
        [Required]
        [Column("CO_CODE_3")]
        [StringLength(2)]
        public string CoCode3 { get; set; }
        [Required]
        [Column("FAP_3")]
        [StringLength(11)]
        public string Fap3 { get; set; }
        [Required]
        [Column("CO_CODE_4")]
        [StringLength(2)]
        public string CoCode4 { get; set; }
        [Required]
        [Column("FAP_4")]
        [StringLength(11)]
        public string Fap4 { get; set; }
    }
}
