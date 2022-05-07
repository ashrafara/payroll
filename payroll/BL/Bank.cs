namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bank")]
    public partial class Bank
    {
        public int bankId { get; set; }

        [StringLength(150)]
        public string mainBank { get; set; }

        [StringLength(150)]
        public string branchBank { get; set; }
    }
}
