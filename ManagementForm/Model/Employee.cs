using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public long id { get; set; }

        public long altelier_id { get; set; }

        public string employee_name { get; set; }

        public bool ?haveDorm { get; set; }

        public bool ?haveSeniorityPay { get; set; }

        public bool ?havePaySocialSecurity { get; set; }

        public bool ?isTeamLeader { get; set; }
    }
}
