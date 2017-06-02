﻿using System;
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

        public ConferenceDTO AddConference(int idUser, Model.DTOModels.ConferenceDTO conferenceDTO)
        {
            using (var uow = new UnitOfWork())
            {
                //adaugare in tabela conferinta
                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
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

        public IEnumerable<Model.DTOModels.ConferenceDTO> GetRelevantConferences(int idUser, UserRole userRole)
        {
            using (var uow = new UnitOfWork())
            {
                var relevantConferences = uow.getRepository<ConferenceDTO>().getAll().Where(conference =>
                {
                    return conference.Participations.Count(userConference => userConference.UserId == idUser && userConference.Role == userRole) != 0;
                });
                return converter.convertToDTOList(relevantConferences);
            }
        }

        public IEnumerable<Model.DTOModels.ConferenceDTO> GetRelevantConferences(int idUser)
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
                var user = conferenceRepo.get(idUser);
                return converter.convertToDTOList(user.Participations.Select(userConference => userConference.Conference));
            }
        }

        public IEnumerable<Model.DTOModels.ConferenceDTO> GetAllConferences()
        {
            using (var uow = new UnitOfWork())
            {
                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
                return converter.convertToDTOList(conferenceRepo.getAll().Where(conference => conference.State == ConferenceState.Accepted));
            }
        }

        public ConferenceDTO ModifyDescription(int idUser, Model.DTOModels.ConferenceDTO conferenceDTO)
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

                var conferenceRepo = uow.getRepository<Model.Domain.ConferenceDTO>();
                conferenceRepo.update(conferenceDTO.Id, converter.convertToPOCOModel(conferenceDTO));
                uow.saveChanges();

                return conferenceDTO;
            }
        }

        public ConferenceDTO FindConference(string startDate, string endDate)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Model.Domain.ConferenceDTO>();
                var conf = repo.getAll().FirstOrDefault(c => c.StartDate.CompareTo(DateTime.Parse(startDate))==0 && c.EndDate.CompareTo(DateTime.Parse(endDate))==0);             
                if (conf == null)
                    return null;
                return converter.convertToDTOModel(conf);
            }
        }
    }
}
