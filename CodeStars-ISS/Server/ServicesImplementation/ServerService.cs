using services.Services;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using Model.Domain;
using Model.DTOModels;
using System.Linq;

namespace Server.ServicesImplementation
{
    public class ServerService : MarshalByRefObject, IServerService
    {
        private IUserService _userService;
        private IUserConferenceService _userConferenceService;
        private IAdminConferenceService _adminConferenceService;
        private IAdminUserChekerService _adminUserCheckerService;
        private ITicketService _ticketService;
        private IEmailService _emailService;
        private IProposalService _proposalService;
        private EnumGetDataService _enumService;
        private IReviewService _reviewService;
        private ISectionService _sectionService;

        public ServerService() { }

        //las constructorul asta doar pentru ca e folosit in teste
        //cred ca e mai bine sa folosim consructorul fara parametrii si de ficare daca cand adaug un serviciu sa adaug o metoda pentru setare
        //daca as modifica constructorul de fiecare data dupa aceea ar trebuii sa modific in multe locuri in proiect
        [Obsolete]
        public ServerService(IUserService userservice, IUserConferenceService userconferenceservice, IAdminConferenceService adminconferenceservice,
            ITicketService ticketservice, IEmailService emailservice, IProposalService propservice, EnumGetDataService enumservice, 
            IReviewService reviewService,ISectionService sectionService)
        {
            _userService = userservice;
            _userConferenceService = userconferenceservice;
            _adminConferenceService = adminconferenceservice;
            _ticketService = ticketservice;
            _emailService = emailservice;
            _proposalService = propservice;
            _enumService = enumservice;
            _reviewService = reviewService;
            _sectionService = sectionService;
        }

        #region ServiceSetters

        public void SetUserService(IUserService service)
        {
            _userService = service;
        }

        public void SetUserConferenceService(IUserConferenceService service)
        {
            _userConferenceService = service;
        }

        public void SetAdminConferencesService(IAdminConferenceService service)
        {
            _adminConferenceService = service;
        }

        public void SetAdminUserCheckerService(IAdminUserChekerService service)
        {
            _adminUserCheckerService = service;
        }

        public void SetTicketService(ITicketService service)
        {
            _ticketService = service;
        }

        public void SetEmailService(IEmailService service)
        {
            _emailService = service;
        }

        public void SetPaperService(IProposalService service)
        {
            _proposalService = service;
        }

        public void SetEnumService(EnumGetDataService service)
        {
            _enumService = service;
        }
        public void SetReviewService(IReviewService service)
        {
            _reviewService = service;
        }

        public void SetSectionService(ISectionService service)
        {
            _sectionService = service;
        }

        #endregion

        //methods from IUserService
        public UserDTO findUser(int id)
        {
            return _userService.findUser(id);
        }

        public UserDTO logIn(string username, string password)
        {
            return _userService.logIn(username, password);
        }

        public UserDTO createAccount(UserDTO user)
        {
            return _userService.createAccount(user);
        }

        public UserDTO removeAccount(int idUser)
        {
            return _userService.removeAccount(idUser);
        }

        public UserDTO updateAccount(UserDTO user)
        {
            return _userService.updateAccount(user);
        }

        public IEnumerable<UserDTO> findAll()
        {
            return _userService.findAll();
        }

        public IEnumerable<UserDTO> searchSubstringInUser(string text)
        {
            return _userService.searchSubstringInUser(text);
        }


        //methods from IUserConferenceService
        public ConferenceDTO AddConference(int idUser, ConferenceDTO conference)
        {
            return _userConferenceService.AddConference(idUser, conference);
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser, UserRole userRole)
        {
            return _userConferenceService.GetRelevantConferences(idUser, userRole);
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser)
        {
            return _userConferenceService.GetRelevantConferences(idUser);
        }

        public IEnumerable<ConferenceDTO> GetAllConferences()
        {
            return _userConferenceService.GetAllConferences();
        }

        public ConferenceDTO ModifyDescription(int idUser, ConferenceDTO conference)
        {
            return _userConferenceService.ModifyDescription(idUser, conference);
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

        public IEnumerable<ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState)
        {
            return _adminConferenceService.GetFilteredConferences(conferenceState);
        }

        public void validateAccount(string username, string firstname, string lastname)
        {
            _adminConferenceService.validateAccount(username, firstname, lastname);
        }

        //methods from IAdminUserCheckerService
        public UserDTO AcceptNewUser(UserDTO userDto)
        {
            return _adminUserCheckerService.AcceptNewUser(userDto);
        }

        public UserDTO RejectNewUser(UserDTO userDto)
        {
            return _adminUserCheckerService.AcceptNewUser(userDto);
        }

        //methods from ITickerService
        public User_ConferenceDTO BuyTicket(int idUser, int idConference)
        {
            return _ticketService.BuyTicket(idUser, idConference);
        }

        public float GetTicketPrice(int idConference)
        {
            return _ticketService.GetTicketPrice(idConference);
        }

        //methods from PaperService
        public ProposalDTO AddPaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            return _proposalService.AddPaper(idUser, idConferinta, paperDto);
        }

        public ProposalDTO RemovePaper( int idPaper)
        {
            return _proposalService.RemovePaper(idPaper);
        }

        public ProposalDTO UpdatePaper(ProposalDTO paperDto)
        {
            return _proposalService.UpdatePaper(paperDto);
        }

        public ProposalDTO GetUserProposal(int idUser, int idConferinta)
        {
            return _proposalService.GetUserProposal(idUser, idConferinta);
        }

        public IEnumerable<ProposalDTO> GetUserProposals(int idUser)
        {
            return _proposalService.GetUserProposals(idUser);
        }

        public IEnumerable<ProposalDTO> GetProposalsByState(ProposalState proposalState,int confId)
        {
            return _proposalService.GetProposalsByState(proposalState,confId);
        }

        public IEnumerable<ProposalDTO> GetProposalsByState(int idUser, ProposalState proposalState)
        {
            return _proposalService.GetProposalsByState(idUser, proposalState);
        }

        public IEnumerable<ProposalDTO> GetProposalsOfSection(int sectionId)
        {
            return _proposalService.GetProposalsOfSection(sectionId);
        }


        public ProposalDTO FindProposal(string title, string subject, string keywords)
        {
            return _proposalService.FindProposal(title, subject, keywords);
        }

        //methods from EmailService
        public void SendEmail(string toEmail, string subject, string message)
        {
            _emailService.SendEmail(toEmail, subject, message);
        }

        //methods from User_Conference Service

        public User_ConferenceDTO buyTicket(int idU, int idC)
        {
            return _ticketService.BuyTicket(idU, idC);
        }

        public ConferenceDTO FindConference(string startDate, string endDate)
        {
            return _userConferenceService.FindConference(startDate, endDate);
        } 

        
        //methods from Enum Service
        public List<EnumObject> getData<E>()
        {
            return _enumService.getData<E>();
        }

        //methods from Review Service
        public ReviewDTO addReview(ReviewDTO model)
        {
            return _reviewService.addReview(model);
        }

        public void updateReview(ReviewDTO model)
        {
            throw new NotImplementedException();
        }

        public void removeReview(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public ReviewDTO getReview(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> getAllForProposal(int proposalId)
        {
            return _reviewService.getAllForProposal(proposalId);
        }


        //methods from Section Service
        public IEnumerable<SectionDTO> getSectionsOfConference(int conferenceId)
        {
            return _sectionService.getSectionsOfConference(conferenceId);
        }

        public SectionDTO addSection(SectionDTO section)
        {
            return _sectionService.addSection(section);
        }

        public void updateSection(SectionDTO section)
        {
            _sectionService.updateSection(section);
        }

        public void deleteSection(int id)
        {
            _sectionService.deleteSection(id);
        }

        public SectionDTO getSectionById(int id)
        {
            return _sectionService.getSectionById(id);
        }

        public void addProposalToSection(int idProposal, int idSection)
        {
            _proposalService.addProposalToSection(idProposal, idSection);
        }

        public ProposalDTO getProposalById(int id)
        {
            return _proposalService.getProposalById(id);
        }

        public void removeProposalFromAnySection(int idProposal)
        {
            _proposalService.removeProposalFromAnySection(idProposal);
        }

        public IEnumerable<ProposalDTO> getProposalsOutsideSections(int conferenceId)
        {
            return _proposalService.getProposalsOutsideSections(conferenceId);
        }

        public void addColaborator(string username, int id)
        {
            _proposalService.addColaborator(username, id);
        }

        public int findByUsername(string username)
        {
            return _userService.findByUsername(username);
        }

        public IEnumerable<UserDTO> getPCMembersForConference(int conferenceId)
        {
            return _userConferenceService.getPCMembersForConference(conferenceId);
        }

        public ProposalState evaluateProposal(int id)
        {
             var state= _proposalService.evaluateProposal(id);
            var part = this.GetParticipationOfProposal(id);
            var user = this.findUser(part.UserId);
            _emailService.SendEmail(user.Email, "Proposal accepted", "Your proposal was accepted. Now you are a speaker at the conference.");
            return state;
        }

        public IEnumerable<UserDTO> getPCMembersAvailableForSectionChair(int conferenId)
        {
            return _userConferenceService.getPCMembersAvailableForSectionChair(conferenId);
        }

        public UserDTO getChairOfConference(int confId)
        {
            return _userConferenceService.getChairOfConference(confId);
        }
        
        public User_ConferenceDTO addUserConference(User_ConferenceDTO userConference)
        {
            return _userConferenceService.addUserConference(userConference);
        }

        public ConferenceDTO updateConference(ConferenceDTO conferenceDTO)
        {
            return _userConferenceService.updateConference(conferenceDTO);
        }

        public IEnumerable<UserDTO> findUsersByAccountState(AccountState state)
        {
            return _userService.findUsersByAccountState(state);
        }

        public void updateUserRole(int userId, int confId, UserRole role)
        {
            _userConferenceService.updateUserRole(userId, confId, role);
        }

        public User_ConferenceDTO GetParticipationOfProposal(int proposalId)
        {
            return _userConferenceService.GetParticipationOfProposal(proposalId);
        }
    }
}
