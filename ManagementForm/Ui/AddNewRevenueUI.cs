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
    public partial class AddNewRevenueUI : Form
    {
        RevenueController revenueController = new RevenueController();
        long revenueId;

        public AddNewRevenueUI(long revenueId)
        {
            InitializeComponent();
            this.revenueId = revenueId;
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddNewRevenueUI_Load(object sender, EventArgs e)
        {
            comboBoxMonth.DataSource = Comon.GetMonths();
            comboBoxMonth.DisplayMember = "label";
            comboBoxMonth.ValueMember = "value";
            comboBoxYear.DataSource = Comon.GetYears();
            comboBoxYear.DisplayMember = "label";
            comboBoxYear.ValueMember = "value";

            var revenue = revenueController.GetAllRevenue(revenueId, null, null).FirstOrDefault();
            // Bind data 
            textBoxRevenueNumber.Text = Convert.ToString(Comon.GetPropertyValue(revenue, "number"));
            comboBoxMonth.SelectedValue = Comon.GetPropertyValue(revenue, "month");
            comboBoxYear.SelectedValue = Comon.GetPropertyValue(revenue, "year");


            //private void ButtonRegistrer_Click(object sender, EventArgs e)
            //{
            //    Revenue revenue = new Revenue();
            //    string year = textbox.Text;
            //    string month = textBoxPassword.Text;
            //    long number = comboBoxMonth.SelectedIndex;


            //        if(textBoxPassword.Text.Length<4)
            //        {
            //            MessageBox.Show("密码过短");
            //        }
            //        else
            //        {
            //            user.Id = userId;
            //            user.Username = username;
            //            user.Password = password;
            //            user.Authority = authority;

            //            if (authController.AddOrUpdateUser(user) > 0)
            //            {
            //                string message = "";
            //                message = (userId > 0)?"修改成功" : "添加成功";
            //                MessageBox.Show(message);
            //                RegistrerUI ower = (RegistrerUI)this.Owner;
            //                ower.RenewDataAsync();
            //            }
            //            else
            //            {
            //                MessageBox.Show("加入失败，数据库内可能已存在相同的用户名");
            //            }
            //            }

            //}

            //private void AddNewUserUI_Load(object sender, EventArgs e)
            //{   // Set the defaut combobox select item
            //     comboBoxMonth.SelectedIndex = 0;
            //    if (userId >0 )
            //    {
            //        buttonRegistrer.Text = "注册";
            //        User user = authController.GetUserById(userId);
            //        if(user != null)
            //        {
            //            textBoxRevenueNumber.Text = user.Username.Trim();
            //            textBoxPassword.Text = user.Password.Trim();
            //            comboBoxMonth.SelectedIndex = user.Authority.HasValue ? user.Authority.Value : 0;
            //            buttonRegistrer.Text = "修改";
            //        }
            //    }
            //}
        }

        private void buttonRegistrer_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(comboBoxYear.SelectedValue);
            int month = Convert.ToInt16(comboBoxMonth.SelectedValue);
            long revenueNumber = Convert.ToInt64(textBoxRevenueNumber.Text);
            string message = "";
            Revenue r = new Revenue();
            r.year = year;
            r.month = month;
            r.number = revenueNumber;
            r.id = revenueId;
            if(revenueController.AddOrUpdateRevenue(r) > 0)
            {
                message = (revenueId==0) ? "加入成功" : "修改成功";
            }
            else
            {
                message = "修改失败";
            }
        }
    }
}
