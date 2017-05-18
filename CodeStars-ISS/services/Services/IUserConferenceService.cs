using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;

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
        void AddConference(int idUser, Conference conference);

        /// <summary>
        /// Used for getting a list of conferences for a specific user with a SPECIFIC USER ROLE.
        /// Gets the conferences in wich the user is participating, and has a specific role.
        /// </summary>
        IEnumerable<Conference> GetRelevantConferences(int idUser, UserRole userRole);

        /// <summary>
        /// Used for getting a list of conferences for a specific user NO MATTER THE ROLE.
        /// Gets the conferences in wich the user is participating, and has a specific role.
        /// </summary>
        IEnumerable<Conference> GetRelevantConferences(int idUser);

        /// <summary>
        /// Gets all the ACCEPTED Conferences
        /// </summary>
        IEnumerable<Conference> GetAllConferences();

        /// <summary>
        /// Used for modyfing the description of a conference. The conference Id MUST BE SET before calling this method.
        /// If the user is not the owner/proposer of the conference, the method will have no efect.
        /// If the conference has no current description, the method wil add a new description.
        /// </summary>
        void ModifyDescription(int idUser, Conference conference);
    }
}