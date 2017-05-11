using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using services.Services;
namespace CodeStars_Iss.Controller
{
    public class UserController
    {
        public IUserService service;
        public UserController()
        {
            this.service = new UserService();
        }

        public User findUser(int id)
        {
            User user= service.findUser(id);
            return user;
        }

        public User createAccount( string username, string password, string firstname, string lastname, string email, string webpage)
        {
            User user = new User { Id = 0, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = false };
            return service.createAccount(user);
            
        }

        public User removeAccount(int id)
        {
            return service.removeAccount(id);
        }

        public Boolean logIn(string username, string password)
        {
            return service.logIn(username, password);
        }

        public User updateAccount(int id, string username, string password, string firstname, string lastname, string email, string webpage, Boolean admin)
        {
            User user = new User { Id = id, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = admin };
            return service.updateAccount(user);
        }
    }
}
