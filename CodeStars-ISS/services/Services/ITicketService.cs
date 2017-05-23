using Model.DTOModels;

namespace services.Services
{
    public interface ITicketService
    {
        /// <summary>
        /// Adds a User_Conference relation
        /// </summary>
        User_ConferenceDTO BuyTicket(int idUser, int idConference);

        /// <summary>
        /// Gets thr price for a certain conference
        /// </summary>
        float GetTicketPrice(int idConference);
    }
}
