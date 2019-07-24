using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementForm.Model;
namespace ManagementForm.Controller
{

    public class AuthController
    {
        ManagementDbContext db = new ManagementDbContext();

        public int Login (string username, string password)
        {
            int count;

            var result = (
               from user in db.Users
               where user.Username == username && user.Password == password
               select user).ToList();

            if(result is null || result.Count==0)
            {
                count = 0;
            }
            else
            {
                Comon.UserId = result[0].Id;
                Comon.Authority = result[0].Authority;
                count = result.Count;
            }
            return count;
        }
    }
}
