using System.Collections.Generic;
using Model.Domain;
using Model.DTOModels;

namespace services.Services
{
    /// <summary>
    /// Interface used for providing the functionalities for the basic user.
    /// </summary>
    public interface IUserConferenceService
    {
        /// <summary>
        /// Adds the conference in which the user will be the proposer.
        /// </summary>
        ConferenceDTO AddConference(int idUser, ConferenceDTO conferenceDTO);

        /// <summary>
        /// Used for getting a list of conferences for a specific user with a SPECIFIC USER ROLE.
        /// Gets the conferences in wich the user is participating, and has a specific role.
        /// </summary>
        IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser, UserRole userRole);

        /// <summary>
        /// Used for getting a list of conferences for a specific user NO MATTER THE ROLE.
        /// Gets the conferences in wich the user is participating, and has a specific role.
        /// </summary>
        IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser);

        /// <summary>
        /// Gets all the ACCEPTED Conferences
        /// </summary>
        IEnumerable<ConferenceDTO> GetAllConferences();

        /// <summary>
        /// Used for modyfing the description of a conference. The conference Id MUST BE SET before calling this method.
        /// If the user is not the owner/proposer of the conference, the method will have no efect.
        /// If the conference has no current description, the method wil add a new description.
        /// </summary>
        ConferenceDTO ModifyDescription(int idUser,ConferenceDTO conferenceDTO);

        ConferenceDTO FindConference(string startDate, string endDate);
        IEnumerable<UserDTO> getPCMembersForConference(int conferenceId);
        IEnumerable<UserDTO> getPCMembersAvailableForSectionChair(int conferenId);
        UserDTO getChairOfConference(int confId);
    }
}