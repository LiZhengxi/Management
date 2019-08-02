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
    public partial class AddNewAltelierUI : Form
    {
        
        DepartmentController departmentController;

        public AddNewAltelierUI(DepartmentController departmentController)
        {
            InitializeComponent();
      
            this.departmentController = departmentController;
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new ManagementDbContext())
            {
                string altelierName = textBoxAltelierName.Text;
                // Convert % to 0.01
                double altelierPropotion = Convert.ToDouble(numericUpDownPropotion.Value) * 0.01;
                
                    var altelier = new Altelier 
                    {   
                        
                        alterlier_name = altelierName,
                        alterlier_propotion = altelierPropotion,
                        isWorkshop = true
                    };

                if (departmentController.addAltelier(altelier) == 1)
                {
                    AddNewDepartmentUI ower = (AddNewDepartmentUI)this.Owner;
                    ower.renewAltelierList();
                    MessageBox.Show("车间已添加");
                }
                else
                {
                    MessageBox.Show("车间已存在");
                }

            }
          

        }
    }

      
    
}
