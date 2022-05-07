using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace payroll.reports
{
    public partial class bank_reports_view : Form
    {
        Model1 db = new Model1();

        public DbSqlQuery<SalaryLog> data { get; private set; }

        public bank_reports_view( )
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="" || textBox1.Text=="")
            {
                MessageBox.Show("الرجاء تعبئة الفارغات");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                bank_report rpt = new bank_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox2.Text.ToString());
                rpt.SetParameterValue("year", textBox1.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void bank_reports_Load(object sender, EventArgs e)
        {



        }
    }

    internal class EnrollmentDateGroup
    {
    }
}
