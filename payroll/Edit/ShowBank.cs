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
    public partial class ShowBank : Form
    {
        Model1 db = new Model1();

        public ShowBank()
        {
            InitializeComponent();


            var deg = from p in db.Banks
                      select new
                      {
                          degree_Id = p.bankId,
                          degree_Number = p.mainBank == null ? "" : p.mainBank,
                          degree_Amount = p.branchBank == null ? "" : p.branchBank
                      };
            dataGridView1.DataSource = deg.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "المصرف ";
            dataGridView1.Columns[2].HeaderText = "الفرع";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.Banks
                            orderby p.bankId ascending
                            group p by new
                            {
                                employee_Id = p.bankId,
                                employee_Name = p.mainBank == null ? "" : p.mainBank,
                                employee_Nationality = p.branchBank == null ? "" : p.branchBank


                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.Banks
                            where p.mainBank.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.branchBank.ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.bankId ascending
                            group p by new
                            {
                                employee_Id = p.bankId,
                                employee_Name = p.mainBank == null ? "" : p.mainBank,
                                employee_Nationality = p.branchBank == null ? "" : p.branchBank
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }
 
    }
}
