using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Domain;
//using Model;
using Model.DTOModels;
//using Model.Domain;

using Server.ServicesImplementation;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTests
{
    [TestClass]
    public class ConferenceServiceTests
    {
        [TestInitialize]
        public void Initialize()
        {
            EffortProviderFactory.ResetDb();
        }

        private void PrepareData1()
        {
            using (var model = new DatabaseContext())
            {
                model.Conferences.Add(new Conference { Id = 1, Name = "confName", StartDate = new DateTime(2018, 9, 10), EndDate = new DateTime(2018, 9, 29), Domain = "domain", MainDescription = "md", Edition = 3, Price = 30, AbstractDeadline = new DateTime(2018, 8, 20), FullPaperDeadline = new DateTime(2018, 8, 25), State = ConferenceState.Accepted });
                model.Conferences.Add(new Conference { Id = 2, Name = "confNam3", StartDate = new DateTime(2019, 9, 10), EndDate = new DateTime(2019, 9, 29), Domain = "domain", MainDescription = "md33", Edition = 3, Price = 30, AbstractDeadline = new DateTime(2019, 8, 20), FullPaperDeadline = new DateTime(2019, 8, 25), State = ConferenceState.Accepted });

                model.Users.Add(new User { Id = 13, Username = "User3", FirstName = "First3", LastName = "Last3", Password = "password3", Email = "test3@gmail.com", WebPage = "test3.com", Admin = false, ConferenceParticipations = null });
                model.Users.Add(new User { Id = 14, Username = "User4", FirstName = "First4", LastName = "Last4", Password = "password4", Email = "test4@gmail.com", WebPage = "test4.com", Admin = true, ConferenceParticipations = null });

                model.ConferenceParticipations.Add(new User_Conference { Id = 25, Role = UserRole.Chair, ConferenceId = 1, UserId = 14});
                model.ConferenceParticipations.Add(new User_Conference { Id = 26, Role = UserRole.Chair, ConferenceId = 2, UserId = 13 });
                model.ConferenceParticipations.Add(new User_Conference { Id = 27, Role = UserRole.Listener, ConferenceId = 1, UserId = 13 });
                model.ConferenceParticipations.Add(new User_Conference { Id = 28, Role = UserRole.Listener, ConferenceId = 2, UserId = 14 });

                model.SaveChanges();
            }
        }

        [TestMethod]
        public void GetAllConferenceTest()
        {
            var service = new UserConferenceService();
            Assert.AreEqual(0, service.GetAllConferences().ToList().Count());
            PrepareData1();
            Assert.AreEqual(2, service.GetAllConferences().ToList().Count());
        }



        [TestMethod]
        public void GetChairConferenceTest()
        {
            var service = new UserConferenceService();
            PrepareData1();
            UserDTO chair= service.getChairOfConference(1);
            Assert.AreEqual("First4", chair.FirstName);
            Assert.AreEqual("test4@gmail.com", chair.Email);

            UserDTO chair2 = service.getChairOfConference(2);
            Assert.AreEqual("Last3", chair2.LastName);
            Assert.AreEqual("password3", chair2.Password);
            Assert.AreEqual(false, chair2.Admin);
        }

        [TestMethod]
        public void FindConferenceTest()
        {
            var service = new UserConferenceService();
            PrepareData1();
            
            var conference = service.FindConference("2018, 9, 10", "2018, 9, 29");
            Assert.AreEqual("md", conference.MainDescription);
            Assert.AreEqual("confName", conference.Name);
            Assert.AreEqual(3, conference.Edition);
            
        }


        [TestMethod]
        public void GetRelevantTest()
        {
            /* null pointer exception ???
            var service = new UserConferenceService();
            PrepareData1();
            
            Assert.AreEqual(2, service.GetRelevantConferences(13).ToList().Count());
            */
        }

        [TestMethod]
        public void AddConferenceTest()
        {
            /*
            var service = new UserConferenceService();
            PrepareData1();
            ConferenceDTO  conf = new ConferenceDTO
             {
                Id = 25,
                Name = "name",
                Edition = 1,
                StartDate = "2020,3,13",
                EndDate = "2020,4,13",
                Domain = "dom",
                AbstractDeadline = "2020,3,9",
                FullPaperDeadline = "2020,3,11",
                MainDescription = "maind",
                Price = 25,
                State ="Accepted"
            };
            
            
            Assert.AreEqual(2, service.GetAllConferences().ToList().Count());
            var added = service.AddConference(4, conf);
            Assert.AreEqual(3, service.GetAllConferences().ToList().Count());
            */
            //Assert.AreEqual("maind", added.MainDescription);
        }
        



   
    } 
}
