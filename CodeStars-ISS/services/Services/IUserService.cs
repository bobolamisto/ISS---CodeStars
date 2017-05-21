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
        UserDTO findUser(int id);
        UserDTO logIn(string username, string password);
        UserDTO createAccount(UserDTO userDTO);
        UserDTO removeAccount(int idUser);
        UserDTO updateAccount(UserDTO userDTO);
        IEnumerable<UserDTO> findAll();
    }
}
