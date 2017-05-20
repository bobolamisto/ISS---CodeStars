using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Model.DTOModels;
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


        //methods from IUserService
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

        public UserDTO logIn(string username, string password)
        {
            return _server.logIn(username, password);
        }

        public User updateAccount(int id, string username, string password, string firstname, string lastname, string email, string webpage, Boolean admin)
        {
            User user = new User { Id = id, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = admin };
            return _server.updateAccount(user);
        }


        // methods from IUserConferenceService
        public void addConference(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline)
        {
            Conference c = new Conference { Id = cId, Name = cName, StartDate = cStartDate, EndDate = cEndDate, Domain = Cdomain, AbstractDeadline = CabstractDeadline, FullPaperDeadline = cFullPaperDeadline };
            _server.AddConference(uId, c);
        }

        public IEnumerable<Conference> getRelevantConferences(int uId, string userRole)
        {
            UserRole role = (UserRole)Enum.Parse(typeof(UserRole), userRole);
            return _server.GetRelevantConferences(uId, role);
        }

        public IEnumerable<Conference> getRelevantConferences(int uId)
        {
            return _server.GetRelevantConferences(uId);
        }

        public IEnumerable<Conference> getAllConferences()
        {
            return _server.GetAllConferences();
        }

        public void modifyDescription(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline)
        {
            Conference c = new Conference { Id = cId, Name = cName, StartDate = cStartDate, EndDate = cEndDate, Domain = Cdomain, AbstractDeadline = CabstractDeadline, FullPaperDeadline = cFullPaperDeadline };
            _server.ModifyDescription(uId, c);
        }


        //methods from IAdminConferenceService
        public void acceptConferenceProposal(int idConference)
        {
            _server.AcceptConferenceProposal(idConference);
        }
        public void declineConferencProposal(int idConference)
        {
            _server.DeclineConferencProposal(idConference);
        }

        public void acceptFullConference(int idConference)
        {
            _server.AcceptFullConference(idConference);
        }

        public IEnumerable<Conference> getFilteredConferences(string conferenceState)
        {
            ConferenceState state = (ConferenceState)Enum.Parse(typeof(ConferenceState), conferenceState);
            return _server.GetFilteredConferences(state);
        }
    }
}