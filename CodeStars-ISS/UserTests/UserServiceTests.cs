using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;
using Model;
using Persistence.Repository;
using Effort;
using services.Services;
using server.ServicesImplementation;
using System.Data.Common;
using Model.DTOModels;
using Server.ServicesImplementation;

namespace UserTests
{
    [TestClass]
    public class UserServiceTests
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
        public void TestUserServiceCreateAccount()
        {
            UserDTO userToAdd = new UserDTO
            {
                Username = "UserForTest",
                Password = "Password",
                FirstName = "User",
                LastName = "ForTest",
                Email = "test@gmail.com",
                WebPage = "test.ro",
                Admin = true,
                Validation = "Validated"
            };
               
                var _userService = new UserService();
                Assert.AreEqual(0, _userService.findAll().ToList().Count);
                var userSaved = _userService.createAccount(userToAdd);
                Assert.AreEqual(1, _userService.findAll().ToList().Count);

        }
        [TestMethod]
        public void TestUserServiceFindAll()
        {
            var userService = new UserService();
            Assert.AreEqual(0, userService.findAll().ToList().Count);
            PrepareData();
            Assert.AreEqual(4, userService.findAll().ToList().Count);

        }

        [TestMethod]
        public void TestUserServiceFindUser()
        {
            PrepareData();
            var userService = new UserService();

            var user1 = userService.findUser(1);
            var user3 = userService.findUser(3);

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
        public void TestUserServiceRemoveAccount()
        {
            PrepareData();
            var userService = new UserService();
            var nrUsers = userService.findAll().ToList().Count;

            var userRemoved = userService.removeAccount(1);

            Assert.AreEqual(nrUsers - 1, userService.findAll().ToList().Count);
            Assert.AreEqual(null, userService.findUser(1));
            Assert.AreEqual("User1", userRemoved.Username);
            Assert.AreEqual(1, userRemoved.Id);
        }

        [TestMethod]
        public void TestUserServiceLogIn()
        {
            UserDTO userToAdd = new UserDTO()
            {
                Username = "UserForTest",
                Password = "Password",
                FirstName = "User",
                LastName = "ForTest",
                Email = "test@gmail.com",
                WebPage = "test.ro",
                Admin = true,
                Validation = "Validated"
            };

            var userService = new UserService();
            var userCreated = userService.createAccount(userToAdd);
            //test duplicat, e acelasi lucru daca folosesc loginDin UserService sau serverService
            //validare cont nou
            //todo: AdminUserCheckerService ar trebuii inlocuit cu un mock
            var adminUserCheckerService = new AdminUserCheckerService();
            var userAccepted = adminUserCheckerService.AcceptNewUser(userCreated);

            var userReturnedFromLogin = userService.logIn("UserForTest", "Password");

            Assert.AreEqual("UserForTest", userReturnedFromLogin.Username);
            Assert.AreEqual(null, userService.logIn("abcde", "1234"));
        }

        [TestMethod]
        public void TestUserServiceUpdateAccount()
        {
            PrepareData();
            var userService = new UserService();

            Assert.AreEqual(4, userService.findAll().ToList().Count);
            var userForUpdate = userService.findUser(1);
            userForUpdate.FirstName = "Pop";
            userForUpdate.LastName = "Mihai";
            userForUpdate.Username = "Updated";

            var updatedUser = userService.updateAccount(userForUpdate);
            var userFromDataBase = userService.findUser(updatedUser.Id);

            Assert.AreEqual(4, userService.findAll().ToList().Count);
            Assert.AreEqual("Pop", updatedUser.FirstName);
            Assert.AreEqual("Mihai", updatedUser.LastName);
            Assert.AreEqual("Updated", updatedUser.Username);
            Assert.AreEqual("Pop", userFromDataBase.FirstName);
            Assert.AreEqual("Mihai", userFromDataBase.LastName);
            Assert.AreEqual("Updated", userForUpdate.Username);
        }

    }
}
