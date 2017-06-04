using Model.Domain;
using Model.POCOModels;
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
                new User { Id = 1, Username = "test", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = true,Validation=AccountState.Validated },
                new User { Id = 2, Username = "bogdan", Password = "C0797F6426DF677E3A720E208EF458CE", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = true,Validation=AccountState.Validated },
                new User { Id = 3, Username = "test2", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 4, Username = "test3", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 5, Username = "test4", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "test", LastName = "test", Email = "test@test.com", WebPage = "test.com", Admin = false,Validation=AccountState.Validated }
             };

            var conferences = new Conference[]
            {

                new Conference {Id=1, Name="Conferinta1",StartDate=new DateTime(2017,2,1), EndDate= new DateTime(2017,4,5), AbstractDeadline=new DateTime(2017,1,1),FullPaperDeadline=new DateTime(2017,1,5), Domain="IT",Price=55.5f,Edition=2,MainDescription="description1",State=ConferenceState.Accepted},
                new Conference {Id=2, Name="Conferinta2",StartDate=new DateTime(2016,5,23), EndDate= new DateTime(2016,7,23),AbstractDeadline= new DateTime(2016,5,2),FullPaperDeadline= new DateTime(2016,5,3), Domain="IT",Price=56.7f,Edition=1,MainDescription="description2",State=ConferenceState.Accepted}

            };

            var participations = new User_Conference[]
            {
                new User_Conference{Id=1,UserId=1,ConferenceId=1,Role=UserRole.Chair},
                new User_Conference{Id=2,UserId=1,ConferenceId=2,Role=UserRole.Speaker},
                new User_Conference{Id=3,UserId=2,ConferenceId=1,Role=UserRole.Speaker},
                new User_Conference{Id=4,UserId=2,ConferenceId=2,Role=UserRole.Speaker},
                new User_Conference{Id=5,UserId=3,ConferenceId=1,Role=UserRole.CoChair},
                new User_Conference{Id=6,UserId=4,ConferenceId=1,Role=UserRole.CoChair},
                new User_Conference{Id=7,UserId=5,ConferenceId=1,Role=UserRole.Reviewer}
            };

            var proposals = new Proposal[]
            {
                new Proposal{Id=1,Title="Proposal1",Subject="Subject1",Abstract="url",FullPaper="url",Keywords="k1,k2",ParticipationId=2},
                new Proposal{Id=2,Title="Proposal2",Subject="Subject2",Abstract="url",FullPaper="url",Keywords="k3,k4",ParticipationId=3},
                new Proposal{Id=3,Title="Proposal3",Subject="Subject2",Abstract="url",FullPaper="url",Keywords="k3,k4",ParticipationId=5},
                new Proposal{Id=4,Title="Proposal4",Subject="Subject2",Abstract="url",FullPaper="url",Keywords="k3,k4",ParticipationId=7}
            };

            var reviews = new Review[]
            {
                new Review{Id=1,Mark=Mark.BorderlinePaper,ReviewerId=1,ProposalId=1,Recommendation=""},
                new Review{Id=2,Mark=Mark.Accept,ReviewerId=1,ProposalId=2,Recommendation=""}
            };

            foreach (var p in participations)
                users[0].ConferenceParticipations.Add(p);

            context.Users.AddOrUpdate(users);
            context.Conferences.AddOrUpdate(conferences);
            context.ConferenceParticipations.AddOrUpdate(participations);
            context.Proposals.AddOrUpdate(proposals);
            context.Reviews.AddOrUpdate(reviews);
        }
    }
}
