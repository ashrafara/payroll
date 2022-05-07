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
    public partial class AddDegree : Form
    {
        Model1 db = new Model1();

        public AddDegree()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtdegreeNo.Text==""|| txtdegreecost.Text=="" || txtbounsCost.Text=="")
            {
                MessageBox.Show("الرجاء تعبئة الخانات الفارغة");
            }
            else
            {
                var degree = new EmployeeDegreee
                {
                    degreeNumber = string.IsNullOrEmpty(txtdegreeNo.Text) ? "" : txtdegreeNo.Text,
                    degreeAmount = string.IsNullOrEmpty(txtdegreecost.Text) ? (double?)0 : double.Parse(txtdegreecost.Text) * 1000 / 1000,
                    bounsNumber = string.IsNullOrEmpty(txtbounsCost.Text) ? (double?)0 : double.Parse(txtbounsCost.Text) * 1000 / 1000
                };
                db.EmployeeDegreees.Add(degree);
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
        private void AddDegree_Load(object sender, EventArgs e)
        {

        }

        private void txtdegreeNo_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtdegreecost_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtbounsCost_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
