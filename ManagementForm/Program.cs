using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementForm.Ui;

namespace ManagementForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Juste for test , for release version: AuthUi
            Application.Run(new MainUI());
           //Application.Run(new AddNewDepartmentUI());
        }
    }
}
