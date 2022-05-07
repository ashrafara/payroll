using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll.Edit
{
    public partial class ShowEmployee : Form
    {
        Model1 db = new Model1();

        public ShowEmployee()
        {
            InitializeComponent();

            var emps = from p in db.Employees
                       select new
                       {
                           employee_Id = p.employeeId,
                           employee_Name = p.employeeName == null ? "" : p.employeeName,
                           employee_Nationality = p.employeeNationality == null ? "" : p.employeeNationality,
                           employee_NationalNo = p.employeeNationalNo == null ? "" : p.employeeNationalNo,
                           employee_InsuranceNo = p.employeeInsuranceNo == null ? "" : p.employeeInsuranceNo,
                           employee_Departement = p.employeeDepartement == null ? "" : p.employeeDepartement,
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string employeeId = dataGridView1.Rows[0].Cells[0].Value.ToString();
            emp_view frm = new emp_view(employeeId);
            frm.ShowDialog();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.Employees
                            orderby p.employeeId ascending
                            group p by new
                            {
                                employee_Id = p.employeeId,
                                employee_Name = p.employeeName == null ? "" : p.employeeName,
                                employee_Nationality = p.employeeNationality == null ? "" : p.employeeNationality,
                                employee_NationalNo = p.employeeNationalNo == null ? "" : p.employeeNationalNo,
                                employee_InsuranceNo = p.employeeInsuranceNo == null ? "" : p.employeeInsuranceNo,
                                employee_Departement = p.employeeDepartement == null ? "" : p.employeeDepartement,
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

                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.Employees
                            where p.employeeName.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.employeeDepartement.ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.employeeId ascending
                            group p by new
                            {
                                employee_Id = p.employeeId,
                                employee_Name = p.employeeName == null ? "" : p.employeeName,
                                employee_Nationality = p.employeeNationality == null ? "" : p.employeeNationality,
                                employee_NationalNo = p.employeeNationalNo == null ? "" : p.employeeNationalNo,
                                employee_InsuranceNo = p.employeeInsuranceNo == null ? "" : p.employeeInsuranceNo,
                                employee_Departement = p.employeeDepartement == null ? "" : p.employeeDepartement,
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
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
