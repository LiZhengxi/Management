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
            AddNewUserUI addNewUserUI = new AddNewUserUI();
            addNewUserUI.Owner = this;
            addNewUserUI.ShowDialog();
        }


        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView.CurrentRow.Index;
            long index = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            using (var db = new ManagementDbContext())
            {
                var user = db.Users.Find(index);
                ModifyUserUI modifyUserUI = new ModifyUserUI(user.Id, user.Username, user.Password,user.Authority??2 );
                modifyUserUI.Owner = this;
                modifyUserUI.ShowDialog();
            }
           
        }

        private void RegistrerUI_Load(object sender, EventArgs e)
        {

            RenewData();
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
                dataGridView.Columns[3].Visible = false;
                dataGridView.Columns[5].Visible = false;
                dataGridView.Columns[4].HeaderText = "用户名";
                dataGridView.Columns[6].HeaderText = "权限";
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
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

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RenewData();
        }
    }
}
