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
using System.Data.Entity;

namespace payroll.Edit
{
    public partial class Editemployee : Form
    {
        Model1 db = new Model1(); 

        public Editemployee()
        {
            InitializeComponent();


            var emplpy = (from c in db.EmployeeDegreees
                          select new { c.degreeNumber, c.degreeId }).ToList();
            cbDegreee.DataSource = emplpy.ToList();
            cbDegreee.DisplayMember = "degreeNumber";
            cbDegreee.ValueMember = "degreeId";


            var ban = (from c in db.Banks
                       select new { c.mainBank, c.branchBank, c.bankId }).ToList();
            coBank.DataSource = ban.ToList();
            coBank.DisplayMember = "mainBank";
            coBank.ValueMember = "bankId";

            coBankBranch.DataSource = ban.ToList();
            coBankBranch.DisplayMember = "branchBank";
            coBankBranch.ValueMember = "bankId";


            var emps = from p in db.Employees
                      select new
                      {
                          employee_Id = p.employeeId,
                          employee_Name = p.employeeName == null ? "" : p.employeeName,
                          employee_Nationality = p.employeeNationality == null ? "" : p.employeeNationality,
                          employee_NationalNo = p.employeeNationalNo == null ? "" : p.employeeNationalNo,
                          employee_InsuranceNo = p.employeeInsuranceNo == null ? "" : p.employeeInsuranceNo,
                          employee_Departement= p.employeeDepartement == null ? "" : p.employeeDepartement,
                          employee_Division = p.employeeDivision == null ? "" : p.employeeDivision, 
                          employement_Name = p.employementName == null ? "" : p.employementName, 
                          degree_Id = p.EmployeeDegreee.degreeNumber == null ? "" : p.EmployeeDegreee.degreeNumber,
                          emlpoyee_Bouns = p.emlpoyeeBouns == null ? 0 : p.emlpoyeeBouns,
                          employee_State = p.employeeState == null ? "" : p.employeeState,
                          main_Bank = p.Bank.mainBank == null ? "" : p.Bank.mainBank,
                          branch_Bank = p.Bank.branchBank == null ? "" : p.Bank.branchBank,
                          employee_BankNumber = p.employeeBankNumber == null ? "" : p.employeeBankNumber,
                          employee_StartDate = p.employeeStartDate,
                          employee_Salary = p.employeeSalary == null ? "" : p.employeeSalary,
                          employeeDegree_Assign = p.employeeDegreeAssign == null ? 0 : p.employeeDegreeAssign,
                          employeeBouns_Assign = p.employeeBounsAssign == null ? 0 : p.employeeBounsAssign
                      };
            dataGridView1.DataSource = emps.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف ";
            dataGridView1.Columns[2].HeaderText = "الجنسية";
            dataGridView1.Columns[3].HeaderText = "الرقم الوطني ";
            dataGridView1.Columns[4].HeaderText = "الرقم الضماني ";
            dataGridView1.Columns[5].HeaderText = "الادارة ";
            dataGridView1.Columns[6].HeaderText = "القسم ";
            dataGridView1.Columns[7].HeaderText = "اسم الوظيفية ";
            dataGridView1.Columns[8].HeaderText = "الدرجة  ";
            dataGridView1.Columns[9].HeaderText = "العلاوة ";
            dataGridView1.Columns[10].HeaderText = "حال الموظف ";
            dataGridView1.Columns[11].HeaderText = "المصرف ";
            dataGridView1.Columns[12].HeaderText = "الفرع ";
            dataGridView1.Columns[13].HeaderText = "الرقم الحسابي ";
            dataGridView1.Columns[14].HeaderText = "تاريخ بداية العمل ";
            dataGridView1.Columns[15].HeaderText = "حال المرتب ";
            dataGridView1.Columns[16].HeaderText = "الدرجة المنتدب اليها ";
            dataGridView1.Columns[17].HeaderText = "العلاوة المنتدب اليها ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic degree = cbDegreee.SelectedValue;
            dynamic mbank = coBank.SelectedValue;
            dynamic empType = comboBox1.SelectedItem;
            dynamic stt = comboBox2.SelectedItem;
            dynamic dep = coDepartement.SelectedItem;
            dynamic div = coDivision.SelectedItem;
            var employ = new Employee
            {
                employeeId= int.Parse(textBox1.Text), 
                employeeName = txtemployeeName.Text,
                employeeBankNumber = txtemployeeBankNumber.Text,
                emlpoyeeBouns = int.Parse(txtbouns.Text),
                employeeDepartement = dep,
                employeeDivision = div,
                employeeInsuranceNo = txtemployeeInsuranceNumber.Text,
                employeeNationality = txtNationality.Text,
                employeeNationalNo = txtemployeeNationalNumber.Text,
                employementName = txtemployementName.Text,
                employeeState = empType,
                employeeStartDate = Convert.ToDateTime(dateTimePicker1.Text),
                degreeId = degree, 
                employeeSalary= stt,
                bankId=mbank,
                employeeDegreeAssign= int.Parse(txtdegreAssign.Text),
                employeeBounsAssign= int.Parse(txtbounsAssign.Text)
            };
            db.Employees.AddOrUpdate(employ);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.Employees
                                where c.employeeId ==id
                                select c).Single();
            db.Employees.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtemployeeName.Text = row.Cells[1].Value.ToString();
                txtNationality.Text = row.Cells[2].Value.ToString();
                txtemployeeNationalNumber.Text = row.Cells[3].Value.ToString();
                txtemployeeInsuranceNumber.Text = row.Cells[4].Value.ToString();
                coDepartement.Text = row.Cells[5].Value.ToString();
                coDivision.Text = row.Cells[6].Value.ToString();
                txtemployementName.Text = row.Cells[7].Value.ToString();
                cbDegreee.Text = row.Cells[8].Value.ToString();
                txtbouns.Text = row.Cells[9].Value.ToString();
                comboBox1.Text = row.Cells[10].Value.ToString();
                coBank.Text = row.Cells[11].Value.ToString();
                coBankBranch.Text = row.Cells[12].Value.ToString();
                txtemployeeBankNumber.Text = row.Cells[13].Value.ToString();
                dateTimePicker1.Text = row.Cells[14].Value.ToString();
                comboBox2.Text = row.Cells[15].Value.ToString();
                txtdegreAssign.Text= row.Cells[16].Value.ToString();
                txtbounsAssign.Text= row.Cells[17].Value.ToString();

            }
        }

        private void Editemployee_Load(object sender, EventArgs e)
        {

        }

        private void coBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBankBranch.SelectedItem = coBank.SelectedItem;
        }
    }
}
