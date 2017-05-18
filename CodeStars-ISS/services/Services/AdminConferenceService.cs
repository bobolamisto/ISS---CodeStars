using System;
using System.Collections.Generic;
using System.Linq;
using Model.Domain;
using Persistence.Repository;

namespace services.Services
{
    public class AdminConferenceService : IAdminConferenceService
    {
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

        public IEnumerable<Conference> GetFilteredConferences(ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return conferenceRepo.getAll().Where(conference => conference.State == conferenceState);
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
