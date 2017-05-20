using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOModels;

namespace services.Services
{
    public interface IUserService
    {
        User findUser(int id);
        UserDTO logIn(string username, string password);
        User createAccount(User user);
        User removeAccount(int idUser);
        User updateAccount(User user);
        IEnumerable<User> findAll();
    }
}
