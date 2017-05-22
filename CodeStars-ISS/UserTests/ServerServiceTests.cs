using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Domain;
using server.ServicesImplementation;
using Server.ServicesImplementation;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOModels;

namespace UserTests
{
    [TestClass]
    public class ServerServiceTests
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
                model.Users.Add(new User { Id = 1, Username = "User1", FirstName = "First1", LastName = "Last1", Password = "password1", Email = "test1@gmail.com", WebPage = "test1.com", Admin = true, ConferenceParticipations = null });
                model.Users.Add(new User { Id = 2, Username = "User2", FirstName = "First2", LastName = "Last2", Password = "password2", Email = "test2@gmail.com", WebPage = "test2.com", Admin = false, ConferenceParticipations = null });
                model.Users.Add(new User { Id = 3, Username = "User3", FirstName = "First3", LastName = "Last3", Password = "password3", Email = "test3@gmail.com", WebPage = "test3.com", Admin = false, ConferenceParticipations = null });
                model.Users.Add(new User { Id = 4, Username = "User4", FirstName = "First4", LastName = "Last4", Password = "password4", Email = "test4@gmail.com", WebPage = "test4.com", Admin = true, ConferenceParticipations = null });

                model.SaveChanges();
            }
        }

        [TestMethod]
        public void TestServerServiceFindUser()
        {
            PrepareData();
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();

            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);

            var user1 = serverService.findUser(1);
            var user3 = serverService.findUser(3);

            Assert.AreEqual("User1", user1.Username);
            Assert.AreEqual("User3", user3.Username);
            Assert.AreEqual("Last1", user1.LastName);
            Assert.AreEqual("Last3", user3.LastName);
            Assert.AreEqual("First1", user1.FirstName);
            Assert.AreEqual("First3", user3.FirstName);
            Assert.AreEqual(true, user1.Admin);
            Assert.AreEqual(false, user3.Admin);
        }
        [TestMethod]
        public void TestServerServiceCreateAccount()
        {
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();
            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);
            UserDTO userToAdd = new UserDTO()
            {
                Username = "UserForTest",
                Password = "Password",
                FirstName = "User",
                LastName = "ForTest",
                Email = "test@gmail.com",
                WebPage = "test.ro",
                Admin = true,
                Validation = "Waiting"
            };

            Assert.AreEqual(0, serverService.findAll().ToList().Count);
            var userSaved = serverService.createAccount(userToAdd);
            Assert.AreEqual(1, serverService.findAll().ToList().Count);
            Assert.AreEqual("UserForTest",serverService.findUser(userSaved.Id).Username);
            Assert.AreEqual("test.ro", userSaved.WebPage);
        }

        [TestMethod]
        public void TestServerServiceLogIn()
        {
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();
            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);

            UserDTO userToAdd = new UserDTO()
            {
                Username = "UserForTest",
                Password = "Password",
                FirstName = "User",
                LastName = "ForTest",
                Email = "test@gmail.com",
                WebPage = "test.ro",
                Admin = true,
                Validation = "Waiting"
            };

            
            serverService.createAccount(userToAdd);
            Assert.AreEqual("UserForTest", serverService.logIn("UserForTest", "Password").Username);
            Assert.IsNull(serverService.logIn("abcde", "1234"));
        }

        [TestMethod]
        public void TestServerServiceRemoveAccount()
        {
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();
            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);

            PrepareData();
            var nrUsers = serverService.findAll().ToList().Count;
            var userRemoved = serverService.removeAccount(1);

            Assert.AreEqual(nrUsers - 1, serverService.findAll().ToList().Count);
            Assert.IsNull(serverService.findUser(1));
            Assert.AreEqual("User1", userRemoved.Username);
            Assert.AreEqual(1, userRemoved.Id);

        }
        [TestMethod]
        public void TestServerServiceUpdateAccount()
        {
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();
            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);

            PrepareData();
          

            Assert.AreEqual(4, serverService.findAll().ToList().Count);
            var userForUpdate = serverService.findUser(1);
            userForUpdate.FirstName = "Pop";
            userForUpdate.LastName = "Mihai";
            userForUpdate.Username = "Updated";

            var updatedUser = serverService.updateAccount(userForUpdate);
            var userFromDataBase = serverService.findUser(updatedUser.Id);

            Assert.AreEqual(4, serverService.findAll().ToList().Count);
            Assert.AreEqual("Pop", updatedUser.FirstName);
            Assert.AreEqual("Mihai", updatedUser.LastName);
            Assert.AreEqual("Updated", updatedUser.Username);
            Assert.AreEqual("Pop", userFromDataBase.FirstName);
            Assert.AreEqual("Mihai", userFromDataBase.LastName);
            Assert.AreEqual("Updated", userForUpdate.Username);

        }

        [TestMethod]
        public void TestServerServiceFindAll()
        {
            var userService = new UserService();
            var userConferenceService = new UserConferenceService();
            var adminConferenceService = new AdminConferenceService();
            var serverService = new ServerService(userService, userConferenceService, adminConferenceService);

            Assert.AreEqual(0, serverService.findAll().ToList().Count);
            PrepareData();
            Assert.AreEqual(4, serverService.findAll().ToList().Count);

        }

    }
}
