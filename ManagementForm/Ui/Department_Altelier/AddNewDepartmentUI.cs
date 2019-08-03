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
        
        public AddNewDepartmentUI()
        {
            InitializeComponent();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonRegistrer_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                using (var db = new ManagementDbContext())
                {

                    string departmentName = textBoxDepartmentName.Text;

                    var result = (from d in db.Departments
                                  where d.department_name == departmentName
                                  select d.Id).FirstOrDefault();
                    if (result == 0)
                    {
                        var department = new Department
                        {
                            department_name = departmentName
                        };
                        db.Departments.Add(department);
                        db.SaveChanges();

                        var altelier = new Altelier
                        {
                            department_id = department.Id,
                            alterlier_name = department.department_name,
                            isWorkshop = false
                        };
                        db.Alteliers.Add(altelier);

                        db.SaveChanges();

                        MessageBox.Show("加入成功");
                        //AddNewDepartmentUI ower = (AddNewDepartmentUI)this.Owner;
                        //ower.renewAltelierList();
                    }
                    else
                    {
                        MessageBox.Show("该部门已存在");
                    }
                }
            }

            else
            {
                using (var db = new ManagementDbContext())
                {

                    string departmentName = textBoxDepartmentName.Text;

                    var result = (from d in db.Departments
                                  where d.department_name == departmentName
                                  select d.Id).FirstOrDefault();
                    if (result == 0)
                    {
                        var department = new Department
                        {
                            department_name = departmentName
                        };
                        db.Departments.Add(department);
                        db.SaveChanges();

                        List<Altelier> alteliers = departmentController.getAlteliers();
                        foreach (Altelier a in alteliers)
                        {
                            a.department_id = department.Id;
                            db.Alteliers.Add(a);
                        }
                        
                        db.SaveChanges();

                        MessageBox.Show("加入成功");
                        //AddNewDepartmentUI ower = (AddNewDepartmentUI)this.Owner;
                        //ower.renewAltelierList();
                    }
                    else
                    {
                        MessageBox.Show("该部门已存在");
                    }
                }

            }

        }

        private void AddNewUserUI_Load(object sender, EventArgs e)
        {   // Set the defaut combobox select item
            radioButtonNo.Checked = true;

        }

        private void ButtonAddAltelier_Click(object sender, EventArgs e)
        {
            bool isNewDepartment = true;
            AddNewAltelierUI addNewAltelierUI = new AddNewAltelierUI(departmentController, isNewDepartment);
            addNewAltelierUI.Owner = this;
            addNewAltelierUI.ShowDialog();

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
