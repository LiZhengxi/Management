using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementForm.Controller;
using ManagementForm.Model;

namespace ManagementForm.Ui
{
    public partial class DepartmentUI : Form
    {
        DepartmentController departmentController = new DepartmentController();

        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewDepartmentUI addNewDepartmentUI = new AddNewDepartmentUI(1);
            addNewDepartmentUI.Owner = this;
            addNewDepartmentUI.ShowDialog();
        }

        private void DepartmentUI_Load(object sender, EventArgs e)
        {
            RenewDataAsync();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RenewDataAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            deleteAltelierAsync();
        }
        /*
         * Comon function 
         */
        public async Task RenewDataAsync()
        {
            try
            {
                var result = departmentController.GetAllDepartment(null,"").ToList();
                if (result.Count() > 0)
                {
                    dataGridView.DataSource = result;
                    dataGridView.Columns[0].Visible = false;

                    dataGridView.Columns[1].HeaderText = "部门名";
                    dataGridView.Columns[2].HeaderText = "是否为记件车间";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void deleteAltelierAsync()
        {
            // Get userId
            int i = dataGridView.CurrentRow.Index;
            long departmentId = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            if (departmentId > 0)
            {
                string warningMessage = "是否确认删除部门 " + dataGridView.Rows[i].Cells[1].Value.ToString().Trim() + "(注意,删除部门将删除部门旗下所有车间)";
                if (MessageBox.Show(warningMessage, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (departmentController.RemoveDepartment(departmentId) > 0)
                    {
                        MessageBox.Show("删除成功");
                        RenewDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("无法删除该部门");
                    }
                }
            }
            else
            {
                MessageBox.Show("无法删除该部门");
            }
        }
    }
}
