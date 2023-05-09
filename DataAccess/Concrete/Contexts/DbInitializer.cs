using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public static class DbInitializer
    {
        public static void Initilize(WebAPIContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }

            var users = new User[] {
                new User(){ STATUS=1,USERNAME="ali",PASSWORD="123",CREATEDBY=1,CREATIONDATE=DateTime.Now }
            };
            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
