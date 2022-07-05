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
    public partial class socialneg_report : Form
    {
        public socialneg_report()
        {
            InitializeComponent();
        }

        private void socialneg_report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || textBox3.Text.ToString() == "")
            {
                MessageBox.Show("يرجي تعبئة الخانات الفراغة");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                socailnegativity rpt = new socailnegativity();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox1.Text.ToString());
                rpt.SetParameterValue("month1", textBox2.Text.ToString());
                rpt.SetParameterValue("salarayyear", textBox3.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }
        }
    }
}
