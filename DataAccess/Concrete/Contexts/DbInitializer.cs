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

            var persons = new Person[] {
                new Person(){ STATUS=1,CREATEDBY=1,CREATIONDATE=DateTime.Now,ADDRESS="test",EMAIL="test",GENDER=Entities.Enums.Gender.Male,MERNISNO=12345678902,MOBILEPHONE=1234567895,NAME="test",SURNAME="user" },
                new Person(){ STATUS=1,CREATEDBY=1,CREATIONDATE=DateTime.Now,ADDRESS="test",EMAIL="test",GENDER=Entities.Enums.Gender.Male,MERNISNO=12345678902,MOBILEPHONE=1234567895,NAME="test",SURNAME="teacher" },
                new Person(){ STATUS=1,CREATEDBY=1,CREATIONDATE=DateTime.Now,ADDRESS="test",EMAIL="test",GENDER=Entities.Enums.Gender.Male,MERNISNO=12345678902,MOBILEPHONE=1234567895,NAME="test",SURNAME="student" }
            };
            context.Persons.AddRange(persons);

            var users = new User[] {
                new User(){ STATUS=1,USERNAME="ali",PASSWORD="123",CREATEDBY=1,CREATIONDATE=DateTime.Now,PersonId=1 }
            };
            context.Users.AddRange(users);

            var teachers = new Teacher[] {
                new Teacher(){ STATUS=1,CREATEDBY=1,CREATIONDATE=DateTime.Now,PersonId=2 }
            };
            context.Teachers.AddRange(teachers);

            var students = new Student[] {
                new Student(){ STATUS=1,CREATEDBY=1,CREATIONDATE=DateTime.Now,PersonId=3 }
            };
            context.Students.AddRange(students);

            context.SaveChanges();
        }
    }
}
