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
    public partial class portifi_report : Form
    {
        public portifi_report()
        {
            Model1 db = new Model1();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || textBox3.Text.ToString() == "")
            {
                MessageBox.Show("يرجي تعبئة الخانات الفراغة");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=payroll;User ID=sa;Password=ali123");
                portifilo rpt = new portifilo();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox1.Text.ToString());
                rpt.SetParameterValue("month1", textBox2.Text.ToString());
                rpt.SetParameterValue("year", textBox3.Text.ToString());
                rpt.SetParameterValue("bankId", comboBox1.SelectedValue);
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox2.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = comboBox1.SelectedItem;
        }
    }
}
