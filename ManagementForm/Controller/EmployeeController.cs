using ManagementForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ManagementForm.Controller
{
    public class EmployeeController
    {
        ManagementDbContext db = new ManagementDbContext();
 
        public IQueryable<object> GetAllEmployee(long ?departmentId,long ?altelierId, long ?employeeId)
        {
            var data = (from e in db.Employees
                        join a in db.Alteliers on e.altelier_id equals a.Id
                        join d in db.Departments on a.department_id equals d.Id
                        where (departmentId == null || d.Id == departmentId) && (altelierId == null || a.Id == altelierId) && (employeeId == null || e.id == employeeId)
                        select new
                        {
                            Id = e.id,
                            EmployeeName = e.employee_name,
                            AltelierName = a.alterlier_name,
                            AlterlierIsWorkshop = a.isWorkshop,
                            AltelierPropotion = a.alterlier_propotion,
                            DepartmentName = d.department_name
                         }
                );
            return data;
        }

        public long AddorUpdateEmployee(Employee employee)
        {
            long retour = 0;
            if(employee != null)
            {
                Employee employeeToSaveOrUpdate = null;
                employeeToSaveOrUpdate = (employee.id >0 ) ? db.Employees.Find(employee.id) : db.Employees.Create();
                employeeToSaveOrUpdate.employee_name = employee.employee_name;
                employeeToSaveOrUpdate.altelier_id = employee.altelier_id;
                db.Entry(employeeToSaveOrUpdate).State = (employee.id > 0) ? EntityState.Modified : EntityState.Added;

                db.SaveChanges();
                retour = employeeToSaveOrUpdate.id;
            }


            return retour;
        }

        public long RemoveEmployee(long employeeId)
        {
            long retour = 0;
            if (employeeId > 0)
            {
                Employee employee = db.Employees.Find(employeeId);
                
                db.Employees.Remove(employee);

                db.SaveChanges();
                retour = employee.id;
            }


            return retour;
        }
    }
}
