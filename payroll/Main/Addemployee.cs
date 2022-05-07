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

namespace payroll.Main
{
    public partial class Addemployee : Form
    {
        Model1 db = new Model1();

        public Addemployee()
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dynamic degree = cbDegreee.SelectedValue;
            dynamic mbank = coBank.SelectedValue;
            dynamic empType = comboBox1.SelectedItem;
            dynamic stt = comboBox2.SelectedItem;
            dynamic dep = coDepartement.SelectedItem;
            dynamic div = coDivision.SelectedItem;

            if (txtemployeeName.Text.ToString()==" "|| txtemployeeNationalNumber.Text=="" || txtemployementName.Text =="")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                var employ = new Employee
                {
                    employeeName = string.IsNullOrEmpty(txtemployeeName.Text) ? "" : txtemployeeName.Text,
                    employeeNationality = string.IsNullOrEmpty(txtNationality.Text) ? "" : txtNationality.Text,
                    employeeNationalNo = string.IsNullOrEmpty(txtemployeeNationalNumber.Text) ? "" : txtemployeeNationalNumber.Text,
                    employeeInsuranceNo = string.IsNullOrEmpty(txtemployeeInsuranceNumber.Text) ? "" : txtemployeeInsuranceNumber.Text,
                    employeeBankNumber = string.IsNullOrEmpty(txtemployeeBankNumber.Text) ? "" : txtemployeeBankNumber.Text,
                    employeeDepartement = string.IsNullOrEmpty(dep) ? null : dep,
                    employeeDivision = string.IsNullOrEmpty(div) ? null : div,
                    employementName = string.IsNullOrEmpty(txtemployementName.Text) ? "" : txtemployementName.Text,
                    degreeId = degree,
                    emlpoyeeBouns = string.IsNullOrEmpty(txtbouns.Text) ? (int?)0 : Convert.ToInt32(txtbouns.Text),
                    employeeState = empType,
                    employeeSalary = stt,
                    employeeStartDate = Convert.ToDateTime(dateTimePicker1.Text),
                    bankId = mbank,
                    employeeDegreeAssign = string.IsNullOrEmpty(txtdegreAssign.Text) ? (int?)0 : Convert.ToInt32(txtdegreAssign.Text),
                    employeeBounsAssign = string.IsNullOrEmpty(txtbounsAssign.Text) ? (int?)0 : Convert.ToInt32(txtbounsAssign.Text)
                };
                db.Employees.Add(employ);
                db.SaveChanges();
                MessageBox.Show("تم الاضافة");
                ClearTextBoxes();
            }
           

        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


        private void Addemployee_Load(object sender, EventArgs e)
        {

        }

        private void txtemployeeInsuranceNumber_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtemployeeNationalNumber_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtemployeeBankNumber_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtbouns_TextChanged(object sender, EventArgs e)
        {


        }

        private void coBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBankBranch.SelectedItem = coBank.SelectedItem;
        }

        private void txtemployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtemployeeInsuranceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtemployeeNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtbouns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdegreAssign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtbounsAssign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtemployementName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtemployeeBankNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
