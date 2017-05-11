using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Services
{
    public interface IUserService
    {
        User findUser(int id);
        Boolean logIn(string username, string password);
        User createAccount(User user);
        User removeAccount(int idUser);
        User updateAccount(User user);
    }
}
