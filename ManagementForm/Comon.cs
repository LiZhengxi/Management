using ManagementForm.Model;
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
        public static List<Altelier> AltelierToAdd{get; set;}

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

        public class list
        {
            public int value
            {
                get;
                set;
            }
            public string label
            {
                get;
                set;
            }
            public list(int value, string label)
            {
                this.value = value;
                this.label = label;
            }
        }

        public static list[] GetMonths()
        {
            list[] months = new list[]
            {
                new list(1,"一月"),
                new list(2,"二月"),
                new list(3,"三月"),
                new list(4,"四月"),
                new list(5,"五月"),
                new list(6,"六月"),
                new list(7,"七月"),
                new list(8,"八月"),
                new list(9,"九月"),
                new list(10,"十月"),
                new list(11,"十一月"),
                new list(12,"十二月")
            };
            return months;
        }

        public static list[] GetYears()
        {
            list[] years = new list[]
            {
                new list(2019,"2019"),
                new list(2020,"2020"),
                new list(2021,"2021"),
                new list(2022,"2022"),
            };
            return years;
        }

        public  static object GetPropertyValue(object obj,string propertyName)
        {
            //returns value of property Name
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }
    }

}
