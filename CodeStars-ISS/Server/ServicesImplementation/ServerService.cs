using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Persistence.Repository;
using System.Data.Entity.Validation;

namespace Server.ServicesImplementation
{
    public class ServerService : MarshalByRefObject, IServerService
    {
        private IUserService _userService;

        public ServerService(IUserService userservice)
        {
            _userService = userservice;            
        }
        public User createAccount(User user)
        {
            return _userService.createAccount(user);
        }

        public IEnumerable<User> findAll()
        {
            return _userService.findAll();
        }

        public User findUser(int id)
        {
            return _userService.findUser(id);
        }

        public bool logIn(string username, string password)
        {
            return _userService.logIn(username, password);
        }

        public User removeAccount(int idUser)
        {
            return _userService.removeAccount(idUser);
        }

        public User updateAccount(User user)
        {
            return _userService.updateAccount(user);
        }
    }
}
