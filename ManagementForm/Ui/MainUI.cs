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
    public partial class MainUI : Form
    {   
        DepartmentUI departmentUI = new DepartmentUI();
        AltelierUI altelierUI = new AltelierUI();
        EmployeeUI employeeUI = new EmployeeUI();
        RevenueUI revenueUI = new RevenueUI();
        WorkingTimeUI workingTimeUI = new WorkingTimeUI();
        SalaryUI salaryUI = new SalaryUI();
        StaticUI staticUI = new StaticUI();
        RegistrerUI registrerUI = new RegistrerUI();

        public MainUI()
        {
            InitializeComponent();
        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {
            
            /*  charge the sub-form into the panel  */
            // Add departmentUI
            departmentUI.TopLevel = false;
            this.panelCenter.Controls.Add(departmentUI);

            // Add AltelierUI
            altelierUI.TopLevel = false;
            this.panelCenter.Controls.Add(altelierUI);

            // Add employeeUI
            employeeUI.TopLevel = false;
            this.panelCenter.Controls.Add(employeeUI);

            // Add revenueUI
            revenueUI.TopLevel = false;
            this.panelCenter.Controls.Add(revenueUI);

            // Add workingTimeUI
            workingTimeUI.TopLevel = false;
            this.panelCenter.Controls.Add(workingTimeUI);

            // Add salaryUI
            salaryUI.TopLevel = false;
            this.panelCenter.Controls.Add(salaryUI);

            // Add salaryUI
            staticUI.TopLevel = false;
            this.panelCenter.Controls.Add(staticUI);


            // Add registrerUI
            registrerUI.TopLevel = false;
            this.panelCenter.Controls.Add(registrerUI);

        }

        private void ButtonDepartment_Click(object sender, EventArgs e)
        {
            
            ActionHideAllSubForm();
            departmentUI.Show();
        }

        private void ButtonAltelier_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            altelierUI.Show();
        }


        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            employeeUI.Show();
        }

        private void ButtonWorkingTime_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            workingTimeUI.Show();
        }

        private void ButtonRevenue_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            revenueUI.Show();
        }

        private void ButtonSalary_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            salaryUI.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            staticUI.Show();
        }

        private void ButtonRegistrer_Click(object sender, EventArgs e)
        {
            ActionHideAllSubForm();
            registrerUI.Show();
        }

        // hide all the created sub-form 
        private void ActionHideAllSubForm()
        {
            departmentUI.Hide();
            altelierUI.Hide();
            employeeUI.Hide();
            revenueUI.Hide();
            workingTimeUI.Hide();
            salaryUI.Hide();
            staticUI.Hide();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 强制退出所有线程
            System.Environment.Exit(0);
        }

        private void MainUI_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabelUserLevel.Text ="当前权限: " + Convert.ToString(Comon.Authority);
            // 封闭没有权限进入的功能
            switch (Comon.Authority)
            {
                case 0:
                    break;
                case 1:
                    this.buttonRegistrer.Enabled = false;
                    break;
                case 2:
                    this.buttonRegistrer.Enabled = false;
                    break;
            }
        }

    }
}
