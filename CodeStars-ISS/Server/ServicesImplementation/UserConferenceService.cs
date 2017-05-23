using System.Collections.Generic;
using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using Server.ModelConverterServices;

namespace services.Services
{
    public class UserConferenceService : IUserConferenceService
    {
        private ConferenceConverterService converter;

        public UserConferenceService()
        {
            converter = new ConferenceConverterService();
        }

        public ConferenceDTO AddConference(int idUser, ConferenceDTO conferenceDTO)
        {
            using (var uow = new UnitOfWork())
            {
                //adaugare in tabela conferinta
                var conferenceRepo = uow.getRepository<Conference>();
                conferenceDTO.Edition = conferenceRepo.getAll().Count(c => c.Name.Equals(conferenceDTO.Name)) + 1;
                var conference = conferenceRepo.save(converter.convertToPOCOModel(conferenceDTO));
                uow.saveChanges();
                conferenceDTO.Id = conference.Id;

                //adaugare in tabela de legatuara
                var userConfereceRepo = uow.getRepository<User_Conference>();
                var userConference = new User_Conference
                {
                    ConferenceId = conferenceDTO.Id,
                    Role = UserRole.Proposer,
                    UserId = idUser
                };
                userConfereceRepo.save(userConference);
                uow.saveChanges();

                return conferenceDTO;
            }
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser, UserRole userRole)
        {
            using (var uow = new UnitOfWork())
            {
                var relevantConferences = uow.getRepository<Conference>().getAll().Where(conference =>
                {
                    return conference.Participations.Count(userConference => userConference.UserId == idUser && userConference.Role == userRole) != 0;
                });
                return converter.convertToDTOModel(relevantConferences);
            }
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                var user = conferenceRepo.get(idUser);
                return converter.convertToDTOModel(user.Participations.Select(userConference => userConference.Conference));
            }
        }

        public IEnumerable<ConferenceDTO> GetAllConferences()
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return converter.convertToDTOModel(conferenceRepo.getAll().Where(conference => conference.State == ConferenceState.Accepted));
            }
        }

        public ConferenceDTO ModifyDescription(int idUser, ConferenceDTO conferenceDTO)
        {
            using (var uow = new UnitOfWork())
            {
                //verific daca userul care modifica conferinta este cel care a propus, daca nu -> returnez null
                var userConferenceRepo = uow.getRepository<User_Conference>();
                var isUserProposer =
                    userConferenceRepo.getAll()
                        .Any(userConference => userConference.UserId == idUser && 
                        userConference.Role == UserRole.Proposer && 
                        userConference.ConferenceId == conferenceDTO.Id);
                if (!isUserProposer)
                    return null;

                var conferenceRepo = uow.getRepository<Conference>();
                conferenceRepo.update(conferenceDTO.Id, converter.convertToPOCOModel(conferenceDTO));
                uow.saveChanges();

                return conferenceDTO;
            }
        }
    }
}
