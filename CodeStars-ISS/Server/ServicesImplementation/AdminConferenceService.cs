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

        public IEnumerable<ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return converter.convertToDTOModel(conferenceRepo.getAll().Where(conference => conference.State == conferenceState));
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
    }
}
