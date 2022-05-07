using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine; 

namespace payroll.reports
{
    public partial class jihad_report_view : Form
    {
        Model1 db = new Model1();

        public jihad_report_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                jihad_report rpt = new jihad_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox2.Text.ToString());
                rpt.SetParameterValue("year", textBox1.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void jihad_report_view_Load(object sender, EventArgs e)
        {

        }
    }
}
