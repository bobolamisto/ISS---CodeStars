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
                new Conference {Id=1, Name="Conferinta1",StartDate=new DateTime(2017,10,3,10,3,40), EndDate= new DateTime(2017,12,4,20,40,20), AbstractDeadline=new DateTime(2017,12,4,20,40,20),FullPaperDeadline=new DateTime(2017,12,4,20,40,20), Domain="Science"},
                new Conference {Id=2, Name="Conferinta2",StartDate=new DateTime(2016,9,3,10,4,30), EndDate= new DateTime(2017,3,4,20,20,20),AbstractDeadline= new DateTime(2017,3,4,20,20,20),FullPaperDeadline= new DateTime(2017,3,4,20,20,20), Domain="IT"}
            };

            var participations = new User_Conference[]
            {
                new User_Conference{Id=1,UserId=1,ConferenceId=1,Role=UserRole.Chair},
                new User_Conference{Id=2,UserId=1,ConferenceId=2,Role=UserRole.Speaker},
                new User_Conference{Id=3,UserId=2,ConferenceId=1,Role=UserRole.Speaker},
                new User_Conference{Id=4,UserId=2,ConferenceId=2,Role=UserRole.Speaker}
            };

            var tickets = new Ticket[]
            {
                new Ticket{Id=1,Price=30.5f,ParticipationId=2},
                new Ticket{Id=2,Price=500f,ParticipationId=1},
                new Ticket{Id=3,Price=30.5f,ParticipationId=3},
                new Ticket{Id=4,Price=30.5f,ParticipationId=4},
            };

            var proposals = new Proposal[]
            {
                new Proposal{Id=1,Title="Proposal1",Subject="Subject1",Abstract="url",FullPaper="url",Keywords="k1,k2",ParticipationId=2},
                new Proposal{Id=2,Title="Proposal2",Subject="Subject2",Abstract="url",FullPaper="url",Keywords="k3,k4",ParticipationId=3}
            };

            var reviews = new Review[]
            {
                new Review{Id=1,Mark=Mark.BorderlinePaper,ReviewerId=1,ProposalId=1},
                new Review{Id=2,Mark=Mark.Accept,ReviewerId=1,ProposalId=2}
            };

            foreach (var p in participations)
                users[0].ConferenceParticipations.Add(p);

            context.Users.AddOrUpdate(users);
            context.Conferences.AddOrUpdate(conferences);
            context.ConferenceParticipations.AddOrUpdate(participations);
            context.Tickets.AddOrUpdate(tickets);
            context.Proposals.AddOrUpdate(proposals);
            context.Reviews.AddOrUpdate(reviews);
        }
    }
}
