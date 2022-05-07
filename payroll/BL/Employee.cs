namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            SalaryLogs = new HashSet<SalaryLog>();
        }

        public int employeeId { get; set; }

        [StringLength(150)]
        public string employeeName { get; set; }

        [StringLength(50)]
        public string employeeNationalNo { get; set; }

        [StringLength(50)]
        public string employeeNationality { get; set; }

        [StringLength(50)]
        public string employeeInsuranceNo { get; set; }

        [StringLength(50)]
        public string employeeBankNumber { get; set; }

        [StringLength(150)]
        public string employeeDepartement { get; set; }

        [StringLength(150)]
        public string employeeDivision { get; set; }

        [Column(TypeName = "date")]
        public DateTime? employeeStartDate { get; set; }

        [StringLength(150)]
        public string employementName { get; set; }

        [StringLength(50)]
        public string employeeState { get; set; }

        public int? degreeId { get; set; }

        public int? bankId { get; set; }

        public int? emlpoyeeBouns { get; set; }

        [Column(TypeName = "date")]
        public DateTime? employeebounsDate { get; set; }

        [StringLength(50)]
        public string employeeSalary { get; set; }

        public virtual EmployeeDegreee EmployeeDegreee { get; set; }

        public virtual Bank Bank { get; set; }

        public int? employeeDegreeAssign { get; set; }

        public int? employeeBounsAssign { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryLog> SalaryLogs { get; set; }
    }
}
