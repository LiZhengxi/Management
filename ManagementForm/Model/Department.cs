using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{   
    [Table("Department")]
    public class Department
    {
       [Key]
       [Column("id")]
       public  long Id { get; set; }
        
       public string department_name { get; set; }

        public bool isWorkshop { get; set; }
    }
}
