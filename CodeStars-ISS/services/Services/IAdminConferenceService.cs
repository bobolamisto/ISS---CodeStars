using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;

namespace services.Services
{
    public interface IAdminConferenceService
    {
        /// <summary>
        /// Changes the State of the Conference from Proposed to Building
        /// </summary>
        void AcceptConferenceProposal(Conference conference);

        /// <summary>
        /// Changes the State of the Conference from Proposed/Building to Rejected
        /// Reason: Conferences can be rejected even after they were put in the Building state
        /// </summary>
        void DeclineConferencProposal(Conference conference);

        /// <summary>
        /// Changes the State of the Conference from Building to Accepted.
        /// </summary>
        void AcceptFullConference(Conference conference);

        /// <summary>
        ///  Gets all the conferences that are in a specific state.
        /// </summary>
        IEnumerable<Conference> GetFilteredConferences(ConferenceState conferenceState);

    }
}
