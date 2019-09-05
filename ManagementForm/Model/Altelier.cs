using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{   [Table("Altelier")]
   public class Altelier
    {   
        [Key]
        public long Id { get; set; }

        public long department_id { get; set; }

        public string alterlier_name { get; set; }

        public double? alterlier_propotion { get; set; }

    }
}
