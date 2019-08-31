using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{

    public class SalaryController
    {
        ManagementDbContext db = new ManagementDbContext();
        public IQueryable<object> GetAllSalary()
        {
                var data = (from s in db.Salaries
                           select new
                           {
                               id = s.id,
                               year = s.year,
                               month = s.month,
                               employeeId = s.employee_id,
                               employee = (from e in db.Employees
                                           where e.id == s.employee_id
                                           select new
                                           {
                                               e.employee_name
                                           }).FirstOrDefault(),
                               revenue = (from r in db.Revenues
                                          where r.month == s.month && r.year == s.year
                                          select new
                                          {
                                              r.number
                                          }).FirstOrDefault()
                           });
               
                return data;
           
       
        }
    }
}
