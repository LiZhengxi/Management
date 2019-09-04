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
            if (revenue != null)
            {
                // Bind data 
                textBoxRevenueNumber.Text = Convert.ToString(Comon.GetPropertyValue(revenue, "number"));
                comboBoxMonth.SelectedValue = Comon.GetPropertyValue(revenue, "month");
                comboBoxYear.SelectedValue = Comon.GetPropertyValue(revenue, "year");
            }
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
                RevenueUI ower = (RevenueUI)this.Owner;
                ower.RenewDataAsync();
            }
            else
            {
                message = "修改失败";
            }
            MessageBox.Show(message);
        }
    }
}
