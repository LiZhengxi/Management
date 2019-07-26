using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Model
{
    [Table("User")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        public long? CreatBy { get; set; }

        public DateTime? CreatTime { get; set; }

        public long? UpdateBy { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int? Authority { get; set; }

    }
}
