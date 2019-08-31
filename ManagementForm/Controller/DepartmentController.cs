using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{
    public class DepartmentController
    {
        ManagementDbContext db = new ManagementDbContext();

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


        public IQueryable<object> GetAllDepartment(long ?Id, string department_name)
        {
            var data = (from d in db.Departments
                        where (Id==null ||d.Id ==Id)&&(department_name==""||d.department_name==department_name)
                        select d
                        );
            return data;
        }

        public long AddOrUpdateDepartment(Department department)
        {
            long retour = 0;
            if (department != null)
            {
                Department departmentToUpdateOrSave = null;
                departmentToUpdateOrSave = (department.Id != 0) ? db.Departments.Find(department.Id) : db.Departments.Create();
                departmentToUpdateOrSave.department_name = department.department_name;
                db.Entry(departmentToUpdateOrSave).State = (department.Id != 0) ? EntityState.Modified : EntityState.Added;
                db.SaveChanges();
                retour = departmentToUpdateOrSave.Id;
            }

            return retour;
        }

        public long RemoveDepartment(long departmentId)
        {
            long retour = 0;
            if (departmentId != 0)
            {
                var department = db.Departments.Find(departmentId);
                db.Departments.Remove(department);
              
                db.SaveChanges();
                retour = department.Id;
            }
            return retour;
        }
    }
}
