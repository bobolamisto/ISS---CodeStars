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
                new User { Id = 1, Username = "alina", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Alina", LastName = "Toader", Email = "bogdanvorobet@gmail.com", WebPage = "alinatoader.wordpress.com", Admin = true,Validation=AccountState.Validated },
                new User { Id = 2, Username = "bogdan", Password = "C0797F6426DF677E3A720E208EF458CE", FirstName = "Bogdan", LastName = "Vorobet", Email = "bogdanvorobet@gmail.com", WebPage = "bogdanvorobet.wordpress.com", Admin = true,Validation=AccountState.Validated },
                new User { Id = 3, Username = "andrea", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Andrea", LastName = "Major", Email = "bogdanvorobet@gmail.com", WebPage = "andreamajor.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 4, Username = "oana", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Oana", LastName = "Jisa", Email = "bogdanvorobet@gmail.com", WebPage = "oanajisa.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 5, Username= "claudiu", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Claudiu", LastName = "Ursuta", Email = "bogdanvorobet@gmail.com", WebPage = "claudiursuta.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 6, Username= "guntter", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Guntter", LastName = "Gotha", Email = "bogdanvorobet@gmail.com", WebPage = "gunttergotha.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 7, Username = "ella", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Ella", LastName = "Cioca", Email = "bogdanvorobet@gmail.com", WebPage = "ellacioca.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 8, Username = "raluca", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Raluca", LastName = "Manea", Email = "bogdanvorobet@gmail.com", WebPage = "ralucamanea.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 9, Username = "test1", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Ana", LastName = "Pop", Email = "bogdanvorobet@gmail.com", WebPage = "anapop.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 10, Username = "test2", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Maria", LastName = "Ionescu", Email = "bogdanvorobet@gmail.com", WebPage = "mariaionescu.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 11, Username = "test3", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Elena", LastName = "Popa", Email = "bogdanvorobet@gmail.com", WebPage = "elenapopa.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 12, Username = "test4", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Marta", LastName = "Gurau", Email = "bogdanvorobet@gmail.com", WebPage = "martagurau.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 13, Username = "test5", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Laura", LastName = "Ionescu", Email = "bogdanvorobet@gmail.com", WebPage = "lauraionescu.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 14, Username = "test6", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Alex", LastName = "Pop", Email = "bogdanvorobet@gmail.com", WebPage = "alexpop.wordpress.com", Admin = false,Validation=AccountState.Validated },
                new User { Id = 9, Username = "test1wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Ana", LastName = "Pop", Email = "bogdanvorobet@gmail.com", WebPage = "anapop.wordpress.com", Admin = false,Validation=AccountState.Waiting },
                new User { Id = 10, Username = "test2wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Maria", LastName = "Ionescu", Email = "bogdanvorobet@gmail.com", WebPage = "mariaionescu.wordpress.com", Admin = false,Validation=AccountState.Waiting },
                new User { Id = 11, Username = "test3wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Elena", LastName = "Popa", Email = "bogdanvorobet@gmail.com", WebPage = "elenapopa.wordpress.com", Admin = false,Validation=AccountState.Waiting },
                new User { Id = 12, Username = "test4wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Marta", LastName = "Gurau", Email = "bogdanvorobet@gmail.com", WebPage = "martagurau.wordpress.com", Admin = false,Validation=AccountState.Waiting },
                new User { Id = 13, Username = "test5wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Laura", LastName = "Ionescu", Email = "bogdanvorobet@gmail.com", WebPage = "lauraionescu.wordpress.com", Admin = false,Validation=AccountState.Waiting },
                new User { Id = 14, Username = "test6wait", Password = "098F6BCD4621D373CADE4E832627B4F6", FirstName = "Alex", LastName = "Pop", Email = "bogdanvorobet@gmail.com", WebPage = "alexpop.wordpress.com", Admin = false,Validation=AccountState.Waiting },
             };

            var conferences = new Conference[]
            {

                new Conference {Id=1, Name="Conferinta1",StartDate=new DateTime(2017,8,1), EndDate= new DateTime(2017,12,5), AbstractDeadline=new DateTime(2017,7,1),FullPaperDeadline=new DateTime(2017,7,5), Domain="IT",Price=550.5f,Edition=1,MainDescription="description1",State=ConferenceState.Accepted},
                new Conference {Id=2, Name="Conferinta2",StartDate=new DateTime(2018,5,23), EndDate= new DateTime(2018,7,23),AbstractDeadline= new DateTime(2017,1,1),FullPaperDeadline= new DateTime(2017,1,2), Domain="Biology",Price=480.7f,Edition=1,MainDescription="description2",State=ConferenceState.Accepted},
                new Conference {Id=3, Name="Conferinta3",StartDate=new DateTime(2019,5,23), EndDate= new DateTime(2019,7,23),AbstractDeadline= new DateTime(2019,1,1),FullPaperDeadline= new DateTime(2019,1,2), Domain="Astronomy",Price=480.7f,Edition=1,MainDescription="description3",State=ConferenceState.Accepted},
                new Conference {Id=4, Name="Conferinta4",StartDate=new DateTime(2020,8,1), EndDate= new DateTime(2020,12,5), AbstractDeadline=new DateTime(2020,7,1),FullPaperDeadline=new DateTime(2020,7,5), Domain="IT",Price=550.5f,Edition=1,MainDescription="description14",State=ConferenceState.Accepted},
                new Conference {Id=5, Name="Conferinta5",StartDate=new DateTime(2021,5,23), EndDate= new DateTime(2021,7,23),AbstractDeadline= new DateTime(2021,1,1),FullPaperDeadline= new DateTime(2021,1,2), Domain="Biology",Price=480.7f,Edition=1,MainDescription="description5",State=ConferenceState.Accepted},
                new Conference {Id=6, Name="Conferinta6",StartDate=new DateTime(2022,5,23), EndDate= new DateTime(2022,7,23),AbstractDeadline= new DateTime(2022,1,1),FullPaperDeadline= new DateTime(2022,1,2), Domain="Astronomy",Price=480.7f,Edition=1,MainDescription="description6",State=ConferenceState.Accepted},
                new Conference {Id=7, Name="Conferinta7",StartDate=new DateTime(2023,8,1), EndDate= new DateTime(2023,12,5), AbstractDeadline=new DateTime(2023,7,1),FullPaperDeadline=new DateTime(2023,7,5), Domain="IT",Price=550.5f,Edition=1,MainDescription="description7",State=ConferenceState.Accepted},
                new Conference {Id=8, Name="Conferinta8",StartDate=new DateTime(2024,5,23), EndDate= new DateTime(2024,7,23),AbstractDeadline= new DateTime(2024,1,1),FullPaperDeadline= new DateTime(2024,1,2), Domain="Biology",Price=480.7f,Edition=1,MainDescription="description8",State=ConferenceState.Accepted},
                new Conference {Id=9, Name="Conferinta9",StartDate=new DateTime(2025,5,23), EndDate= new DateTime(2025,7,23),AbstractDeadline= new DateTime(2025,1,1),FullPaperDeadline= new DateTime(2025,1,2), Domain="Astronomy",Price=480.7f,Edition=1,MainDescription="description9",State=ConferenceState.Proposed},
                new Conference {Id=10, Name="Conferinta8",StartDate=new DateTime(2008,5,23), EndDate= new DateTime(2008,7,23),AbstractDeadline= new DateTime(2008,1,1),FullPaperDeadline= new DateTime(2008,1,2), Domain="Biology",Price=480.7f,Edition=1,MainDescription="description8",State=ConferenceState.Accepted},

            };

            var participations = new User_Conference[]
            {
                new User_Conference{Id=1,UserId=1,ConferenceId=1,Role=UserRole.Chair},
                new User_Conference{Id=2,UserId=2,ConferenceId=1,Role=UserRole.CoChair},
                new User_Conference{Id=3,UserId=3,ConferenceId=1,Role=UserRole.CoChair},
                new User_Conference{Id=4,UserId=4,ConferenceId=1,Role=UserRole.CoChair},
                new User_Conference{Id=5,UserId=5,ConferenceId=1,Role=UserRole.Reviewer},
                new User_Conference{Id=6,UserId=6,ConferenceId=1,Role=UserRole.Reviewer},
                new User_Conference{Id=7,UserId=7,ConferenceId=1,Role=UserRole.Reviewer},
                new User_Conference{Id=8,UserId=8,ConferenceId=1,Role=UserRole.Reviewer},
                new User_Conference{Id=9,UserId=9,ConferenceId=1,Role=UserRole.Listener},
                new User_Conference{Id=10,UserId=10,ConferenceId=1,Role=UserRole.Listener},
                new User_Conference{Id=11,UserId=11,ConferenceId=1,Role=UserRole.Listener},
                new User_Conference{Id=12,UserId=12,ConferenceId=1,Role=UserRole.Listener},
                new User_Conference{Id=13,UserId=13,ConferenceId=1,Role=UserRole.Listener},
                new User_Conference{Id=14,UserId=14,ConferenceId=1,Role=UserRole.Listener},

                new User_Conference{Id=15,UserId=1,ConferenceId=2,Role=UserRole.CoChair},
                new User_Conference{Id=16,UserId=1,ConferenceId=3,Role=UserRole.CoChair},
                new User_Conference{Id=17,UserId=1,ConferenceId=4,Role=UserRole.Reviewer},
                new User_Conference{Id=18,UserId=1,ConferenceId=5,Role=UserRole.Listener},

                new User_Conference{Id=19,UserId=2,ConferenceId=2,Role=UserRole.Chair},
                new User_Conference{Id=20,UserId=3,ConferenceId=3,Role=UserRole.Chair},
                new User_Conference{Id=21,UserId=4,ConferenceId=4,Role=UserRole.Chair},
                new User_Conference{Id=22,UserId=5,ConferenceId=5,Role=UserRole.Chair},
                new User_Conference{Id=23,UserId=6,ConferenceId=6,Role=UserRole.Chair},
                new User_Conference{Id=24,UserId=7,ConferenceId=7,Role=UserRole.Chair},
                new User_Conference{Id=25,UserId=8,ConferenceId=8,Role=UserRole.Chair},
                new User_Conference{Id=26,UserId=8,ConferenceId=9,Role=UserRole.Chair},
            };

            var proposals = new Proposal[]
            {
                new Proposal{Id=1,Title="Proposal1",Subject="Subject1",Abstract="url abstract 1",FullPaper="url paper 1",Keywords="k1,k2,k3,k4",ParticipationId=14, ProposalState = ProposalState.Accepted},
                new Proposal{Id=2,Title="Proposal2",Subject="Subject2",Abstract="url abstract 2",FullPaper="url paper 2",Keywords="k5,k6",ParticipationId=13, ProposalState = ProposalState.Declined},
                new Proposal{Id=3,Title="Proposal3",Subject="Subject3",Abstract="url abstract 3",FullPaper="url paper 3",Keywords="k7,k8",ParticipationId=12, ProposalState = ProposalState.Pending},
                new Proposal{Id=4,Title="Proposal4",Subject="Subject4",Abstract="url abstract 4",FullPaper="url paper 4",Keywords="k9,k10,k11,k12",ParticipationId=11, ProposalState = ProposalState.Pending},
                new Proposal{Id=5,Title="Proposal5",Subject="Subject5",Abstract="url abstract 5",FullPaper="url paper 5",Keywords="k9,k10,k11,k12",ParticipationId=10, ProposalState = ProposalState.Pending},
                new Proposal{Id=6,Title="Proposal6",Subject="Subject6",Abstract="url abstract 6",FullPaper="url paper 6",Keywords="k9,k10,k11,k12",ParticipationId=9, ProposalState = ProposalState.Pending},
            };

            var reviews = new Review[]
            {
                new Review{Id=1,Mark=Mark.BorderlinePaper,ReviewerId=8,ProposalId=1,Recommendation="recomm1"},
                new Review{Id=2,Mark=Mark.Accept,ReviewerId=7,ProposalId=1,Recommendation="recomm2"},
                new Review{Id=3,Mark=Mark.StrongAccept,ReviewerId=6,ProposalId=1,Recommendation="recomm3"},
                new Review{Id=4,Mark=Mark.WeakAccept,ReviewerId=5,ProposalId=1,Recommendation="recomm4"},

                new Review{Id=5,Mark=Mark.Reject,ReviewerId=5,ProposalId=2,Recommendation="recomm5"},
                new Review{Id=6,Mark=Mark.StrongReject,ReviewerId=6,ProposalId=2,Recommendation="recomm6"},

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
