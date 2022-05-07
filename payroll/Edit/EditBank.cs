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
    public partial class EditBank : Form
    {
        Model1 db = new Model1();

        public EditBank()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var degree = new Bank
            {
                bankId = int.Parse(textBox1.Text),
                mainBank = txtbankmain.Text,
                branchBank = txtbranch.Text
            };
            db.Banks.AddOrUpdate(degree);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var deleteddegree = (from dege in db.Banks
                                 where dege.bankId == id
                                 select dege).Single();

            db.Banks.Remove(deleteddegree);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtbankmain.Text = row.Cells[1].Value.ToString();
                txtbranch.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
