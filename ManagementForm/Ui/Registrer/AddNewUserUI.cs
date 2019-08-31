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
    public partial class AddNewUserUI : Form
    {
        
        public AddNewUserUI()
        {
            InitializeComponent();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonRegistrer_Click(object sender, EventArgs e)
        {
            RegistrerController registrerController = new RegistrerController();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            int authority = comboBoxAuthority.SelectedIndex;
            // TODO change the length of username and password when release
            if (textBoxUsername.Text.Length<2)
            {
                MessageBox.Show("账户过短");
            }
            else
            {
                if(textBoxPassword.Text.Length<4)
                {
                    MessageBox.Show("密码过短");
                }
                else
                {


                   if( registrerController.Registrer(username, password, authority) == 1)
                    {
                        MessageBox.Show("加入成功");
                        RegistrerUI ower = (RegistrerUI)this.Owner;
                        ower.RenewDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("该用户已存在");
                    }
                    
                    }
                }
            

        }

        private void AddNewUserUI_Load(object sender, EventArgs e)
        {   // Set the defaut combobox select item
            comboBoxAuthority.SelectedIndex = 0;

        }
    }
}
