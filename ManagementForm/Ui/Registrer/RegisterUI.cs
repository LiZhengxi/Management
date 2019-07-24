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
            addNewUserUI.ShowDialog();
        }

        //private void RegistrerUI_Load(object sender, EventArgs e)
        //{
             
            
        //    using (var db = new ManagementDbContext())
        //    {   
              
        //        //dataGridView.DataSource = registrerController.GetAllUser();
        //    }
                    
        //}

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   // Get userId
            int i = dataGridView.CurrentRow.Index;
           long index = Convert.ToInt32( dataGridView.Rows[i].Cells[0].Value);
            using (var db = new ManagementDbContext())
            {
              var user =   db.Users.Find(index);
                db.Users.Remove(user);
                db.SaveChangesAsync();
                MessageBox.Show("删除成功");
            }
            
        }

        private void RegistrerUI_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“managementDataSet.UserT”中。您可以根据需要移动或删除它。
         

        }
    }
}
