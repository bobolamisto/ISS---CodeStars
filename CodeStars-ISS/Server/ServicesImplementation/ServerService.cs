using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Persistence.Repository;
using System.Data.Entity.Validation;
using Model.DTOModels;

namespace Server.ServicesImplementation
{
    public class ServerService : MarshalByRefObject, IServerService
    {
        private IUserService _userService;
        private IUserConferenceService _userConferenceService;
        private IAdminConferenceService _adminConferenceService;

        public ServerService(IUserService userservice, IUserConferenceService userconferenceservice, IAdminConferenceService adminconferenceservice)
        {
            _userService = userservice;
            _userConferenceService = userconferenceservice;
            _adminConferenceService = adminconferenceservice;

        }


        //methods from IUserService
        public User findUser(int id)
        {
            return _userService.findUser(id);
        }

        public UserDTO logIn(string username, string password)
        {
            return _userService.logIn(username, password);
        }

        public User createAccount(User user)
        {
            return _userService.createAccount(user);
        }

        public User removeAccount(int idUser)
        {
            return _userService.removeAccount(idUser);
        }

        public User updateAccount(User user)
        {
            return _userService.updateAccount(user);
        }

        public IEnumerable<User> findAll()
        {
            return _userService.findAll();
        }


        //methods from IUserConferenceService
        public void AddConference(int idUser, Conference conference)
        {
            _userConferenceService.AddConference(idUser, conference);
        }

        public IEnumerable<Conference> GetRelevantConferences(int idUser, UserRole userRole)
        {
            return _userConferenceService.GetRelevantConferences(idUser, userRole);
        }

        public IEnumerable<Conference> GetRelevantConferences(int idUser)
        {
            return _userConferenceService.GetRelevantConferences(idUser);
        }

        public IEnumerable<Conference> GetAllConferences()
        {
            return _userConferenceService.GetAllConferences();
        }

        public void ModifyDescription(int idUser, Conference conference)
        {
            _userConferenceService.ModifyDescription(idUser, conference);
        }


        //methods from IAdminConferenceService
        public void AcceptConferenceProposal(int idConference)
        {
            _adminConferenceService.AcceptConferenceProposal(idConference);
        }

        public void DeclineConferencProposal(int idConference)
        {
            _adminConferenceService.DeclineConferencProposal(idConference);
        }

        public void AcceptFullConference(int idConference)
        {
            _adminConferenceService.AcceptFullConference(idConference);
        }

        public IEnumerable<Conference> GetFilteredConferences(ConferenceState conferenceState)
        {
            return _adminConferenceService.GetFilteredConferences(conferenceState);
        }
    }
}
