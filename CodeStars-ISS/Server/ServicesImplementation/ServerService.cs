using services.Services;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using Model.Domain;
using Model.DTOModels;

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
        private IProposalService _paperService;
        private EnumGetDataService _enumService;
        private IReviewService _reviewService;

        public ServerService() { }

        //las constructorul asta doar pentru ca e folosit in teste
        //cred ca e mai bine sa folosim consructorul fara parametrii si de ficare daca cand adaug un serviciu sa adaug o metoda pentru setare
        //daca as modifica constructorul de fiecare data dupa aceea ar trebuii sa modific in multe locuri in proiect
        [Obsolete]
        public ServerService(IUserService userservice, IUserConferenceService userconferenceservice, IAdminConferenceService adminconferenceservice,
            ITicketService ticketservice, IEmailService emailservice, IProposalService propservice, EnumGetDataService enumservice, IReviewService reviewService)
        {
            _userService = userservice;
            _userConferenceService = userconferenceservice;
            _adminConferenceService = adminconferenceservice;
            _ticketService = ticketservice;
            _emailService = emailservice;
            _paperService = propservice;
            _enumService = enumservice;
            _reviewService = reviewService;
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
            _paperService = service;
        }

        public void SetEnumService(EnumGetDataService service)
        {
            _enumService = service;
        }
        public void SetReviewService(IReviewService service)
        {
            _reviewService = service;
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
        ProposalDTO AddPaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            return _paperService.AddPaper(idUser, idConferinta, paperDto);
        }

        ProposalDTO RemovePaper(int idUser, int idConferinta, int idPaper)
        {
            return _paperService.RemovePaper(idUser, idConferinta, idPaper);
        }

        ProposalDTO UpdatePaper(ProposalDTO paperDto)
        {
            return _paperService.UpdatePaper(paperDto);
        }

        //metods from EmailService
        public void SendEmail(string toEmail, string subject, string message)
        {
            _emailService.SendEmail(toEmail, subject, message);
        }

        public User_ConferenceDTO buyTicket(int idU, int idC)
        {
            return _ticketService.BuyTicket(idU, idC);
        }

        public ConferenceDTO FindConference(string startDate, string endDate)
        {
            return _userConferenceService.FindConference(startDate, endDate);
        }

        public ProposalDTO GetUserProposal(int idUser, int idConferinta)
        {
            return _paperService.GetUserProposal(idUser, idConferinta);
        }

        ProposalDTO IProposalService.AddPaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            return _paperService.AddPaper(idUser, idConferinta, paperDto);
        }

        ProposalDTO IProposalService.RemovePaper(int idUser, int idConferinta, int idPaper)
        {
            return _paperService.RemovePaper(idUser, idConferinta, idPaper);
        }

        ProposalDTO IProposalService.UpdatePaper(ProposalDTO paperDto)
        {
            return _paperService.UpdatePaper(paperDto);
        }

        public IEnumerable<ProposalDTO> GetUserProposals(int idUser)
        {
            return _paperService.GetUserProposals(idUser);
        }

        public IEnumerable<ProposalDTO> GetProposalsToBeReviewed(int idUser, int idConf)
        {
            return _paperService.GetProposalsToBeReviewed(idUser, idConf);
        }


        public ProposalDTO FindProposal(string title, string subject, string keywords)
        {
            return _paperService.FindProposal(title, subject, keywords);
        }

        public List<EnumObject> getData<E>()
        {
            return _enumService.getData<E>();
        }

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
        public void validateAccount(string username, string firstname, string lastname)
        {
            _adminConferenceService.validateAccount(username, firstname, lastname);
        }
    }
}
