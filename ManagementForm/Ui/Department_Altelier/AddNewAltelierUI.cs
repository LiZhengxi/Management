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
        AltelierController altelierController = new AltelierController();

        public AddNewAltelierUI()
        {
            InitializeComponent();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string altelierName = textBoxAltelierName.Text;
            // Convert % to 0.01
            double altelierPropotion = Convert.ToDouble(numericUpDownPropotion.Value) * 0.01;
            Altelier altelier = new Altelier();

            if(altelierName!=""&& altelierPropotion != null)
            {
                string message = "";
                altelier.Id = 0;
                altelier.alterlier_name = altelierName;
                altelier.alterlier_propotion = altelierPropotion;
                altelier.Id = altelierController.AddOrUpdateAltelier(altelier);
                if (altelier.Id > 0)
                {
                    message = "加入成功";
                    Comon.AltelierToAdd.Add(altelier);
                }
                else
                {
                    message = "加入失败";
                }
              
            }
         


           




        }
    }
}
