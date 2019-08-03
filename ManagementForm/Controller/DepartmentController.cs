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
            }
            return retour;
        }

        public  List<Altelier> getAlteliers()
        {
            return alteliers;
        }

        public Altelier findAltelier(long Id)
        {
            Altelier altelier;
            using (var db = new ManagementDbContext())
            {
               altelier =  db.Alteliers.Find(Id);
            }
            return altelier;
        }
        
        public int removeAltelier(long Id)
        {
            int retour = 0;
            using(var db = new ManagementDbContext())
            {
                try
                {
                    var altelier = db.Alteliers.Find(Id);
                        db.Alteliers.Remove(altelier);
                        db.SaveChangesAsync();
                    retour = 1;
                }
                catch( Exception e)
                {
                    retour = 0;
                }
            }

            return retour;
        }
    }
}
