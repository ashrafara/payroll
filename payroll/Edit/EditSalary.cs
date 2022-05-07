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

namespace payroll.Edit
{
    public partial class EditSalary : Form
    {
        Model1 db = new Model1();

        public EditSalary()
        {
            InitializeComponent();

            var emplpy = (from c in db.Employees
                          join s in db.EmployeeDegreees on c.degreeId equals s.degreeId
                          select new
                          {
                              c.employeeName,
                              c.EmployeeDegreee.degreeNumber,
                              c.emlpoyeeBouns,
                              c.employeeState,
                              s.bounsNumber,
                              s.degreeAmount,
                              s.degreeId,
                              c.employeeId
                          }).ToList();
            cbemployeeId.DataSource = emplpy.ToList();
            cbemployeeId.DisplayMember = "employeeName";
            cbemployeeId.ValueMember = "employeeId";

            cbBouns.DataSource = emplpy.ToList();
            cbBouns.DisplayMember = "emlpoyeeBouns";
            cbBouns.ValueMember = "employeeId";

            cbdegree.DataSource = emplpy.ToList();
            cbdegree.DisplayMember = "degreeNumber";
            cbdegree.ValueMember = "employeeId";

            cbemploymentType.DataSource = emplpy.ToList();
            cbemploymentType.DisplayMember = "employeeState";
            cbemploymentType.ValueMember = "employeeId";

            cbannualBounsId.DataSource = emplpy.ToList();
            cbannualBounsId.DisplayMember = "bounsNumber";
            cbannualBounsId.ValueMember = "degreeId";


            cbdegreeamount.DataSource = emplpy.ToList();
            cbdegreeamount.DisplayMember = "degreeAmount";
            cbdegreeamount.ValueMember = "degreeId";

            var deg = from p in db.SalaryLogs
                      orderby p.salaryLogID ascending
                      select new
                      {
                          salaryLog_ID = p.salaryLogID,
                          employeeId = p.Employee.employeeName,
                          salaray_year = p.salarayyear == null ? "" : p.salarayyear,
                          salary_Month = p.salaryMonth == null ? "" : p.salaryMonth,
                          basic_Salary = p.basicSalary == null ? 0 : p.basicSalary,
                          allowance_Delay = p.allowanceDelay == null ? 0 : p.allowanceDelay,
                          allowance_Secondment = p.allowanceSecondment == null ? 0 : p.allowanceSecondment,
                          committee_Amount = p.committeeAmount == null ? 0 : p.committeeAmount,
                          total_Salary = p.totalSalary == null ? 0 : p.totalSalary,
                          jihad_Tax = p.jihadTax == null ? 0 : p.jihadTax,
                          socialSecutiy_Tax = p.socialSecutiyTax == null ? 0 : p.socialSecutiyTax,
                          solidarity_Tax = p.solidarityTax == null ? 0 : p.solidarityTax,
                          salary_WorkContribution = p.salaryWorkContribution == null ? 0 : p.salaryWorkContribution,
                          salary_TreasurContribution = p.salaryTreasurContribution == null ? 0 : p.salaryTreasurContribution,
                          salary_TotalContribution = p.salaryTotalContribution == null ? 0 : p.salaryTotalContribution,
                          Total_SalaryNet = p.TotalSalaryNet == null ? 0 : p.TotalSalaryNet,
                          totalTax = p.totalTax == null ? 0 : p.totalTax,
                          Total_Allowanace = p.TotalAllowanace == null ? 0 : p.TotalAllowanace,
                          salary_Date = p.salaryDate ,
                          salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay,
                          salary_letter = p.salaryletter == null ?"" : p.salaryletter,
                          absentamount = p.absentamount == null ? 0 : p.absentamount
                      };
            dataGridView1.DataSource = deg.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1.Columns[2].HeaderText = " السنة";
            dataGridView1.Columns[3].HeaderText = "الشهر";
            dataGridView1.Columns[4].HeaderText = " المرتب الاساسي";
            dataGridView1.Columns[5].HeaderText = "فروقات متاخرة";
            dataGridView1.Columns[6].HeaderText = "علاوة ندب";
            dataGridView1.Columns[7].HeaderText = "مكافاة اللجان";
            dataGridView1.Columns[8].HeaderText = "اجمالي المرتب";
            dataGridView1.Columns[9].HeaderText = "ضريبة الجهاد";
            dataGridView1.Columns[10].HeaderText = "المضمون";
            dataGridView1.Columns[11].HeaderText = "ضريبة التضامن";
            dataGridView1.Columns[12].HeaderText = "مساهمة جهة العمل";
            dataGridView1.Columns[13].HeaderText = "مساهمة الخزانة";
            dataGridView1.Columns[14].HeaderText = "مجموع المساهمات";
            dataGridView1.Columns[15].HeaderText = "صافي المرتب";
            dataGridView1.Columns[16].HeaderText = "مجموع الضرائب";
            dataGridView1.Columns[17].HeaderText = "مجموع العلاوات";
            dataGridView1.Columns[18].HeaderText = "مجموع العلاوات";
            dataGridView1.Columns[19].HeaderText = "تاريخ الغياب";
            dataGridView1.Columns[20].HeaderText = "تاريخ الغياب";
            dataGridView1.Columns[21].HeaderText = "خصم الغياب";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var delete = (from emp in db.SalaryLogs
                                where emp.salaryLogID == id
                                select emp).Single();
            db.SalaryLogs.Remove(delete);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void EditSalary_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic empId = cbemployeeId.SelectedValue;
            dynamic boundId = cbBouns.SelectedValue;
            dynamic degreeId = cbdegree.SelectedValue;
            dynamic empType = cbemploymentType.SelectedValue;
            dynamic bounsAmount = cbannualBounsId.SelectedValue;
            dynamic degreeAmount = cbdegreeamount.SelectedValue;


            var salary = new SalaryLog
            {
                salaryLogID=int.Parse(textBox1.Text),
                employeeId = empId,
                salarayyear = txtyear.Text,
                salaryMonth = txtrmonth.Text,
                jihadTax = double.Parse(txtJihadTax.Text),
                socialSecutiyTax = double.Parse(txtSocialSecurityTax.Text),
                solidarityTax = double.Parse(txtsolidarityTax.Text),
                allowanceDelay = string.IsNullOrEmpty(txtallowanceDelay.Text) ? (double?)0 : double.Parse(txtallowanceDelay.Text),
                allowanceSecondment = double.Parse(txtallowanceSecondment.Text),
                basicSalary = double.Parse(txtBasicSalary.Text),
                totalSalary = double.Parse(txtTotalSalary.Text),
                TotalSalaryNet = double.Parse(txtNetSalary.Text),
                salaryWorkContribution = double.Parse(txtsalarysalaryWorkContribution.Text),
                salaryTreasurContribution = double.Parse(txtsalaryTreasurContribution.Text),
                salaryTotalContribution = double.Parse(txtsalaryTotalContribution.Text),
                totalTax = double.Parse(txtTotalTaxes.Text),
                TotalAllowanace = double.Parse(txtTotalAllowanace.Text),
                committeeAmount = string.IsNullOrEmpty(txtcommittee.Text) ? (double?)0 : double.Parse(txtcommittee.Text),
                salaryDate = Convert.ToDateTime(dateTimePicker1.Text),
                salaryAbsentDay = string.IsNullOrEmpty(txtAbsentDay.Text) ? (int?)0 : Convert.ToInt32(txtAbsentDay.Text),
                salaryletter = txtArabicWord.Text,
                absentamount = string.IsNullOrEmpty(txtabsentamount.Text) ? (double?)0 : double.Parse(txtabsentamount.Text)

            };
            db.SalaryLogs.AddOrUpdate(salary);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                cbemployeeId.Text = row.Cells[1].Value.ToString();
                txtyear.Text = row.Cells[2].Value.ToString();
                txtrmonth.Text = row.Cells[3].Value.ToString();
                txtBasicSalary.Text = row.Cells[4].Value.ToString();
                txtallowanceDelay.Text = row.Cells[5].Value.ToString();
                txtallowanceSecondment.Text = row.Cells[6].Value.ToString();
                txtcommittee.Text = row.Cells[7].Value.ToString();
                txtTotalSalary.Text= row.Cells[8].Value.ToString();
                txtJihadTax.Text = row.Cells[9].Value.ToString();
                txtSocialSecurityTax.Text = row.Cells[10].Value.ToString();
                txtsolidarityTax.Text = row.Cells[11].Value.ToString();
                txtsalarysalaryWorkContribution.Text = row.Cells[12].Value.ToString();
                txtsalaryTreasurContribution.Text = row.Cells[13].Value.ToString();
                txtsalaryTotalContribution.Text = row.Cells[14].Value.ToString();
                txtNetSalary.Text = row.Cells[15].Value.ToString();
                txtTotalTaxes.Text= row.Cells[16].Value.ToString();
                txtTotalAllowanace.Text = row.Cells[17].Value.ToString();
                dateTimePicker1.Text = row.Cells[18].Value.ToString();
                txtAbsentDay.Text = row.Cells[19].Value.ToString();
                txtArabicWord.Text = row.Cells[20].Value.ToString();
                txtabsentamount.Text = row.Cells[21].Value.ToString();

            }
        }
    }
}
