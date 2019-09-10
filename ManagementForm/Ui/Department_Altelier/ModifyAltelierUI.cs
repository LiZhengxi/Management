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
using System.Data.Entity;

namespace ManagementForm.Ui
{
    public partial class ModifyAltelierUI : Form
    {

        long Id;
        public ModifyAltelierUI(long Id)
        {
            InitializeComponent();
            this.Id = Id;
        
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //using (var db = new ManagementDbContext())
            //{
            //    DepartmentController departmentController = new DepartmentController();
            //    string altelierName = textBoxAltelierName.Text;
            //    // Convert % to 0.01
            //    double altelierPropotion = Convert.ToDouble(numericUpDownPropotion.Value) * 0.01;

            //    var result = (from a in db.Alteliers
            //                  where a.alterlier_name == altelierName && a.Id != Id && a.department_id == (from a1 in db.Alteliers where a1.Id == Id select a1.department_id).FirstOrDefault()
            //                  select a.Id).FirstOrDefault();
             

            //    if (result == 0)
            //    {
            //        Altelier altelier = departmentController.findAltelier(Id);
            //        altelier.alterlier_name = altelierName;
            //        altelier.alterlier_propotion = altelierPropotion;


            //        db.Entry(altelier).State = EntityState.Modified;
            //        db.SaveChanges();
            //        MessageBox.Show("车间修改成功");

            //    }

            //    else
            //    {
            //        MessageBox.Show("车间已存在,无法修改");
            //    }

            //}
          

        }

        private void ModifyAltelierUI_Load(object sender, EventArgs e)
        {
            DepartmentController departmentController = new DepartmentController();
            Altelier altelier = departmentController.findAltelier(Id);
            textBoxAltelierName.Text = altelier.alterlier_name;
            // Convert 0.00 to %
            numericUpDownPropotion.Value = Convert.ToDecimal(altelier.alterlier_propotion*100);
        }
    }

      
    
}
