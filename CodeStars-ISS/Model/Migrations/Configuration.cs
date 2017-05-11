using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
             var users = new User[] {
                new User { Id = 1, Username = "test", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = true },
                new User { Id = 2, Username = "bogdan", Password = "C0797F6426DF677E3A720E208EF458CE", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = true }
             };

            var conferences = new Conference[]
            {
                new Conference {Id=1, Name="Conferinta1",StartDate=new DateTime(2017,10,3,10,3,40), EndDate= new DateTime(2017,12,4,20,40,20), Domain="Science"},
                new Conference {Id=2, Name="Conferinta2",StartDate=new DateTime(2016,9,3,10,4,30), EndDate= new DateTime(2017,3,4,20,20,20), Domain="IT"}
            };

            var participations = new User_Conference[]
            {
                new User_Conference{Id=1,UserId=1,ConferenceId=1,Role=UserRole.Chair},
                new User_Conference{Id=2,UserId=1,ConferenceId=2,Role=UserRole.Listener}
            };

            foreach (var p in participations)
                users[0].ConferenceParticipations.Add(p);

            context.Users.AddOrUpdate(users);
            context.Conferences.AddOrUpdate(conferences);
            context.ConferenceParticipations.AddOrUpdate(participations);
        }
    }
}
