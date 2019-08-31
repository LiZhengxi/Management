using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public long id { get; set; }

        public long ?createBy { get; set; }

        public long ?updateBy { get; set; }

        public int year { get; set; }

        public int month { get; set; }

        public long employee_id { get; set; }
    }

}
