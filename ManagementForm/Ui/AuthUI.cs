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
    public partial class AuthUI : Form
    {
        ManagementDbContext db = new ManagementDbContext();
        AuthController auth = new AuthController();

        MainUI mainUI = new MainUI();
        DatabaseUI databaseUI = new DatabaseUI();
        public AuthUI()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        { 
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            int result =  auth.Login(username, password);


            if (result == 0)
            {
                MessageBox.Show("账户或密码错误");
            }
            else if(result== 1) {
                this.Hide();
                mainUI.Show();

            }
        }

        private void LinkLabelDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            databaseUI.ShowDialog();
        }
    }
}
