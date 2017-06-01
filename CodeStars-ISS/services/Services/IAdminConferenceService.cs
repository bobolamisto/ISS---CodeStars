using System.Collections.Generic;
using Model.Domain;
using Model.DTOModels;

namespace services.Services
{
    public interface IAdminConferenceService
    {
        /// <summary>
        /// Changes the State of the Conference from Proposed to Building
        /// </summary>
        void AcceptConferenceProposal(int idConference);

        /// <summary>
        /// Changes the State of the Conference from Proposed/Building to Rejected
        /// Reason: Conferences can be rejected even after they were put in the Building state
        /// </summary>
        void DeclineConferencProposal(int idConference);

        /// <summary>
        /// Changes the State of the Conference from Building to Accepted.
        /// </summary>
        void AcceptFullConference(int idConference);

        /// <summary>
        ///  Gets all the conferences that are in a specific state.
        /// </summary>
        IEnumerable<Model.DTOModels.ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState);

        void validateAccount(string username, string firstname, string lastname);

    }
}
