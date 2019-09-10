using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace ManagementForm.Model
{
    [Table("Department_Altelier")]
    public class DepartmentAltelier
    {   [Key]
        public long id { get; set; }

        public long department_id { get; set; }

        public long altelier_id { get; set; }
    }
}