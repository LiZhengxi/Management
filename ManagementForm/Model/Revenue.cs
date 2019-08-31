using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{
    [Table("Revenue")]
    public class Revenue
    {
        [Key]
        public long id { get; set; }

        public int year { get; set; }

        public int month { get; set; }

        public float number { get; set; }
    }
}
