using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using services.Services;

namespace CodeStars_Iss.Controller
{
    public class ClientController : MarshalByRefObject, IClientService
    {
        private IServerService _server;
        public ClientController(IServerService srv)
        {
            _server = srv;
        }

        public User findUser(int id)
        {
            User user = _server.findUser(id);
            return user;
        }

        public User createAccount(string username, string password, string firstname, string lastname, string email, string webpage)
        {
            User user = new User { Id = 0, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = false };
            return _server.createAccount(user);

        }

        public User removeAccount(int id)
        {
            return _server.removeAccount(id);
        }

        public Boolean logIn(string username, string password)
        {
            return _server.logIn(username, password);
        }

        public User updateAccount(int id, string username, string password, string firstname, string lastname, string email, string webpage, Boolean admin)
        {
            User user = new User { Id = id, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = admin };
            return _server.updateAccount(user);
        }
    }
}

