using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementForm.Model;
using ManagementForm.Controller;


namespace ManagementForm.Ui
{
    public partial class AddNewDepartmentUI : Form
    {
        DepartmentController departmentController = new DepartmentController();

        long departmentId;

        public AddNewDepartmentUI(long departmentId)
        {
            InitializeComponent();
            this.departmentId = departmentId;
            Comon.AltelierToAdd.Clear();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonRegistrer_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName.Text;
            bool isWorkshop = radioButtonYes.Checked;
            string message="";

            if (departmentName != null && departmentName != "")
            {
                    Department department = new Department();
                    department.Id = departmentId;
                    department.department_name = departmentName;
                    department.isWorkshop = isWorkshop;

                    //message = (departmentController.AddOrUpdateDepartment(department) > 0) ?  "加入成功" : "加入失败";
                    //MessageBox.Show(message);
            }
        }

        private void AddNewUserUI_Load(object sender, EventArgs e)
        {   // Set the defaut combobox select item
            radioButtonNo.Checked = true;
            var department = (departmentId > 0) ? departmentController.GetAllDepartment(departmentId, "").FirstOrDefault() : null;
            if (department != null)
            {
                textBoxDepartmentName.Text = Comon.GetPropertyValue(department, "department_name").ToString().Trim();
                radioButtonYes.Checked = Comon.GetPropertyValue(department, "isWorkshop").ToString() == "True" ? true : false;
            }
        }

        private void ButtonAddAltelier_Click(object sender, EventArgs e)
        {
            bool isNewDepartment = true;
            //AddNewAltelierUI addNewAltelierUI = new AddNewAltelierUI(departmentController, isNewDepartment);
            //addNewAltelierUI.Owner = this;
            //addNewAltelierUI.ShowDialog();
        }

        private void RadioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
           if( radioButtonYes.Checked)
            {
                buttonAddAltelier.Visible = true;
                listViewAltelier.Visible = true; 
            }
            else
            {
                buttonAddAltelier.Visible = false;
                listViewAltelier.Visible = false;
            }
        }
        
        public void renewAltelierList()
        {
            listViewAltelier.Items.Clear();
           List<Altelier> alteliers =  departmentController.getAlteliers();
            foreach(Altelier a in alteliers)
            {
                listViewAltelier.Items.Add(a.alterlier_name);
            }
        }

    }
}
