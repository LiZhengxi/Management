using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementForm.Controller;
using ManagementForm.Model;

namespace ManagementForm.Ui
{
    public partial class RegistrerUI : Form
    {
        AuthController authController = new AuthController();

        RegistrerController registrerController = new RegistrerController();

        public RegistrerUI()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addUser();
        }

        // Modify user
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modifyUser();
        }

        private void RegistrerUI_Load(object sender, EventArgs e)
        {
           RenewDataAsync();
        }

        // Remove user
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            deleteUserAsync();
        }

        private void ButtonRefresh_ClickAsync(object sender, EventArgs e)
        {
            RenewDataAsync();
         
        }
  
        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try {
                    // 若行已是选中状态就不再进行设置
                    if (dataGridView.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView.ClearSelection();
                        dataGridView.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView.SelectedRows.Count == 1)
                    {
                        dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    long userId = Convert.ToInt64(this.dataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                    contextMenuStripRightClick.Show(MousePosition.X, MousePosition.Y);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
           
        }
        
        // Modify user
        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyUser();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUserAsync();
        }

        /*
         * Function zone 
         */
        public void addUser()
        {
            AddNewUserUI addNewUserUI = new AddNewUserUI(0);
            addNewUserUI.Owner = this;
            addNewUserUI.ShowDialog();
        }

        public void modifyUser()
        {
            int i = dataGridView.CurrentRow.Index;
            long index = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            if (index >0)
            {
                AddNewUserUI addNewUserUI = new AddNewUserUI(index);
                addNewUserUI.Owner = this;
                addNewUserUI.ShowDialog();
            }
        }

        public void deleteUserAsync()
        {
            // Get userId
            int i = dataGridView.CurrentRow.Index;
            long userId = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            if (userId > 0)
            {
                string warningMessage = "是否确认删除用户 " + dataGridView.Rows[i].Cells[1].Value;
                if (MessageBox.Show(warningMessage, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (authController.RemoveUser(userId) > 0)
                    {
                        MessageBox.Show("删除成功");
                        RenewDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("无法删除用户");
                    }
                }
            }
            else
            {
                MessageBox.Show("无法删除用户");
            }
        }

        public async Task RenewDataAsync()
        {
                try {
                    var result = authController.GetAllUsers(null,null,"").ToList();
                    if (result.Count() > 0)
                    {
                        dataGridView.DataSource = result;
                        dataGridView.Columns[0].Visible = false;

                        dataGridView.Columns[1].HeaderText = "用户名";
                        dataGridView.Columns[2].HeaderText = "权限";
                    }
                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

        }
        

    }
}
