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
    public partial class salarycard_viewcs : Form
    {
        Model1 db = new Model1();
        public salarycard_viewcs()
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

        private void salarycard_viewcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                Salarycards rpt = new Salarycards();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("employeeId", comboBox2.SelectedValue);
                rpt.SetParameterValue("salarayyear", textBox2.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }

        }
    }
}
