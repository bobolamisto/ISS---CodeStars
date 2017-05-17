using System;
using System.Collections.Generic;
using System.Linq;
using Model.Domain;
using Persistence.Repository;

namespace services.Services
{
    public class AdminConferenceService : IAdminConferenceService
    {
        public void AcceptConferenceProposal(Conference conference)
        {
            ChangeConferenceState(conference, ConferenceState.Building);
        }

        public void DeclineConferencProposal(Conference conference)
        {
            ChangeConferenceState(conference, ConferenceState.Declined);
        }

        public void AcceptFullConference(Conference conference)
        {
            ChangeConferenceState(conference, ConferenceState.Accepted);
        }

        public IEnumerable<Conference> GetFilteredConferences(ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return conferenceRepo.getAll().Where(conference => conference.State == conferenceState);
            }
        }

        private void ChangeConferenceState(Conference conference, ConferenceState conferenceState)
        {
            using (var uow = new UnitOfWork())
            {
                conference.State = conferenceState;
                uow.saveChanges();
            }
        }
    }
}
