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
    public partial class payroll_report_view : Form
    {
        Model1 db = new Model1();

        public payroll_report_view()
        {
            InitializeComponent();

            var emplpy = (from c in db.Banks
                          select new
                          {
                              c.mainBank,
                              c.branchBank,
                              c.bankId
                          }).ToList();
            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "mainBank";
            comboBox1.ValueMember = "bankId";

            comboBox2.DataSource = emplpy.ToList();
            comboBox2.DisplayMember = "branchBank";
            comboBox2.ValueMember = "bankId";

        }

        private void payroll_report_view_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = comboBox1.SelectedItem;

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
                payroll_report rpt = new payroll_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("salaryMonth", textBox1.Text.ToString());
                rpt.SetParameterValue("salarayyear", textBox2.Text.ToString());
                rpt.SetParameterValue("bankId", comboBox1.SelectedValue);
                crystalReportViewer1.ReportSource = rpt;
            }

        }
    }
}
