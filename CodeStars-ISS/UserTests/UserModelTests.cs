using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;

namespace UserTests
{
    [TestClass]
    public class UserModelTests
    {
        [TestMethod]
        public void TestUser()
        {
            //arrange
            User user1 = new User {
                Id = 1,
                Username = "ion23",
                Password = "abcde",
                FirstName = "ion",
                LastName = "popescu",
                Email = "popescui@gmail.com",
                WebPage = "web1",
                Admin = false };
            var expectedId = 1;
            var expectedUsername = "ion23";
            var expectedPassword = "abcde";
            var expectedFirstName = "ion";
            var expectedLastName = "popescu";
            var expectedEmail = "popescui@gmail.com";
            var expectedWebPage = "web1";
            var expectedAdmin = false;


            
            int actualId = user1.Id;
            string actualUsername =user1.Username;
            string actualPassword = user1.Password;
            string actualFirstName = user1.FirstName;
            string actualLastName = user1.LastName;
            string actualEmail = user1.Email;
            string actualWebPage = user1.WebPage;
            bool actualAdmin = user1.Admin;

            //assert

            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedUsername, actualUsername);
            Assert.AreEqual(expectedPassword, actualPassword);
            Assert.AreEqual(expectedFirstName, actualFirstName);
            Assert.AreEqual(expectedLastName, actualLastName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedWebPage, actualWebPage);
            Assert.AreEqual(expectedAdmin, actualAdmin);


        }
    }
}
