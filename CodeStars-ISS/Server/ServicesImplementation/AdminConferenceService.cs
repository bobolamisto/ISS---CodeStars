using System;
using System.Collections.Generic;
using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using Server.ModelConverterServices;

namespace services.Services
{
    public class AdminConferenceService : IAdminConferenceService
    {
        private ConferenceConverterService converter;

        public AdminConferenceService()
        {
            converter = new ConferenceConverterService();
        }

        public void AcceptConferenceProposal(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Building);
        }

        public void DeclineConferencProposal(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Declined);
        }

        public void AcceptFullConference(int idConference)
        {
            ChangeConferenceState(idConference, ConferenceState.Accepted);
        }

        public IEnumerable<Model.DTOModels.ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
                return converter.convertToDTOList(conferenceRepo.getAll().Where(conference => conference.State == conferenceState));
            }
        }

        private void ChangeConferenceState(int idConference, ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
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
                }
                uow.saveChanges();
            }
        }
    }
}
