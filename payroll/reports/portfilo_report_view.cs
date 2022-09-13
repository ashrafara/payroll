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
using CrystalDecisions.Shared;

namespace payroll.reports
{
    public partial class portfilo_report_view : Form
    {
        Model1 db = new Model1();

        public portfilo_report_view()
        {

            InitializeComponent();

            //var emplpy = (from c in db.Banks
            //              select new
            //              {
            //                  c.mainBank,
            //                  c.branchBank,
            //                  c.bankId
            //              }).ToList();
            //comboBox1.DataSource = emplpy.ToList();
            //comboBox1.DisplayMember = "mainBank";
            //comboBox1.ValueMember = "bankId";

            //comboBox2.DataSource = emplpy.ToList();
            //comboBox2.DisplayMember = "branchBank";
            //comboBox2.ValueMember = "bankId";

                        comboBox1.DataSource = db.Banks.GroupBy(x => new { x.mainBank })
                .Select( b => new 
                {
                    b.Key.mainBank,
                   
                }).ToList();


            comboBox1.DisplayMember = "mainBank";
            comboBox1.ValueMember = "mainBank";
            comboBox1.SelectedIndex = 0;
        }

        private void portfilo_report_view_Load(object sender, EventArgs e)
        {

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
                portifio_report rpt = new portifio_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
                rpt.SetParameterValue("month", textBox1.Text.ToString());
                rpt.SetParameterValue("year", textBox2.Text.ToString());
                rpt.SetParameterValue("bankId", comboBox2.SelectedValue);
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.SelectedItem = comboBox1.SelectedItem;
            try
            {
                var emplpy = (from c in db.Banks
                              where c.mainBank == (string)comboBox1.SelectedValue
                              select new
                              {
                                  c.mainBank,
                                  c.branchBank,
                                  c.bankId
                              }
                               ).ToList();
                comboBox2.DataSource = emplpy.ToList();
                comboBox2.DisplayMember = "branchBank";
                comboBox2.ValueMember = "bankId";
            }
            catch
            { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
