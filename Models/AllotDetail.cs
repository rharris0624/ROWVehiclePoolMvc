using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("ALLOT_DETAIL")]
    public partial class AllotDetail
    {
        [Key]
        [Column("JOB_NUM")]
        [StringLength(6)]
        public string JobNum { get; set; }
        [Key]
        [Column("FUNC")]
        [StringLength(4)]
        public string Func { get; set; }
        [Key]
        [Column("FAP_NUM")]
        [StringLength(20)]
        public string FapNum { get; set; }
        [Required]
        [Column("FUNC_TYPE")]
        [StringLength(1)]
        public string FuncType { get; set; }
        [Column("ISSUE_DATER", TypeName = "datetime")]
        public DateTime IssueDater { get; set; }
        [Column("SYS_DATER", TypeName = "datetime")]
        public DateTime SysDater { get; set; }
        [Column("FED_PCT", TypeName = "numeric(5, 2)")]
        public decimal FedPct { get; set; }
        [Column("LAST_FED_AMT", TypeName = "money")]
        public decimal LastFedAmt { get; set; }
        [Column("CUR_FED_AMT", TypeName = "money")]
        public decimal CurFedAmt { get; set; }
        [Column("TOT_FED_AMT", TypeName = "money")]
        public decimal TotFedAmt { get; set; }
        [Column("ST_PCT", TypeName = "numeric(5, 2)")]
        public decimal StPct { get; set; }
        [Column("LAST_ST_AMT", TypeName = "money")]
        public decimal LastStAmt { get; set; }
        [Column("CUR_ST_AMT", TypeName = "money")]
        public decimal CurStAmt { get; set; }
        [Column("TOT_ST_AMT", TypeName = "money")]
        public decimal TotStAmt { get; set; }
        [Column("ST_AID_PCT", TypeName = "numeric(5, 2)")]
        public decimal StAidPct { get; set; }
        [Column("LAST_ST_AID_AMT", TypeName = "money")]
        public decimal LastStAidAmt { get; set; }
        [Column("CUR_ST_AID_AMT", TypeName = "money")]
        public decimal CurStAidAmt { get; set; }
        [Column("TOT_ST_AID_AMT", TypeName = "money")]
        public decimal TotStAidAmt { get; set; }
        [Column("OTHER_PCT", TypeName = "numeric(5, 2)")]
        public decimal OtherPct { get; set; }
        [Column("LAST_OTHER_AMT", TypeName = "money")]
        public decimal LastOtherAmt { get; set; }
        [Column("CUR_OTHER_AMT", TypeName = "money")]
        public decimal CurOtherAmt { get; set; }
        [Column("TOT_OTHER_AMT", TypeName = "money")]
        public decimal TotOtherAmt { get; set; }
        [Column("LAST_AMT", TypeName = "money")]
        public decimal LastAmt { get; set; }
        [Column("CUR_AMT", TypeName = "money")]
        public decimal CurAmt { get; set; }
        [Column("FUNC_TOTAL", TypeName = "money")]
        public decimal FuncTotal { get; set; }
        [Required]
        [Column("DEP_FLAG")]
        [StringLength(1)]
        public string DepFlag { get; set; }
        [Required]
        [Column("PRINT_FLAG")]
        [StringLength(1)]
        public string PrintFlag { get; set; }
    }
}
