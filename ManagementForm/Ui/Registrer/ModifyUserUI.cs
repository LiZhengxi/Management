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
    public partial class ModifyUserUI : Form
    {
        long id;
        string username;
        string password;
        int authority;
        public ModifyUserUI(long id, string username, string password, int authority)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            this.password = password;
            this.authority = authority;
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

                    if (registrerController.ModifyUser(id, username, password, authority)==1)
                    {
                        MessageBox.Show("修改成功");
                        RegistrerUI ower = (RegistrerUI)this.Owner;
                        ower.RenewData();
                    }
                    else
                    {
                        MessageBox.Show("无法修改该用户,存在同名用户");
                    }

                }
                }
            

        }

        private void AddNewUserUI_Load(object sender, EventArgs e)
        {   // Set the defaut combobox select item
            comboBoxAuthority.SelectedIndex = 0;
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            comboBoxAuthority.SelectedIndex = authority;

        }
    }
}
