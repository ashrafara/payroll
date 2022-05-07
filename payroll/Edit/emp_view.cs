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
    public partial class emp_view : Form
    {
        Model1 db = new Model1();

        public emp_view()
        {
        }

        public emp_view(string employeeId)
        {
            InitializeComponent();

            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "payroll");
            rpt.SetParameterValue("@employeeId", employeeId.ToString());
            crystalReportViewer1.ReportSource = rpt;           
        }

        private void emp_view_Load(object sender, EventArgs e)
        {

        }
    }
}
