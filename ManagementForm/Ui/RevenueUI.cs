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
    public partial class RevenueUI : Form
    {
        RevenueController revenueController = new RevenueController();
        public RevenueUI()
        {
            InitializeComponent();
        }


        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            RenewDataAsync();
        }

        private void RevenueUI_Load(object sender, EventArgs e)
        {
            RenewDataAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            deleteRevenueAsync();
            RenewDataAsync();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        /*
         * Function zone 
         */
        public async Task RenewDataAsync()
        {
            try
            {
                var result = revenueController.GetAllRevenue(null, null, null).ToList();

                dataGridView.DataSource = result;
                if (result.Count > 0)
                {
                    dataGridView.Columns[0].Visible = false;

                    dataGridView.Columns[1].HeaderText = "年";
                    dataGridView.Columns[2].HeaderText = "月";
                    dataGridView.Columns[3].HeaderText = "当月产值";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void deleteRevenueAsync()
        {
            // Get userId
            int i = dataGridView.CurrentRow.Index;
            long revenueId = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            if (revenueId > 0)
            {
                string warningMessage = "是否确认删除 " + dataGridView.Rows[i].Cells[1].Value + " 年" + dataGridView.Rows[i].Cells[2].Value+ " 月" + "产值";
                if (MessageBox.Show(warningMessage, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (revenueController.RemoveRevenue(revenueId) > 0)
                    {
                        MessageBox.Show("删除成功");
                        RenewDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("无法删除当月产值");
                    }
                }
            }
            else
            {
                MessageBox.Show("无法删除当月产值");
            }
        }

        public void addRevenue()
        {
            AddNewUserUI addNewUserUI = new AddNewUserUI(0);
            addNewUserUI.Owner = this;
            addNewUserUI.ShowDialog();
        }

        public void modifyUser()
        {
            int i = dataGridView.CurrentRow.Index;
            long index = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
            if (index > 0)
            {
                AddNewUserUI addNewUserUI = new AddNewUserUI(index);
                addNewUserUI.Owner = this;
                addNewUserUI.ShowDialog();
            }
        }

    }
}
