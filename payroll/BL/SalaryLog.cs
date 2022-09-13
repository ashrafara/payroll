namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryLog")]
    public partial class SalaryLog
    {
        public int salaryLogID { get; set; }

        public int? employeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ? salaryDate { get; set; }

        [StringLength(50)]
        public string salarayyear { get; set; }

        [StringLength(50)]
        public string salaryMonth { get; set; }

        public double? jihadTax { get; set; }

        public double? socialSecutiyTax { get; set; }

        public double? solidarityTax { get; set; }

        public double? allowanceDelay { get; set; }

        public double? totalTax { get; set; }

        public double? allowanceSecondment { get; set; }

        public double? basicSalary { get; set; }

        public double? totalSalary { get; set; }

        public double? TotalSalaryNet { get; set; }

        public double? salaryWorkContribution { get; set; }

        public double? salaryTreasurContribution { get; set; }

        public double? salaryTotalContribution { get; set; }

        public int? salaryAbsentDay { get; set; }

        public double? committeeAmount { get; set; }

        public double? TotalAllowanace { get; set; }

        public double? absentamount { get; set; }

        [StringLength(250)]
        public string salaryletter { get; set; }

        public double? addextratime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
