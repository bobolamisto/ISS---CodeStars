using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTests
{
    [TestClass]
    public class UserConferenceModelTests
    {
        [TestMethod]
        public void TestUserConference()
        {
            Conference c = new Conference
            {
                Id = 123,
                Name = "conf",
                Edition = 1,
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2017,10,27),
                Domain = "domeniu",
                AbstractDeadline = new DateTime(2017,10,01),
                FullPaperDeadline = new DateTime(2017,10,05),
                MainDescription = "descriere",
                Price = 25,
                State = ConferenceState.Accepted

            };

            User user = new User
            {
                Id=20,
                Username="usrname",
                Password="pass",
                FirstName="ion",
                LastName="last",
                Email="mail@yahoo.com",
                WebPage="page.ro",
                Admin=false
            };

            User_Conference userConf = new User_Conference
            {
                Id=1,
                Role=UserRole.Listener,
                ConferenceId=123,
                UserId=20
            };

            int expectedId = 1;
            UserRole userRoleExpected = UserRole.Listener;
            int confIdExpected = 123;
            int userIdExpected = 20;

            int actualIdUC = userConf.Id;
            UserRole actualRole = userConf.Role;
            int actualConfId = userConf.ConferenceId;
            int actualUserID = userConf.UserId;

            Assert.AreEqual(expectedId, actualIdUC);
            Assert.AreEqual(userRoleExpected, actualRole);
            Assert.AreEqual(confIdExpected, actualConfId);
            Assert.AreEqual(userIdExpected, actualUserID);



        }
    }
}
