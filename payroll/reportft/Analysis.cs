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

namespace payroll.reportft
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            if (textBox1.Text.ToString()== "" || textBox2.Text.ToString() =="" || textBox3.Text.ToString()== "")
            {
                MessageBox.Show("يرجي تعبئة الخانات الفراغة");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                CrystalReport1 rpt = new CrystalReport1();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox1.Text.ToString());
                rpt.SetParameterValue("month1", textBox2.Text.ToString());
                rpt.SetParameterValue("year", textBox3.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
