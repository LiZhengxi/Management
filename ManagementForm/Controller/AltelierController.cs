using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ManagementForm.Controller
{
    public class AltelierController
    {
        ManagementDbContext db = new ManagementDbContext();

        public IQueryable<object> GetAllAltelier(long? Id, long? department_id)
        {
            var data = (from a in db.Alteliers
                        where ((Id == null) || a.Id == Id) && ((department_id == null) || a.department_id == department_id)
                        select new
                        {
                            AltelierName = a.alterlier_name,
                            AlterPropotion = a.alterlier_propotion,
                            DepartmentName = (from department in db.Departments
                                              where department.Id == a.department_id
                                              select department.department_name).FirstOrDefault()
                           
                        });
            return data;
        }

        public long AddOrUpdateAltelier(Altelier altelier)
        {
            long retour = 0;
          
            if(altelier != null){
                Altelier altelierToUpdateOrSave = null;
                altelierToUpdateOrSave = (altelier.Id > 0) ? db.Alteliers.Find(altelier.Id) : db.Alteliers.Create();
                altelierToUpdateOrSave.alterlier_name = altelier.alterlier_name;
                altelierToUpdateOrSave.alterlier_propotion = altelier.alterlier_propotion;
                altelierToUpdateOrSave.department_id = altelier.department_id;

                db.Entry(altelierToUpdateOrSave).State = (altelier.Id > 0) ? EntityState.Modified : EntityState.Added;

                db.SaveChanges();// TODO: change to asyn
                retour = altelierToUpdateOrSave.Id;
            }
     
            return retour;
        }

        public long RemoveAltelier(long altelierId)
        {
            long retour = 0;
            if (altelierId != 0)
            {
                var altelier = db.Alteliers.Find(altelierId);
                db.Alteliers.Remove(altelier);

                db.SaveChanges();
                retour = altelier.Id;
            }

            return retour;
        }

    }
}
