using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using services.Services;
using Model.Domain;
using CodeStars_Iss.Controller;

namespace UserTests
{
    [TestClass]
    public class ClientControllerTests
    {
        [TestMethod]
        public void TestClientControllerFindUserUserNotFound()
        {
            var serverService = new Mock<IServerService>();
            serverService
                .Setup(s => s.findUser(It.IsAny<int>()))
                .Returns((User)null);

            var clientController = new ClientController(serverService.Object);

            var user = clientController.findUser(12);

            Assert.IsNull(user);
        }

        [TestMethod]
        public void TestClientControllerFindUserUserFound()
        {
            var serverService = new Mock<IServerService>();
            serverService
                .Setup(s => s.findUser(It.IsAny<int>()))
                .Returns(new User
                {
                    Id = 1,
                    Username = "user",
                    FirstName = "firstname"
                });

            var clientController = new ClientController(serverService.Object);

            var user = clientController.findUser(1);

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("user", user.Username);
            Assert.AreEqual("firstname", user.FirstName);
        }

        [TestMethod]
        public void TestClientControllerCreateAccount()
        {
            var serverService = new Mock<IServerService>();
            serverService
                .Setup(s => s.createAccount(It.IsAny<User>()))
                .Returns(new User
                {
                    Id = 1,
                    Username = "user",
                    FirstName = "firstname"
                });

            var clientController = new ClientController(serverService.Object);
            var user = clientController.createAccount("user", "password", "firstname", "lastname", "test@gmail.com", "test.com");
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("user", user.Username);
            Assert.AreEqual("firstname", user.FirstName);
        }
        [TestMethod]
        public void TestClientControllerRemoveAccount()
        {
            var serverService = new Mock<IServerService>();
            serverService
                .Setup(s => s.removeAccount(It.IsAny<int>()))
                .Returns(new User
                {
                    Id = 1,
                    Username = "user",
                    FirstName = "firstname"
                });

            var clientController = new ClientController(serverService.Object);

            var user = clientController.removeAccount(1);

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("user", user.Username);
            Assert.AreEqual("firstname", user.FirstName);
        }
        [TestMethod]
        public void TestClientControllerLogIn()
        {
            var serverService = new Mock<IServerService>();
            serverService.Setup(s => s.logIn(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);
            var clientController = new ClientController(serverService.Object);
            Assert.AreEqual(true, clientController.logIn("username", "password"));
        }
        [TestMethod]
        public void TestClientControllerUpdateAccount()
        {
            var serverService = new Mock<IServerService>();
            var user = new User
            {
                Id = 1,
                Username = "username",
                FirstName = "First",
                LastName = "Last",
                Password = "password",
                Email = "test@gmail.com",
                WebPage = "test.com",
                Admin = true
            };
            serverService
               .Setup(s => s.updateAccount(It.IsAny<User>()))
               .Returns(new User {
                   Id = 1,
                   Username = "usernamea",
                   FirstName = "Firstc",
                   LastName = "Last",
                   Password = "passwordb",
                   Email = "test@gmail.com",
                   WebPage = "test.com",
                   Admin = true

               });

            var clientController = new ClientController(serverService.Object);

            var userUpdated = clientController.updateAccount(user.Id, user.Username + "a", user.Password + "b", user.FirstName + "c", user.LastName, user.Email, user.WebPage, true);

            Assert.IsNotNull(user);
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual(user.Username + "a", userUpdated.Username);
            Assert.AreEqual(user.FirstName + "c", userUpdated.FirstName);
            Assert.AreEqual(user.Password + "b", userUpdated.Password);
        }

    }
}
