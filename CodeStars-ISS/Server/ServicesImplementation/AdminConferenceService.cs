using System;
using System.Collections.Generic;
using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using Server.ModelConverterServices;
using Server.ServicesImplementation;

namespace services.Services
{
    public class AdminConferenceService : IAdminConferenceService
    {
        private ConferenceConverterService converter;
        private EmailService emailService;
        public AdminConferenceService()
        {
            converter = new ConferenceConverterService();
            emailService = new EmailService();
        }

        public void AcceptConferenceProposal(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Building);
            using (var uow = new UnitOfWork())
            {
                var repoUser_Conf = uow.getRepository<User_Conference>();
                var chair = repoUser_Conf.getAll().FirstOrDefault(x => x.ConferenceId == idConference && x.Role == UserRole.Chair).User;
                emailService.SendEmail(chair.Email, "Conference proposal accepted", "Your conference proposal was accepted. Now you can update co-chairs, abstract date, full paper date.");
            }
            
        }

        public void DeclineConferencProposal(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Declined);
        }

        public void AcceptFullConference(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Accepted);
            using (var uow = new UnitOfWork())
            {
                var repoUser_Conf = uow.getRepository<User_Conference>();
                var chair = repoUser_Conf.getAll().FirstOrDefault(x => x.ConferenceId == idConference && x.Role == UserRole.Chair).User;
                emailService.SendEmail(chair.Email, "Conference proposal accepted", "Your conference proposal was accepted.");
            }
        }

        public IEnumerable<ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return converter.convertToDTOList(conferenceRepo.getAll().Where(conference => conference.State == conferenceState));
            }
        }

        private void ChangeConferenceState(int idConference, ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                var conferenceFromRepo = conferenceRepo.get(idConference);
                conferenceFromRepo.State = conferenceState;
                uow.saveChanges();
            }
        }

       
        public void validateAccount(string username, string firstname, string lastname)
        {
            using (var uow = new UnitOfWork())
            {
                var userRepo = uow.getRepository<User>();
                var user = userRepo.getAll().FirstOrDefault(x => x.Username == username && x.FirstName == firstname && x.LastName == lastname);
                if (user != null)
                {
                    user.Validation = AccountState.Validated;
                    emailService.SendEmail(user.Email, "Account validated", "Your account on Conferences Platform was validated");
                }
                uow.saveChanges();
            }
        }
        public void unvalidateAccount(string username, string firstname, string lastname)
        {
            using (var uow = new UnitOfWork())
            {
                var userRepo = uow.getRepository<User>();
                var user = userRepo.getAll().FirstOrDefault(x => x.Username == username && x.FirstName == firstname && x.LastName == lastname);
                if (user != null)
                {
                    user.Validation = AccountState.Unvalidated;
                    emailService.SendEmail(user.Email, "Account unvalidated", "Your account on Conferences Platform wasn't validated");
                }
                uow.saveChanges();
            }
        }


    }
}
