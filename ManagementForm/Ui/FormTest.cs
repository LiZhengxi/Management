using ManagementForm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementForm.Ui
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SalaryController salaryController = new SalaryController();
            IQueryable<object> test = salaryController.GetAllSalary();

            //AuthController authController = new AuthController();
            AltelierController altelierController = new AltelierController();

            DepartmentController departmentController = new DepartmentController();

            IQueryable<object> test1 = departmentController.GetAllDepartment(null,"");

            dataGridView1.DataSource =  test1.ToList();
        }
    }
}
