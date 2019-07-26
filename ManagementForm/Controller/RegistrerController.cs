using ManagementForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{
    public class RegistrerController
    {
        public int Registrer(string username, string password, int authority)
        {
            int retour = 0;
            using (var db = new ManagementDbContext())
            {
                var result = (from u in db.Users
                              where u.Username == username
                              select u.Id).FirstOrDefault();

                if (result == 0)
                {
                    var user = new User
                    {
                        CreatBy = Comon.UserId,
                        CreatTime = DateTime.Now,
                        Username = username,
                        Password = password,
                        //TODO: Change a more solide methode to get the authority
                        Authority = authority
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    retour = 1;
                }
                else
                {
                    retour = 0;
                }
            }
            return retour;
        }


        public int ModifyUser(long id,string username, string password, int authority)
        {
            int retour = 0;
            using (var db = new ManagementDbContext())
            {
                var result = (from u in db.Users
                              where u.Username == username
                              select u.Id).FirstOrDefault();

                if (result == 0)
                {
                   
                 
                        var user = db.Users.Find(id);
                        user.Username = username;
                        user.Password = password;
                        user.Authority = authority;
                        user.UpdateBy = Comon.UserId;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                        retour = 1;
                    
                }
            }
            return retour;
        }
        public List<User> GetAllUser()
        {
            var result = new List<User>();

            using (var db = new ManagementDbContext())
            {
                 result = (from user in db.Users
                            select user).ToList();

            }
            return result;
        }

    }
    
    
}
