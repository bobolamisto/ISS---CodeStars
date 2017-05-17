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

        [TestMethod]
        public void TestUserServiceCreateAccount()
        {
            User userToAdd = new User
            {
                Username = "UserForTest",
                Password = "Password",
                FirstName = "User",
                LastName = "ForTest",
                Email = "test@gmail.com",
                WebPage = "test.ro",
                Admin = true
            };

                var _userService = new UserService();
                Assert.AreEqual(0, _userService.findAll().ToList().Count);
                var userSaved = _userService.createAccount(userToAdd);
                Assert.AreEqual(1, _userService.findAll().ToList().Count);


        }

    }
}
