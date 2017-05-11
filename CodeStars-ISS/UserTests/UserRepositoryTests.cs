using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Domain;
using Model;
using Persistence.Repository;
using Effort;

namespace UserTests
{
    [TestClass]
    public class UserRepositoryTests
    {
        private DatabaseContext _context;
        private ICRUDRepository<User> _repo;

        [TestInitialize]
        public void Initialize()
        {
            var connection = DbConnectionFactory.CreateTransient();
            _context = new DatabaseContext(connection);
            var uow = new UnitOfWork(_context);
            _repo = uow.getRepository<User>();
        }
        [TestMethod]
        public void TestUserRepositoryGet()
        {
            var expectedId = 1;
            var expectedUsername = "test";
            var expectedPassword = "test";
            var expectedLastName = "test";
            var expectedAdmin = true;

            var user = _repo.getAll();
            Assert.AreEqual(user.ToList().Count, 0);
            /*
                var actualId = user.Id; 
                var actualUsername = user.Username;
                var actualPassword = user.Password;
                var actualLastName = user.LastName;
                var actualAdmin = user.Admin;
           
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedUsername, actualUsername);
            Assert.AreEqual(expectedPassword, actualPassword);
            Assert.AreEqual(expectedLastName, actualLastName);
            Assert.AreEqual(expectedAdmin, actualAdmin);
        */
        }
        
        [TestMethod]
        public void TestUserRepositorySaveAndGetAll()
        {
                User userToAdd = new User { 
                    Username = "userForTest1",
                    Password = "test",
                    FirstName = "userForTest",
                    LastName = "user",
                    Email = "test@gmail.com",
                    WebPage = "test.com",
                    Admin = false
                };
                _repo.save(userToAdd);
                Assert.AreEqual(_repo.getAll().ToList().Count, 1);

            }
        }

        /*
        [TestMethod]
        public void TestUserRepositoryRemove()
        {
            using (var scop = new System.Transactions.TransactionScope())
            {
                DatabaseContext context = new DatabaseContext();
                CRUDRepository<User> userRepository = new CRUDRepository<User>(context);

                var usersInDatabase = userRepository.getAll();
                foreach(var user in usersInDatabase)
                {
                    userRepository.remove(user.Id);
                }
                Assert.AreEqual(userRepository.getAll().Count(), 0);
            }
        }

        [TestMethod]
        public void TestUserRepositoryUpdate()
        {
            using (var scop = new System.Transactions.TransactionScope())
            {
                DatabaseContext context = new DatabaseContext();
                CRUDRepository<User> userRepository = new CRUDRepository<User>(context);

                var userInDatabase = userRepository.getAll().First();
                userInDatabase.FirstName = userInDatabase + "abc";
                userInDatabase.LastName = userInDatabase + "test";
                userInDatabase.Password = userInDatabase.Password + "123";

                userRepository.update(userInDatabase.Id, userInDatabase);
                var newUser = userRepository.getAll().First();
                Assert.AreEqual(userInDatabase.FirstName, newUser.FirstName);
                Assert.AreEqual(userInDatabase.LastName, newUser.LastName);
                Assert.AreEqual(userInDatabase.Password, newUser.Password);
            }
        }*/
    
}
