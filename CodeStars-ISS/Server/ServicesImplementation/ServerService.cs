﻿using services.Services;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using Model.Domain;
using Model.DTOModels;

namespace Server.ServicesImplementation
{
    public class ServerService : MarshalByRefObject, IServerService
    {
        private IUserService _userService;
        private IUserConferenceService _userConferenceService;
        private IAdminConferenceService _adminConferenceService;
        private IAdminUserChekerService _adminUserCheckerService;

        public ServerService(IUserService userservice, IUserConferenceService userconferenceservice, IAdminConferenceService adminconferenceservice)
        {
            _userService = userservice;
            _userConferenceService = userconferenceservice;
            _adminConferenceService = adminconferenceservice;

        }

        //nu am modificat construcotrul pentru a nu trebuii sa intru iar in controller sa modific
        //servicii o sa mai adaugam, eu zic sa le setam asa, nu sa modificam constructorul de fiecare data
        public void SetAdminUserCheckerService(IAdminUserChekerService service)
        {
            _adminUserCheckerService = service;
        }

        //methods from IUserService
        public UserDTO findUser(int id)
        {
            return _userService.findUser(id);
        }

        public UserDTO logIn(string username, string password)
        {
            return _userService.logIn(username, password);
        }

        public UserDTO createAccount(UserDTO user)
        {
            return _userService.createAccount(user);
        }

        public UserDTO removeAccount(int idUser)
        {
            return _userService.removeAccount(idUser);
        }

        public UserDTO updateAccount(UserDTO user)
        {
            return _userService.updateAccount(user);
        }

        public IEnumerable<UserDTO> findAll()
        {
            return _userService.findAll();
        }


        //methods from IUserConferenceService
        public ConferenceDTO AddConference(int idUser, ConferenceDTO conference)
        {
            return _userConferenceService.AddConference(idUser, conference);
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser, UserRole userRole)
        {
            return _userConferenceService.GetRelevantConferences(idUser, userRole);
        }

        public IEnumerable<ConferenceDTO> GetRelevantConferences(int idUser)
        {
            return _userConferenceService.GetRelevantConferences(idUser);
        }

        public IEnumerable<ConferenceDTO> GetAllConferences()
        {
            return _userConferenceService.GetAllConferences();
        }

        public ConferenceDTO ModifyDescription(int idUser, ConferenceDTO conference)
        {
            return _userConferenceService.ModifyDescription(idUser, conference);
        }


        //methods from IAdminConferenceService
        public void AcceptConferenceProposal(int idConference)
        {
            _adminConferenceService.AcceptConferenceProposal(idConference);
        }

        public void DeclineConferencProposal(int idConference)
        {
            _adminConferenceService.DeclineConferencProposal(idConference);
        }

        public void AcceptFullConference(int idConference)
        {
            _adminConferenceService.AcceptFullConference(idConference);
        }

        public IEnumerable<ConferenceDTO> GetFilteredConferences(ConferenceState conferenceState)
        {
            return _adminConferenceService.GetFilteredConferences(conferenceState);
        }

        //methods from IAdminUserCheckerService
        public UserDTO AcceptNewUser(UserDTO userDto)
        {
            return _adminUserCheckerService.AcceptNewUser(userDto);
        }

        public UserDTO RejectNewUser(UserDTO userDto)
        {
            return _adminUserCheckerService.AcceptNewUser(userDto);
        }
    }
}
