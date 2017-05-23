using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTests
{
    [TestClass]
   public class UserConferenceServiceTests
    {
        [TestInitialize]
        public void Initialize()
        {
            EffortProviderFactory.ResetDb();
        }

        // testele crapa cand incerc sa adauga chestii in bazade date. O sa ma gandesc ce sa modific, pana atunci le las asa 



        //private void PrepareData()
        //{
        //    using (var model = new DatabaseContext())
        //    {
        //        model.Users.Add(new User { Id = 1, Username = "User1", FirstName = "First1", LastName = "Last1", Password = "password1", Email = "test1@gmail.com", WebPage = "test1.com", Admin = true, ConferenceParticipations = null });
        //        model.Users.Add(new User { Id = 2, Username = "User2", FirstName = "First2", LastName = "Last2", Password = "password2", Email = "test2@gmail.com", WebPage = "test2.com", Admin = false, ConferenceParticipations = null });
        //        model.Users.Add(new User { Id = 3, Username = "User3", FirstName = "First3", LastName = "Last3", Password = "password3", Email = "test3@gmail.com", WebPage = "test3.com", Admin = false, ConferenceParticipations = null });
        //        model.Users.Add(new User { Id = 4, Username = "User4", FirstName = "First4", LastName = "Last4", Password = "password4", Email = "test4@gmail.com", WebPage = "test4.com", Admin = true, ConferenceParticipations = null });

        //        model.Conferences.Add(new Conference { Id = 11, Name = "Conf1", Edition = 1, StartDate = new DateTime(2018, 8, 18), EndDate = new DateTime(2018, 8, 20), Domain = "domeniu", AbstractDeadline = new DateTime(2018, 8, 1), FullPaperDeadline = new DateTime(2010, 8, 5), MainDescription = "descriere principala", Price = 25, State = ConferenceState.Building });
        //        model.Conferences.Add(new Conference { Id = 22, Name = "Conf2", Edition = 1, StartDate = new DateTime(2018, 10, 18), EndDate = new DateTime(2018, 10, 19), Domain = "domeniu", AbstractDeadline = new DateTime(2018, 10, 1), FullPaperDeadline = new DateTime(2018, 10, 5), MainDescription = "descriere principala", Price = 30, State = ConferenceState.Building });


        //        model.SaveChanges();
        //    }
        //}

        //[TestMethod]
        //public void AddConferenceTest()
        //{
        //    ConferenceDTO confDTO = new ConferenceDTO
        //    {
        //        Id=10,
        //        Name = "conferenceName",
        //        Edition = 1,
        //        StartDate = "02.11.2018",
        //        EndDate = "05.11.2018",
        //        Domain = "conferenceDomain",
        //        AbstractDeadline = "01.11.2018",
        //        FullPaperDeadline = "02.11.2018",
        //        MainDescription = "main description",
        //        Price = 25,
        //        State = "Building"
        //    };

        //    UserDTO usr = new UserDTO
        //    {
        //        Id = 1,
        //        Username="u1",
        //        Password="pass",
        //        FirstName="Fn",
        //        LastName="LN",
        //        Email="email@gmail.com",
        //        WebPage="page.ro",
        //        Admin=false,
        //        Validation="valid"

        //    };



        //  //  PrepareData();

        //    var _userCondService = new UserConferenceService();
        //    Assert.AreEqual(0, _userCondService.GetAllConferences().ToList().Count);
        //    var userConfSaved = _userCondService.AddConference(1,confDTO);
        //    Assert.AreEqual(1, _userCondService.GetAllConferences().ToList().Count);

        //}

        //[TestMethod]
        //public void GetRelevantConferencesTset()
        //{
        //    PrepareData();

        //        ConferenceDTO confDTO = new ConferenceDTO
        //        {
        //            Name = "confeName",
        //            Edition = 1,
        //            StartDate = "02.11.2018",
        //            EndDate = "05.11.2018",
        //            Domain = "conferenceDomain",
        //            AbstractDeadline = "01.11.2018",
        //            FullPaperDeadline = "02.11.2018",
        //            MainDescription = "main description",
        //            Price = 25,
        //            State = "Building"
        //        };

        //    var _userCondService = new UserConferenceService();
        //    var userConfSaved = _userCondService.AddConference(4, confDTO);
        //    var user1 = _userCondService.GetRelevantConferences(4, UserRole.Listener);
        //    int nr = user1.ToList().Count;
        //    Assert.AreEqual(1, nr);

        //}

        //[TestMethod]
        //public void FindRelevantConferenceTest()
        //{
        //    //IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser)
        //    var _userCondService = new UserConferenceService();
            
        //    UserDTO usrdto = new UserDTO
        //    {
        //        Id=1,
        //        Username="username",
        //        Password="pass",
        //        FirstName="First",
        //        LastName="Last",
        //        Email="mail@yahoo.com",
        //        WebPage="page.com",
        //        Admin=false,
        //        Validation="valid"
        //    };



        //}

    }
}
