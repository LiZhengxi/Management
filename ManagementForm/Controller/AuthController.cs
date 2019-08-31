using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementForm.Model;
using System.Data.Entity;
namespace ManagementForm.Controller
{

    public class AuthController
    {
        ManagementDbContext db = new ManagementDbContext();

        public IQueryable<object> GetAllUsers( long ?userid, int ?authority , string username)
        {
            var data = (from u in db.Users
                        where ((userid==null)||u.Id ==userid) && ((authority==null)||u.Authority == authority)&&((username)==""||u.Username == username)
                        select new
                        {
                            userid = u.Id, 
                            username = u.Username,
                            authority = (u.Authority ==0)?"Admin":(u.Authority==1)?"Finance":"Normal User"// TODO: change to chinese
                        });
            return data;
        }

        //TODO change to return the userid
        public int Login(string username, string password)
        {
            int count =0;

            var user = db.Users.Where(p => p.Username == username && p.Password == password).FirstOrDefault();

            if(user != null)
            {
                Comon.UserId = user.Id;
                Comon.Authority = user.Authority;
                count = 1;
            }
          
            return count;
        }

        public long AddOrUpdateUser(User user)
        {
            long retour = 0;
            if (user != null)
            {
                User userToCreateOrUpdate = null;

                userToCreateOrUpdate = (user.Id > 0) ? db.Users.Find(user.Id) : db.Users.Create();
                userToCreateOrUpdate.Username = user.Username;
                userToCreateOrUpdate.Password = user.Password;
                userToCreateOrUpdate.Authority = user.Authority;

                db.Entry(userToCreateOrUpdate).State = (user.Id > 0) ? EntityState.Modified : EntityState.Added;
                db.SaveChanges();//TODO: async
                retour = userToCreateOrUpdate.Id;
            }
         
            return retour;
        }

        public long RemoveUser(long userId)
        {
            long retour = 0;
            if (userId>0)
            {
                User u = db.Users.Find(userId);
                db.Users.Remove(u);

                db.SaveChanges();
                retour = u.Id;
            }
            
            return retour;
        }
    }
}
