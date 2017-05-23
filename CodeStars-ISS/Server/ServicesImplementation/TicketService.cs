using System;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;
using Server.ModelConverterServices;

namespace Server.ServicesImplementation
{
    public class TicketService : ITicketService
    {
        private User_ConferenceConverterService _converter;

        public TicketService()
        {
            _converter = new User_ConferenceConverterService();
        }

        public User_ConferenceDTO BuyTicket(int idUser, int idConference)
        {
            using (var uow = new UnitOfWork())
            {
                var userConferenceRepository = uow.getRepository<User_Conference>();
                var userConference = new User_Conference()
                {
                    ConferenceId = idConference,
                    UserId = idUser
                };
                var userConferenceReturned = userConferenceRepository.save(userConference);
                uow.saveChanges();

                return _converter.convertToDTOModel(userConferenceReturned);
            }
        }

        public float GetTicketPrice(int idConference)
        {
            using (var uow = new UnitOfWork())
            {
                var conference = uow.getRepository<Conference>().get(idConference);
                return conference == null ? default(float) : conference.Price;
            }
        }
    }
}
