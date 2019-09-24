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
        AuthController authController = new AuthController();
        long userId;
  
        public AddNewUserUI(long userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonRegistrer_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            int authority = comboBoxAuthority.SelectedIndex;

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
                    user.Id = userId;
                    user.Username = username;
                    user.Password = password;
                    user.Authority = authority;

                    if (authController.AddOrUpdateUser(user) > 0)
                    {
                        string message = "";
                        message = (userId > 0)?"修改成功" : "添加成功";
                        MessageBox.Show(message);
                        RegistrerUI ower = (RegistrerUI)this.Owner;
                        ower.RenewDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("加入失败，数据库内可能已存在相同的用户名");
                    }
                    }
                }
        }

        private void AddNewUserUI_Load(object sender, EventArgs e)
        {   // Set the defaut combobox select item
             comboBoxAuthority.SelectedIndex = 0;
            if (userId >0 )
            {
                buttonRegistrer.Text = "注册";
                User user = authController.GetUserById(userId);
                if(user != null)
                {
                    textBoxUsername.Text = user.Username.Trim();
               
                    comboBoxAuthority.SelectedIndex = user.Authority.HasValue ? user.Authority.Value : 0;
                    buttonRegistrer.Text = "修改";
                }
            }
        }
    }
}
