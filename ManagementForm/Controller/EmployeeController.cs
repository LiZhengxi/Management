using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{
    public class EmployeeController
    {
        ManagementDbContext db = new ManagementDbContext();

        //TODO
        public IQueryable<object> GetAllEmployee(long ?departmentId,long ?altelierId, long ?employeeId)
        {
            var data = ( from e in db.Employees
                         //where ()
                         select e
                );
            return data;
        }

    }
}
