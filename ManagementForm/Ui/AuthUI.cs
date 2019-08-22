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
        const string databaseStatus = "数据库状态:";
        ManagementDbContext db = new ManagementDbContext();
        AuthController auth = new AuthController();

        MainUI mainUI = new MainUI();
        

        DatabaseController databaseController = new DatabaseController();
        public AuthUI()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            int result = auth.Login(username, password);


            if (result == 0)
            {
                MessageBox.Show("账户或密码错误");
            }
            else if (result == 1)
            {
                this.Hide();
                mainUI.Show();

            }
        }

        private void LinkLabelDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DatabaseUI databaseUI = new DatabaseUI();
            databaseUI.Owner = this;
            databaseUI.ShowDialog();
        }

        private void buttonTest_Click_Load(object sender, EventArgs e)
        {
            loadAsynAsync();
        }

        public async Task loadAsynAsync()
        {
            int status = 0;
            toolStripStatusLabelDatabaseStatus.Text = databaseStatus;
            status = await databaseController.databaseTestAsync();
            toolStripStatusLabelDatabaseStatus.Text =  (status == 1) ? databaseStatus + "已连接" : databaseStatus + "未连接";
        }
    }
}
