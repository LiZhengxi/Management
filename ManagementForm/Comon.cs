using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm
{
    public static class Comon
    {
        public static int? Authority { get; set; }
        public static long UserId { get; set; }
        public static int DatabaseStaus { get; set; }

        public static string GetAuthority(int? Authority)
        {
            string retour = "";
            switch (Authority)
            {
                case 0: retour = "管理员";
                        break;
                case 1:
                    retour = "财务";
                    break;
                case 2:
                    retour = "文员";
                    break;
                default:
                    break;
            }
            return retour;
        }
    }

}
