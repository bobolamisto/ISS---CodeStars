using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Persistence.Repository;

namespace services.Services
{
    public class UserConferenceService : IUserConferenceService
    {
        public void AddConference(int idUser, Conference conference)
        {
            using (var uow = new UnitOfWork())
            {
                //adaugare in tabela conferinta
                var conferenceRepo = uow.getRepository<Conference>();
                conferenceRepo.save(conference);
                uow.saveChanges();

                //adaugare in tabela de legatuara
                var userConfereceRepo = uow.getRepository<User_Conference>();
                var userConference = new User_Conference
                {
                    ConferenceId = conference.Id,
                    Role = UserRole.Proposer,
                    UserId = idUser
                };
                userConfereceRepo.save(new User_Conference());
                uow.saveChanges();
            }
        }

        public IEnumerable<Conference> GetRelevantConferences(int idUser, UserRole userRole)
        {
                var relevantConferences = GetRelevantConferences(idUser).Where(conference =>
                {
                    return conference.Participations.Count(userConference => userConference.UserId == idUser && userConference.Role == userRole) != 0; //are cel putin un rol in conferinta respectiva
                });
                return relevantConferences;
        }

        public IEnumerable<Conference> GetRelevantConferences(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                var user = conferenceRepo.get(idUser);
                return user.Participations.Select(userConference => userConference.Conference);
            }
        }

        public IEnumerable<Conference> GetAllConferences()
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return conferenceRepo.getAll();
            }
        }

        public void ModifyDescription(int idUser, Conference conference)
        {
            using (var uow = new UnitOfWork())
            {
                var userConferenceRepo = uow.getRepository<User_Conference>();
                var isUserProposer =
                    userConferenceRepo.getAll()
                        .Any(userConference => userConference.UserId == idUser && 
                        userConference.Role == UserRole.Proposer && 
                        userConference.ConferenceId == conference.Id);
                //verific daca userul care modifica conferinta este cel care a propus
                if (!isUserProposer)
                    return;

                var conferenceRepo = uow.getRepository<Conference>();
                conferenceRepo.update(conference.Id, conference);

                uow.saveChanges();
            }
        }
    }
}
