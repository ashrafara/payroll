using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll.Main
{
    public partial class AddBank : Form
    {
        Model1 db = new Model1();

        public AddBank()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbankmain.Text=="" || txtbranch.Text=="")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                var degree = new Bank
                {
                    mainBank = string.IsNullOrEmpty(txtbankmain.Text) ? "" : txtbankmain.Text,
                    branchBank = string.IsNullOrEmpty(txtbranch.Text) ? "" : txtbranch.Text
                };
                db.Banks.Add(degree);
                db.SaveChanges();
                MessageBox.Show("تم الاضافة");
            }
            ClearTextBoxes();
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
    }
}
