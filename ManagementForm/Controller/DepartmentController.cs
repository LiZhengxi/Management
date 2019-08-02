using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{
    public class DepartmentController
    {
        public List<Altelier> alteliers = new List<Altelier>();

        public int addAltelier(Altelier altelier)
        {
            int retour = 1;
            foreach (Altelier a in alteliers)
            {
            if(a.alterlier_name == altelier.alterlier_name)
                {
                    retour = 0;
                    break;
                }
          
            }
            if(retour == 1)
            {
                alteliers.Add(altelier);
            }
            return retour;
        }

        public  List<Altelier> getAlteliers()
        {
            return alteliers;
        }


    }
}
