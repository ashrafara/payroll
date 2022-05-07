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
    public partial class showSalaray : Form
    {
        Model1 db = new Model1();

        public showSalaray()
        {
            InitializeComponent();


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
                          salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay
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
            dataGridView1.Columns[18].HeaderText = "تاريخ الغياب";
        }

        private void showSalaray_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.SalaryLogs
                            orderby p.salaryLogID ascending
                            group p by new
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
                                salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay

                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.SalaryLogs
                            where p.Employee.employeeName.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.salaryDate.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.salaryLogID ascending
                            group p by new
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
                                salaryAbsent_Day = p.salaryAbsentDay == null ? 0 : p.salaryAbsentDay
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
