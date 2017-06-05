using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Domain;
using Model.DTOModels;
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
        
        private void PrepareData()
        {
            using (var model = new DatabaseContext())
            {
                model.Users.Add(new User {Id=1,Username="username",Password="pass",FirstName="firstname",LastName="LastName",Email="email@gmail.com",WebPage="webpage",Admin=true,Validation=AccountState.Validated });
                model.Conferences.Add(new Conference {Id=1,Name = "nume1", Edition = 1, StartDate = new DateTime(2015,01,12), EndDate = new DateTime(2015,4,14), Domain = "domeniu1", AbstractDeadline = new DateTime(2015, 2, 14), FullPaperDeadline = new DateTime(2015, 3, 14), MainDescription = "descriere1", Price = 111f, State = ConferenceState.Accepted });
                model.SaveChanges();
            }
        }

        public void TestConferenceServiceAddConf()
        {
            var service = new UserConferenceService();
            ConferenceDTO conferenceToAdd = new ConferenceDTO
            {
                Name = "Nume",
                Edition = 11,
                StartDate = (new DateTime(2018, 1, 12)).ToString(),
                EndDate = (new DateTime(2020, 1, 12)).ToString(),
                Domain = "Domeniu",
                AbstractDeadline = (new DateTime(2019, 1, 12)).ToString(),
                FullPaperDeadline = (new DateTime(2020, 1, 1)).ToString(),
                MainDescription = "Descriere",
                Price = 25f,
                State = ConferenceState.Accepted.ToString()
            };
            
            Assert.AreEqual(0, service.GetAllConferences().ToList().Count);
            PrepareData();
            Assert.AreEqual(1, service.GetAllConferences().ToList().Count);

            //the conference will be added
            try
            {
                var confSaved = service.AddConference(1, conferenceToAdd);
                Assert.AreEqual(2, service.GetAllConferences().ToList().Count);
            }
            catch(Exception e)
            {
                Assert.Fail();
            }

            //an error is thrown when the conference fails validation
            try
            {
                service.AddConference(1, conferenceToAdd);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.IsNotNull(e);
                Assert.AreEqual(2, service.GetAllConferences().ToList().Count);
            }
        }

    } 
}
