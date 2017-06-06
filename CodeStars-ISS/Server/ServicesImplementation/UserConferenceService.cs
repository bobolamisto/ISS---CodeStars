using System;
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
        private UserConverterService userConverter;

        public UserConferenceService()
        {
            converter = new ConferenceConverterService();
            userConverter = new UserConverterService();
        }

        public ConferenceDTO AddConference(int idUser, ConferenceDTO conferenceDTO)
        {
            using (var uow = new UnitOfWork())
            {
                //adaugare in tabela conferinta
                var conferenceRepo = uow.getRepository<Conference>();
                conferenceDTO.Edition = conferenceRepo.getAll().Count(c => c.Name.Equals(conferenceDTO.Name)) + 1;
                var conference = conferenceRepo.save(converter.convertToPOCOModel(conferenceDTO));
                conferenceDTO.Id = conference.Id;

                //adaugare in tabela de legatuara
                var userConfereceRepo = uow.getRepository<User_Conference>();
                var userConference = new User_Conference
                {
                    ConferenceId = conferenceDTO.Id,
                    Role = UserRole.Chair,
                    UserId = idUser
                };
                userConfereceRepo.save(userConference);
                uow.saveChanges();

                return conferenceDTO;
            }
        }

        public ConferenceDTO updateConference(ConferenceDTO conferenceDTO)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Conference>();
                var conf = repo.get(conferenceDTO.Id);
                if (conf == null)
                    return null;
                repo.update(conferenceDTO.Id, converter.convertToPOCOModel(conferenceDTO));
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
                return converter.convertToDTOList(relevantConferences);
            }
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                var user = conferenceRepo.get(idUser);
                return converter.convertToDTOList(user.Participations.Select(userConference => userConference.Conference));
            }
        }

        public IEnumerable<ConferenceDTO> GetAllConferences()
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Conference>();
                return converter.convertToDTOList(conferenceRepo.getAll().Where(conference => conference.State == ConferenceState.Accepted));
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
                        userConference.Role == UserRole.Chair && 
                        userConference.ConferenceId == conferenceDTO.Id);
                if (!isUserProposer)
                    return null;

                var conferenceRepo = uow.getRepository<Conference>();
                conferenceRepo.update(conferenceDTO.Id, converter.convertToPOCOModel(conferenceDTO));
                uow.saveChanges();

                return conferenceDTO;
            }
        }

        public ConferenceDTO FindConference(string startDate, string endDate)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Conference>();
                var conf = repo.getAll().FirstOrDefault(c => c.StartDate.CompareTo(DateTime.Parse(startDate))==0 && c.EndDate.CompareTo(DateTime.Parse(endDate))==0);             
                if (conf == null)
                    return null;
                return converter.convertToDTOModel(conf);
            }
        }

        public IEnumerable<UserDTO> getPCMembersForConference(int conferenceId)
        {
            using(var uow=new UnitOfWork())
            {
                var conference = uow.getRepository<Conference>().get(conferenceId);
                List<UserDTO> users = new List<UserDTO>();
                var usersConverter = new UserConverterService();
                var usersRepo = uow.getRepository<User>();
                foreach (var u in conference.Participations)
                    if (u.Role == UserRole.Chair || u.Role == UserRole.CoChair || u.Role == UserRole.Reviewer)
                        users.Add(usersConverter.convertToDTOModel(usersRepo.get(u.UserId)));
                return users;
            }
        }

        public IEnumerable<UserDTO> getPCMembersAvailableForSectionChair(int conferenId)
        {
            using(var uow=new UnitOfWork())
            {
                var sections = uow.getRepository<Conference>().get(conferenId).Sections;
                var availableMembers = new List<UserDTO>();
                var members = getPCMembersForConference(conferenId);
                foreach(var member in members)
                {
                    var isChair = sections.FirstOrDefault(s => s.ChairId == member.Id);
                    if (isChair == null)
                        availableMembers.Add(member);
                }
                return availableMembers;
            }
        }

        public UserDTO getChairOfConference(int confId)
        {
            using(var uow=new UnitOfWork())
            {
                var part = uow.getRepository<User_Conference>().getAll().FirstOrDefault(p => p.ConferenceId == confId &&
                                                                        p.Role == UserRole.Chair);
                if (part == null)
                    return null;
                return userConverter.convertToDTOModel(part.User);
            }
        }
        public User_ConferenceDTO addUserConference(User_ConferenceDTO userConference)
        {
            using (var uow = new UnitOfWork())
            { 
                var userConfereceRepo = uow.getRepository<User_Conference>();
                var newUserConference = userConfereceRepo.save(converter.convertToPOCOModel(userConference));
                uow.saveChanges();
                userConference.Id = newUserConference.Id;
                return userConference;
            }
        }
    }
}
