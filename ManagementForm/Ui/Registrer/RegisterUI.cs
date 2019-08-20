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
    public partial class RegistrerUI : Form
    {
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

            RenewData();
        }

        // Remove user
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RenewData();
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
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
               long userId = Convert.ToInt64( this.dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                
                contextMenuStripRightClick.Show(MousePosition.X, MousePosition.Y);
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
            deleteUser();
        }

        /*
         * Function zone 
         */
        public void addUser()
        {
            AddNewUserUI addNewUserUI = new AddNewUserUI();
            addNewUserUI.Owner = this;
            addNewUserUI.ShowDialog();
        }

        public void deleteUser()
        {
            // Get userId
            int i = dataGridView.CurrentRow.Index;
            long index = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            using (var db = new ManagementDbContext())
            {
                var user = db.Users.Find(index);
                string warningMessage = "是否确认删除用户" + user.Username;
                if (MessageBox.Show(warningMessage, "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Users.Remove(user);
                    db.SaveChangesAsync();
                    MessageBox.Show("删除成功");
                    RenewData();
                }
            }
        }

        public void RenewData()
        {
            using (var db = new ManagementDbContext())
            {
                var result = (from user in db.Users select user).ToList();
            
                dataGridView.DataSource = result;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[4].Visible = false;
                dataGridView.Columns[3].HeaderText = "用户名";
                dataGridView.Columns[5].HeaderText = "权限";
            }
        }
        
        public void modifyUser()
        {
            int i = dataGridView.CurrentRow.Index;
            long index = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            using (var db = new ManagementDbContext())
            {
                var user = db.Users.Find(index);
                ModifyUserUI modifyUserUI = new ModifyUserUI(user.Id, user.Username, user.Password, user.Authority ?? 2);
                modifyUserUI.Owner = this;
                modifyUserUI.ShowDialog();
            }
        }

    }
}
