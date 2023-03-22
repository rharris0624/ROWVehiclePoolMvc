using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("Worker_Table_Old_Load")]
    public partial class WorkerTableOldLoad
    {
        [Column("SSNNo ")]
        [StringLength(50)]
        public string Ssnno { get; set; }
        [Column("Employee_Number")]
        [StringLength(50)]
        public string EmployeeNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string BusinessUnitSortCode { get; set; }
        [Column("NAME_FIRST")]
        [StringLength(50)]
        public string NameFirst { get; set; }
        [Column("NAME_LAST")]
        [StringLength(50)]
        public string NameLast { get; set; }
        [Column("NAME_MIDDLE")]
        [StringLength(50)]
        public string NameMiddle { get; set; }
        [Column("SEX_CODE")]
        [StringLength(50)]
        public string SexCode { get; set; }
        [Column("Job_Code")]
        [StringLength(50)]
        public string JobCode { get; set; }
        [Column("JOB_TITLE")]
        [StringLength(50)]
        public string JobTitle { get; set; }
        [StringLength(60)]
        public string LaborLevelSetName { get; set; }
        [Column("DIV_DIST_DESC")]
        [StringLength(50)]
        public string DivDistDesc { get; set; }
        [StringLength(50)]
        public string LegalEmployerSeniorityDate { get; set; }
        [Column("ORIG_HIRE_DATE")]
        [StringLength(50)]
        public string OrigHireDate { get; set; }
        [Column("Termination_date")]
        [StringLength(50)]
        public string TerminationDate { get; set; }
        [Column("Rehire_date")]
        [StringLength(50)]
        public string RehireDate { get; set; }
        [StringLength(50)]
        public string ActionCode { get; set; }
        [Column("Supervisor Start Date")]
        [StringLength(50)]
        public string SupervisorStartDate { get; set; }
        [StringLength(50)]
        public string ManagerAssignmentNumber { get; set; }
        [StringLength(50)]
        public string ManagerFlag { get; set; }
        [Column("DATE_PRESENTJOB")]
        [StringLength(50)]
        public string DatePresentjob { get; set; }
        [Column("Bank Name")]
        [StringLength(50)]
        public string BankName { get; set; }
        [Column("BCity")]
        [StringLength(50)]
        public string Bcity { get; set; }
        [Column("BState")]
        [StringLength(50)]
        public string Bstate { get; set; }
        [Column("Bank Account Type ")]
        [StringLength(50)]
        public string BankAccountType { get; set; }
        [Column("Bank Account Name")]
        [StringLength(50)]
        public string BankAccountName { get; set; }
        [Column("BANKACCOUNTNUMBER")]
        [StringLength(50)]
        public string Bankaccountnumber { get; set; }
        [Column("Route No ")]
        [StringLength(50)]
        public string RouteNo { get; set; }
        [Column("Primary Bank account Flag")]
        [StringLength(50)]
        public string PrimaryBankAccountFlag { get; set; }
        [Column("Primary Bank account owner Flag")]
        [StringLength(50)]
        public string PrimaryBankAccountOwnerFlag { get; set; }
        [Column("BIRTH_DATE")]
        [StringLength(50)]
        public string BirthDate { get; set; }
        [Column("PERS_MARITAL")]
        [StringLength(50)]
        public string PersMarital { get; set; }
        [Column("FULLPARTTIME")]
        [StringLength(50)]
        public string Fullparttime { get; set; }
        [Column("PHONENUMBER")]
        [StringLength(50)]
        public string Phonenumber { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(50)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(50)]
        public string Addressline2 { get; set; }
        [Column("CITY")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("COUNTY")]
        [StringLength(50)]
        public string County { get; set; }
        [Column("STATE")]
        [StringLength(50)]
        public string State { get; set; }
        [Column("COUNTRY")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column("POSTALCODE")]
        [StringLength(50)]
        public string Postalcode { get; set; }
        [Column("FUND")]
        [StringLength(50)]
        public string Fund { get; set; }
        [Column("ACCOUNT")]
        [StringLength(50)]
        public string Account { get; set; }
        [Column("DEPARTMENT")]
        [StringLength(50)]
        public string Department { get; set; }
        [Column("FUNCTION")]
        [StringLength(50)]
        public string Function { get; set; }
        [Column("PROJECT")]
        [StringLength(50)]
        public string Project { get; set; }
        [Column("INTERFUND")]
        [StringLength(50)]
        public string Interfund { get; set; }
        [Column("FUTURE1")]
        [StringLength(50)]
        public string Future1 { get; set; }
        [Column("FUTURE2")]
        [StringLength(50)]
        public string Future2 { get; set; }
    }
}
