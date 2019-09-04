using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementForm.Model;
using System.Data.Entity;
namespace ManagementForm.Controller
{

    public class RevenueController
    {
        ManagementDbContext db = new ManagementDbContext();

        public IQueryable<object> GetAllRevenue( long ?id,int ?year, int ?month )
        {
            var data = (from r in db.Revenues
                        where ((year == null) || r.year == year) && ((month == null) || r.month == month)&&((id==null)||r.id==id)
                        select new
                        {
                            r.id,
                            r.year,
                            r.month,
                            r.number
                        });
            return data;
        }

        public long AddOrUpdateRevenue(Revenue revenue)
        {
            long retour = 0;
            if (revenue != null)
            {
                Revenue revenueToCreateOrUpdate = null;

                revenueToCreateOrUpdate = (revenue.id > 0) ? db.Revenues.Find(revenue.id) : db.Revenues.Create();
                if (db.Revenues.Where(p => p.year == revenue.year&&p.month==revenue.month).FirstOrDefault()!=null&& revenue.id==0)
                {
                    return 0;
                }
                revenueToCreateOrUpdate.year = revenue.year;
                revenueToCreateOrUpdate.month = revenue.month;
                revenueToCreateOrUpdate.number = revenue.number;

                db.Entry(revenueToCreateOrUpdate).State = (revenue.id > 0) ? EntityState.Modified : EntityState.Added;
                db.SaveChanges();//TODO: async
                retour = revenueToCreateOrUpdate.id;
            }
         
            return retour;
        }

        public long RemoveRevenue(long revenueId)
        {
            long retour = 0;
            if (revenueId > 0)
            {
                Revenue u = db.Revenues.Find(revenueId);
                db.Revenues.Remove(u);

                db.SaveChanges();
                retour = u.id;
            }
            
            return retour;
        }
    }
}
