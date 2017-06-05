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
        public UserDTO findUser(int id)
        {
            var user = _server.findUser(id);
            return user;
        }
        public void validateAccount(string username, string firstname, string lastname)
        {
            _server.validateAccount(username, firstname, lastname);
        }
        public UserDTO createAccount(string username, string password, string firstname, string lastname, string email, string webpage)
        {
            var user = new UserDTO() { Id = 0, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = false };
            return _server.createAccount(user);

        }

        public UserDTO removeAccount(int id)
        {
            return _server.removeAccount(id);
        }

        internal void addColaborator(string text, ProposalDTO prop)
        {
            _server.addColaborator(text, prop.Id);
        }

        public UserDTO logIn(string username, string password)
        {
            return _server.logIn(username, password);
        }

        internal IEnumerable<UserDTO> searchStringInUsers(string text)
        {
            return _server.searchSubstringInUser(text);
        }

        public UserDTO updateAccount(int id, string username, string password, string firstname, string lastname, string email, string webpage, Boolean admin)
        {
            var user = new UserDTO { Id = id, Username = username, Password = password, FirstName = firstname, LastName = lastname, Email = email, WebPage = webpage, Admin = admin };
            return _server.updateAccount(user);
        }
        public User_ConferenceDTO buyTicket(int idU, int idC)
        {
            return _server.buyTicket(idU, idC);
        }


        // methods from IUserConferenceService
        public void addConference(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline, float Price, string Description)
        {
            var c = new ConferenceDTO() { Name = cName, StartDate = cStartDate.ToString(), EndDate = cEndDate.ToString(), Domain = Cdomain, AbstractDeadline = CabstractDeadline.ToString(), FullPaperDeadline = cFullPaperDeadline.ToString(), Price = Price, State = ConferenceState.Proposed.ToString(), MainDescription = Description };
            _server.AddConference(uId, c);
        }

        public IEnumerable<ConferenceDTO> getRelevantConferences(int uId, string userRole)
        {
            UserRole role = (UserRole)Enum.Parse(typeof(UserRole), userRole);
            return _server.GetRelevantConferences(uId, role);
        }

        public IEnumerable<ConferenceDTO> getRelevantConferences(int uId)
        {
            return _server.GetRelevantConferences(uId);
        }

        public IEnumerable<ConferenceDTO> getAllConferences()
        {
            return _server.GetAllConferences();
        }

        public void modifyDescription(int uId, int cId, string cName, DateTime cStartDate, DateTime cEndDate, string Cdomain, DateTime CabstractDeadline, DateTime cFullPaperDeadline)
        {
            var c = new ConferenceDTO { Id = cId, Name = cName, StartDate = cStartDate.ToString(), EndDate = cEndDate.ToString(), Domain = Cdomain, AbstractDeadline = CabstractDeadline.ToString(), FullPaperDeadline = cFullPaperDeadline.ToString() };
            _server.ModifyDescription(uId, c);
        }

        public ConferenceDTO updateConference(ConferenceDTO conferenceDTO)
        {
            return _server.updateConference(conferenceDTO);
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

        public IEnumerable<ConferenceDTO> getFilteredConferences(string conferenceState)
        {
            ConferenceState state = (ConferenceState)Enum.Parse(typeof(ConferenceState), conferenceState);
            return _server.GetFilteredConferences(state);
        }

        public ConferenceDTO FindConference(string startDate, string endDate)
        {
            return _server.FindConference(startDate, endDate);
        }

        public ProposalDTO GetUserProposal(int idUser, int idConferinta)
        {
            return _server.GetUserProposal(idUser, idConferinta);
        }

        public IEnumerable<ProposalDTO> GetUserProposals(int idUser)
        {
            return _server.GetUserProposals(idUser);
        }

        public ProposalDTO AddProposal(int idUser, int idConf, ProposalDTO proposal)
        {
            return _server.AddPaper(idUser, idConf, proposal);
        }

        public IEnumerable<UserDTO> getAllUsers()
        {
            return _server.findAll().Where(u => u.Validation == AccountState.Waiting.ToString());

        }

        public IEnumerable<UserDTO> getAllValidatedUsers()
        {
            return _server.findAll().Where(u => u.Validation == AccountState.Validated.ToString());

        }

        public ProposalDTO RemovePaper(int idPaper)
        {
            return _server.RemovePaper(idPaper);
        }

        public ProposalDTO UpdatePaper(ProposalDTO paperDto)
        {
            return _server.UpdatePaper(paperDto);
        }

        public ProposalDTO FindProposal(string title, string subject, string keywords)
        {
            return _server.FindProposal(title, subject, keywords);
        }

        public List<EnumObject> getData<E>()
        {
            return _server.getData<E>();
        }

        public ReviewDTO addReview(ReviewDTO model)
        {
            return _server.addReview(model);
        }

        public IEnumerable<ReviewDTO> getAllForProposal(int proposalId)
        {
            return _server.getAllForProposal(proposalId);
        }

        public IEnumerable<SectionDTO> getSectionsOfConference(int id)
        {
            return _server.getSectionsOfConference(id);
        }

        public IEnumerable<ProposalDTO> GetProposalsOfSection(int sectionId)
        {
            return _server.GetProposalsOfSection(sectionId);
        }
        public SectionDTO getSectionById(int id)
        {
            return _server.getSectionById(id);
        }

        public void addProposalToSection(int idProposal, int idSection)
        {
            _server.addProposalToSection(idProposal, idSection);
        }
        public ProposalDTO getProposalById(int id)
        {
            return _server.getProposalById(id);
        }
        public void removeProposalFromAnySection(int idProposal)
        {
            _server.removeProposalFromAnySection(idProposal);
        }

        public IEnumerable<ProposalDTO> getProposalsOutsideSections(int conferenceId)
        {
            return _server.getProposalsOutsideSections(conferenceId);
        }
        public int findByUsername(string username)
        {
            return _server.findByUsername(username);
        }

        public IEnumerable<UserDTO> getPCMembersForConference(int conferenceId)
        {
            return _server.getPCMembersForConference(conferenceId);
        }
        public SectionDTO addsection(SectionDTO section)
        {
            return _server.addSection(section);
        }

        public IEnumerable<UserDTO> getPCMembersAvailableForSectionChair(int conferenId)
        {
            return _server.getPCMembersAvailableForSectionChair(conferenId);
        }
        public void deleteSection(int id)
        {
            _server.deleteSection(id);
        }

        public UserDTO getChairOfConference(int confId)
        {
            return _server.getChairOfConference(confId);
        }

        public User_ConferenceDTO addCoChair(User_ConferenceDTO coChair)
        {
            return _server.addUserConference(coChair);

        }
        public IEnumerable<ProposalDTO> getProposalsByState(ProposalState proposalState)
        {
            return _server.GetProposalsByState(proposalState);
        }
        public IEnumerable<ProposalDTO> getProposalsByState(int idUser, ProposalState proposalState)
        {
            return _server.GetProposalsByState(idUser, proposalState);
        }
        public User_ConferenceDTO addReviewer(User_ConferenceDTO coChair)
        {
            return _server.addUserConference(coChair);
        }


        //methods for I
    }
}
