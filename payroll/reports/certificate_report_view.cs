using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient; 


namespace payroll.reports
{
    public partial class certificate_report_view : Form
    {
        Model1 db = new Model1(); 

        public certificate_report_view()
        {
            InitializeComponent();

            var emplpy = (from c in db.Employees
                          select new
                          {
                              c.employeeName,
                              c.employeeId
                          }).ToList();
            comboBox2.DataSource = emplpy.ToList();
            comboBox2.DisplayMember = "employeeName";
            comboBox2.ValueMember = "employeeId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                certificate_report rpt = new certificate_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox1.Text.ToString());
                rpt.SetParameterValue("year", textBox2.Text.ToString());
                rpt.SetParameterValue("employeeId", comboBox2.SelectedValue);
                crystalReportViewer1.ReportSource = rpt;
            }
        }
        private void certificate_report_view_Load(object sender, EventArgs e)
        {

        }
    }
}
