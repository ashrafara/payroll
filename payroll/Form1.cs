using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddDegree addDegree = new Main.AddDegree();
            addDegree.ShowDialog();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditDegree editDegree = new Edit.EditDegree();
            editDegree.ShowDialog();
        }

        private void اضافةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main.Addemployee addemployee = new Main.Addemployee();
            addemployee.ShowDialog();

        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit.Editemployee editemployee = new Edit.Editemployee();
            editemployee.ShowDialog();
        }

        private void صرفمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddSalary addSalary = new Main.AddSalary();
            addSalary.ShowDialog();
        }

        private void تعديلالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditSalary editSalary = new Edit.EditSalary();
            editSalary.ShowDialog();
        }

        private void المصارفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.bank_reports_view frm= new reports.bank_reports_view();
            frm.ShowDialog();
        }

        private void الجهادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.jihad_report_view frm = new reports.jihad_report_view();
            frm.ShowDialog();
        }

        private void المضمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.socail_report frm = new reports.socail_report();
            frm.ShowDialog();
        }

        private void التضامنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.solidarity_report_view frm = new reports.solidarity_report_view();
            frm.ShowDialog();
        }

        private void مساهمةجهةالعملوالخزانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.wandc_report_view frm = new reports.wandc_report_view();
            frm.ShowDialog();
        }

        private void استمارةالمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.payroll_report_view frm = new reports.payroll_report_view();
            frm.ShowDialog();
        }

        private void حافظةالمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.portfilo_report_view frm = new reports.portfilo_report_view();
            frm.ShowDialog();
        }

        private void شهادةمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.certificate_report_view frm = new reports.certificate_report_view();
            frm.ShowDialog();
        }

        private void الكشفالتحليليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.analyis_report_view frm = new reports.analyis_report_view();
            frm.ShowDialog();
        }

        private void تعديلالدرجةوالعلاوةالسنويةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AnnualBounsDate frm = new Main.AnnualBounsDate();
            frm.ShowDialog();
        }

        private void عرضكلالمرتباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.showSalaray frm = new Edit.showSalaray();
            frm.ShowDialog();
        }

        private void عرصالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void عرضكشفالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.ShowEmployee frm = new Edit.ShowEmployee();
            frm.ShowDialog();

        }

        private void بطاقةمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports.salarycard_viewcs frm = new reports.salarycard_viewcs();
            frm.ShowDialog();
        }

        private void العلاواتالسنويةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void الكشفالتحليليToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.Analysis db = new reportft.Analysis();
            db.ShowDialog();
        }

        private void المصارفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.bank_report db = new reportft.bank_report();
            db.ShowDialog();
        }

        private void اضافةمصرفوفرعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddBank db = new Main.AddBank();
            db.ShowDialog();
        }

        private void تعديلالمصرفوالفرعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditBank db = new Edit.EditBank();
            db.ShowDialog();
        }

        private void عرضالمصارفوالفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.ShowBank db = new Edit.ShowBank();
            db.ShowDialog();
        }

        private void المضمونToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.socail_report db = new reportft.socail_report();
            db.ShowDialog();
        }

        private void الجهادToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.jihad_report db = new reportft.jihad_report();
            db.ShowDialog();
        }

        private void التضامنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.solidarity_report db = new reportft.solidarity_report();
            db.ShowDialog();
        }

        private void مساهمةجهةالعملوالخزانةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.wand_report db = new reportft.wand_report();
            db.ShowDialog();
        }

        private void حافظةالمرتبToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.portifi_report db = new reportft.portifi_report();
            db.ShowDialog(); 
        }

        private void استمارةالمرتبToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportft.payroll_report db = new reportft.payroll_report();
            db.ShowDialog();
        }
    }
}
