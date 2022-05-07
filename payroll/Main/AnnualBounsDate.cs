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
    public partial class AnnualBounsDate : Form
    {
        Model1 db = new Model1();

        public AnnualBounsDate()
        {
            InitializeComponent();
        }

        private void AnnualBounsDate_Load(object sender, EventArgs e)
        {
            var emplpy = (from c in db.Employees
                          join s in db.EmployeeDegreees on c.degreeId equals s.degreeId
                          select new
                          {
                              c.employeeName,
                              c.EmployeeDegreee.degreeNumber,
                              c.emlpoyeeBouns,
                              s.degreeId,
                              c.employeeId
                          }).ToList();
            cbemployeeId.DataSource = emplpy.ToList();
            cbemployeeId.DisplayMember = "employeeName";
            cbemployeeId.ValueMember = "employeeId";

            cbemployementDegreeId.DataSource = emplpy.ToList();
            cbemployementDegreeId.DisplayMember = "degreeNumber";
            cbemployementDegreeId.ValueMember = "degreeId";

            cbBouns.DataSource = emplpy.ToList();
            cbBouns.DisplayMember = "emlpoyeeBouns";
            cbBouns.ValueMember = "employeeId";


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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic empId = cbemployeeId.SelectedValue;
            dynamic degree = cbemployementDegreeId.SelectedValue;
            dynamic bouns = cbBouns.SelectedValue;

            var empl = new Employee()
            {
                employeeId = empId,
                degreeId = degree,
                emlpoyeeBouns = int.Parse(txtbouns.Text),
                employeebounsDate = Convert.ToDateTime(allowanceLogDate.Text),
            };
            db.Employees.Attach(empl);
            db.Entry(empl).Property("employeeId").IsModified = true;
            db.Entry(empl).Property("degreeId").IsModified = true;
            db.Entry(empl).Property("emlpoyeeBouns").IsModified = true;
            db.Entry(empl).Property("employeebounsDate").IsModified = true;
            var rows = db.SaveChanges();
            MessageBox.Show("تم الاضافة");

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtallowanceLogNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbemployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbemployementDegreeId.SelectedItem = cbemployeeId.SelectedItem;
            cbBouns.SelectedItem = cbemployeeId.SelectedItem;
        }

        private void cbemployementDegreeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbemployeeId.SelectedItem = cbemployementDegreeId.SelectedItem; 
        }
    }
}
