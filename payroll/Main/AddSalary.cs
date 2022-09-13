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
using payroll.BL;

namespace payroll.Main
{
    public partial class AddSalary : Form
    {
        Model1 db = new Model1();
        private double AbsentDay;
        private double allowanceDelay;
        private double committee;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        private double salaryAbsentDay;
        private double addextratime;

        public AddSalary()
        {
            InitializeComponent();

            var emplpy = (from c in db.Employees
                          join s in db.EmployeeDegreees on c.degreeId equals s.degreeId
                          where c.employeeSalary =="مفعل"
                          orderby c.employeeName
                          select new
                          {
                              c.employeeName,
                              c.EmployeeDegreee.degreeNumber,
                              c.emlpoyeeBouns,
                              c.employeeState,
                              c.employeeSalary, 
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
            cbdegree.ValueMember = "degreeId";

            cbemploymentType.DataSource = emplpy.ToList();
            cbemploymentType.DisplayMember = "employeeState";
            cbemploymentType.ValueMember = "employeeId";

            cbannualBounsId.DataSource = emplpy.ToList();
            cbannualBounsId.DisplayMember = "bounsNumber";
            cbannualBounsId.ValueMember = "degreeId";


            cbdegreeamount.DataSource = emplpy.ToList();
            cbdegreeamount.DisplayMember = "degreeAmount";
            cbdegreeamount.ValueMember = "degreeId";

            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "employeeSalary";
            comboBox1.ValueMember = "employeeId";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddSalary_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Libya));
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
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            dynamic empId = cbemployeeId.SelectedValue;
            dynamic boundId = cbBouns.SelectedValue;
            dynamic degreeId = cbdegree.SelectedText;
            dynamic empType= cbemploymentType.SelectedValue;
            dynamic bounsAmount = cbannualBounsId.SelectedValue;
            dynamic degreeAmount = cbdegreeamount.SelectedValue;

         
            if (txtrmonth.Text== "" && txtyear.Text == "")
            {
                MessageBox.Show("الرجاء ادخال الشهر والسنة");
            }
            else
            {
                var salary = new SalaryLog
                {
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
                    salaryAbsentDay= string.IsNullOrEmpty(txtAbsentDay.Text) ? (int?)0 : Convert.ToInt32(txtAbsentDay.Text),
                    salaryletter= txtArabicWord.Text,
                    absentamount = string.IsNullOrEmpty(txtabsentamount.Text) ? (double?)0 : double.Parse(txtabsentamount.Text),
                    addextratime= string.IsNullOrEmpty(txtextra.Text) ? (double?)0 : double.Parse(txtextra.Text)

                };
                db.SalaryLogs.Add(salary);
                db.SaveChanges();
                MessageBox.Show("تم الاضافة");
                ClearTextBoxes();
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            var empType = cbemploymentType.Text.ToString();
            var degrees = cbdegree.Text.ToString();
            var bounss = cbBouns.Text.ToString();
            var bounsamounts = cbannualBounsId.Text.ToString();
            var degreeamounts = cbdegreeamount.Text.ToString();
            var emsal = comboBox1.Text.ToString();

            if (empType.ToString() == "ندب" )
            {
                txtallowanceSecondment.Visible = true;
               

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = Math.Truncate(bounsamonut * bounsno* 1000)/1000;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

                double bs = BasicSalary / 30;
                double wage = Math.Truncate(bs *1000)/1000;
                txtWage.Text = wage.ToString();

                double AbsentDay;
                if (double.TryParse(txtAbsentDay.Text, out AbsentDay))
                {
                    salaryAbsentDay += AbsentDay;
                }

                
                double allowanceSecondment = Math.Truncate(BasicSalary * 100)/1000;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double extratime;
                if (double.TryParse(txtextra.Text, out extratime))
                {
                    addextratime += extratime;
                }

                double amount;

                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double ab = (wage * AbsentDay);
                double absentamount = Math.Truncate(ab * 1000) / 1000;
                txtabsentamount.Text = absentamount.ToString();

                double TotalAllowanace = allowanceSecondment + amount + committeamount;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary = BasicSalary + allowanceSecondment + amount + committeamount + extratime;
                txtTotalSalary.Text = TotalSalary.ToString();

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5)/1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10)/1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jdi =SocialSecurityTax + solidarityTax;
                double jd = TotalSalary - jdi;
                double JihadTax = Math.Truncate(jd * 30)/1000;
                txtJihadTax.Text = JihadTax.ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + absentamount;
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = TotalSalary - TotalTaxes;
                txtNetSalary.Text = NetSalary.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105)/1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5)/1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double salaryTotalContribution = salarysalaryWorkContribution + salaryTreasurContribution;
                txtsalaryTotalContribution.Text = salaryTotalContribution.ToString();
            }
            if (empType.ToString() == "موفد")
            {
                txtallowanceSecondment.Visible = false;

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = bounsamonut * bounsno;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

                double allowanceSecondment = BasicSalary * 0.0;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double wg = BasicSalary / 30;
                double wage = Math.Truncate(wg * 1000) / 1000;
                txtWage.Text = wage.ToString();

                double extratime;
                if (double.TryParse(txtextra.Text, out extratime))
                {
                    addextratime += extratime;
                }

                double amount;
                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double AbsentDay;
                if (double.TryParse(txtAbsentDay.Text, out AbsentDay))
                {
                    salaryAbsentDay += AbsentDay;
                }

                double ab = (wage * AbsentDay);
                double absentamount = Math.Truncate(ab * 1000) / 1000;
                txtabsentamount.Text = absentamount.ToString();

                double TotalAllowanace = amount + committeamount + extratime;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary = ((BasicSalary + amount + committeamount)*0.25);
                txtTotalSalary.Text = TotalSalary.ToString();

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5) / 1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10) / 1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jdi = SocialSecurityTax + solidarityTax;
                double jd = TotalSalary - jdi;
                double JihadTax = Math.Truncate(jd * 30) / 1000;
                txtJihadTax.Text = JihadTax.ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + absentamount;
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = TotalSalary - TotalTaxes;
                txtNetSalary.Text = NetSalary.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105) / 1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5) / 1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double salaryTotalContribution = salarysalaryWorkContribution + salaryTreasurContribution;
                txtsalaryTotalContribution.Text = salaryTotalContribution.ToString();

            }
            else
            {
                txtallowanceSecondment.Visible = false;

                double bounsamonut = double.Parse(bounsamounts.ToString());

                double bounsno = double.Parse(bounss.ToString());

                double bouns = bounsamonut * bounsno;

                double BasicSalary = double.Parse(degreeamounts.ToString()) + bouns;
                txtBasicSalary.Text = BasicSalary.ToString();

                double allowanceSecondment = BasicSalary * 0.0;
                txtallowanceSecondment.Text = allowanceSecondment.ToString();

                double wg = BasicSalary / 30;
                double wage = Math.Truncate( wg* 1000)/1000;
                txtWage.Text = wage.ToString();


                double extratime;
                if (double.TryParse(txtextra.Text, out extratime))
                {
                    addextratime += extratime;
                }

                double amount;
                if (double.TryParse(txtallowanceDelay.Text, out amount))
                {
                    allowanceDelay += amount;
                }

                double committeamount;
                if (double.TryParse(txtcommittee.Text, out committeamount))
                {
                    committee += committeamount;
                }

                double AbsentDay;
                if (double.TryParse(txtAbsentDay.Text, out AbsentDay))
                {
                    salaryAbsentDay += AbsentDay;
                }

                double ab = (wage * AbsentDay);
                double absentamount = Math.Truncate( ab* 1000) / 1000;
                txtabsentamount.Text = absentamount.ToString();

                double TotalAllowanace = amount + committeamount + extratime;
                txtTotalAllowanace.Text = TotalAllowanace.ToString();

                double TotalSalary= BasicSalary + amount + committeamount + extratime;
                txtTotalSalary.Text = TotalSalary.ToString();

                double SocialSecurityTax = Math.Truncate(TotalSalary * 37.5)/1000;
                txtSocialSecurityTax.Text = SocialSecurityTax.ToString();

                double solidarityTax = Math.Truncate(TotalSalary * 10)/1000;
                txtsolidarityTax.Text = solidarityTax.ToString();

                double jdi = SocialSecurityTax + solidarityTax;
                double jd = TotalSalary - jdi;
                double JihadTax = Math.Truncate( jd* 30)/1000;
                txtJihadTax.Text = JihadTax.ToString();

                double TotalTaxes = SocialSecurityTax + solidarityTax + JihadTax + absentamount;
                txtTotalTaxes.Text = TotalTaxes.ToString();

                double NetSalary = TotalSalary - TotalTaxes;
                txtNetSalary.Text = NetSalary.ToString();

                double salarysalaryWorkContribution = Math.Truncate(TotalSalary * 105) / 1000;
                txtsalarysalaryWorkContribution.Text = salarysalaryWorkContribution.ToString();

                double salaryTreasurContribution = Math.Truncate(TotalSalary * 7.5) / 1000;
                txtsalaryTreasurContribution.Text = salaryTreasurContribution.ToString();

                double salaryTotalContribution = salarysalaryWorkContribution + salaryTreasurContribution;
                txtsalaryTotalContribution.Text = salaryTotalContribution.ToString();
            }
        }

        private void cbemployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbannualBounsId.SelectedItem = cbemployeeId.SelectedItem;
            cbBouns.SelectedItem = cbemployeeId.SelectedItem;
            cbdegreeamount.SelectedItem = cbemployeeId.SelectedItem;
            cbdegree.SelectedItem= cbemployeeId.SelectedItem;
            cbemploymentType.SelectedItem = cbemployeeId.SelectedItem;
            comboBox1.SelectedItem= cbemployeeId.SelectedItem;
            if (comboBox1.Text=="موقوف")
            {
                cbemployeeId.Visible = false;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtcommittee_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtrmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtallowanceDelay_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtNetSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(txtNetSalary.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);
                txtArabicWord.Text = toWord.ConvertToArabic();
                txtArabicWord.Text=txtArabicWord.Text.Substring(0,txtArabicWord.Text.IndexOf("دينار")+5);
               decimal d= Convert.ToDecimal(txtNetSalary.Text)- Math.Truncate(Convert.ToDecimal(txtNetSalary.Text));
                if (d > 0)
                    txtArabicWord.Text += " و " + d.ToString().Substring(d.ToString().IndexOf('.') + 1, 3) + " درهما لاغير";
            }
            catch (Exception ex)
            {
                txtArabicWord.Text = String.Empty;
            }
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtyear.Text.IndexOf(' ') == txtyear.Text.Length - 5)
                e.Handled = true;
        }

        private void txtrmonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txtrmonth.Text + e.KeyChar) >= 13 ||
                txtrmonth.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txtArabicWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabsentamount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
