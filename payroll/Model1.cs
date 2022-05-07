namespace payroll
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDegreee> EmployeeDegreees { get; set; }
        public virtual DbSet<SalaryLog> SalaryLogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SalaryLogs)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EmployeeDegreee>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EmployeeDegreee)
                .WillCascadeOnDelete();
        }
    }
}
