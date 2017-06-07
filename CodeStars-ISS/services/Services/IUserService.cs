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
        User_ConferenceDTO buyTicket(int idU, int idC);
        IEnumerable<UserDTO> findAll();
        int findByUsername(string username);
        IEnumerable<UserDTO> searchSubstringInUser(string text);
        IEnumerable<UserDTO> findUsersByAccountState(AccountState state);


    }
}
