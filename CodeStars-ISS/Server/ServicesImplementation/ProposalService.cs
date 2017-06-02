using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;
using Server.ModelConverterServices;
using System;
using System.Collections.Generic;

namespace Server.ServicesImplementation
{
    public class ProposalService : IProposalService
    {
        private ProposalConverterService _proposalConverter;
        private User_ConferenceConverterService _userConferenceConverter;

        public ProposalService()
        {
            _proposalConverter = new ProposalConverterService();
            _userConferenceConverter = new User_ConferenceConverterService();
        }

        public ProposalDTO AddPaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            var userConference = SearchUserConference(idUser, idConferinta);
            if (userConference == null) return null;
            paperDto.ParticipationId = userConference.Id;
            using (var uow = new UnitOfWork())
            {
                var paperRepo = uow.getRepository<Proposal>();
                var paper = _proposalConverter.convertToPOCOModel(paperDto);
                var paperReturned = paperRepo.save(paper);
                uow.saveChanges();

                return _proposalConverter.convertToDTOModel(paperReturned);
            }
        }

        public ProposalDTO FindProposal(string title,string subject,string keywords) { 
            using (var uow=new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll();
                var existing = proposals.FirstOrDefault(p => p.Title == title&&p.Subject==subject&&p.Keywords==keywords);
                if (existing == null)
                    return null;
                return _proposalConverter.convertToDTOModel(existing);
            }
        }

        public IEnumerable<ProposalDTO> GetProposalsOfSection(int sectionId)
        {
            using(var uow=new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll().Where(p => p.SectionId == sectionId);
                return _proposalConverter.convertToDTOList(proposals);
            }
        }

        public IEnumerable<ProposalDTO> GetProposalsToBeReviewed(int idUser, int idConf)
        {
            using(var uow=new UnitOfWork())
            {
                var part = SearchUserConference(idUser, idConf);
                if (part == null || part.Role != UserRole.Chair)
                    return null;
                var participations = uow.getRepository<User_Conference>().getAll().Where(uc => uc.ConferenceId == idConf);
                var proposals = uow.getRepository<Proposal>().getAll();
                List<ProposalDTO> items = new List<ProposalDTO>();
                foreach(var p in participations)
                {
                    foreach(var proposal in proposals)
                    {
                        //ne trebuie un enum pentru stare proposal
                    }
                }
                return items;
            }
        }

        public ProposalDTO GetUserProposal(int idUser, int idConferinta)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Proposal>();
                var participation = SearchUserConference(idUser, idConferinta);
                if (participation == null)
                    return null;
                var proposal = repo.getAll().FirstOrDefault(p => p.ParticipationId == participation.Id);
                if (proposal == null)
                    return null;
                return _proposalConverter.convertToDTOModel(proposal);
            }
        }

        public IEnumerable<ProposalDTO> GetUserProposals(int idUser)
        {
            using (var uow=new UnitOfWork())
            {
                var conferences = uow.getRepository<Conference>().getAll();
                List<ProposalDTO> items = new List<ProposalDTO>();
                foreach(var c in conferences)
                {
                    var proposal = GetUserProposal(idUser, c.Id);
                    if (proposal != null)
                    {
                        items.Add(proposal);
                    }
                }
                return items;
            }
        }

        public ProposalDTO RemovePaper(int idUser, int idConferinta, int idPaper)
        {
            var userConference = SearchUserConference(idUser, idConferinta);
            if (userConference == null) return null;
            using (var uow = new UnitOfWork())
            {
                var paperRepo = uow.getRepository<Proposal>();
                var paper = paperRepo.get(idPaper);
                //se returneaza de 2 ori null in metoda asta, ar trebuii sa folosim exceptii, asa nu o sa se stie de ce s-a returnat null
                if (paper == null) return null;

                paperRepo.remove(idPaper);
                uow.saveChanges();
                return _proposalConverter.convertToDTOModel(paper);
            }
        }

        public ProposalDTO UpdatePaper( ProposalDTO paperDto)
        {
            using (var uow = new UnitOfWork())
            {
                var paperRepo = uow.getRepository<Proposal>();
                var paper = paperRepo.get(paperDto.Id);
                if (paper == null) return null;

                paperRepo.update(paperDto.Id, _proposalConverter.convertToPOCOModel(paperDto));
                uow.saveChanges();
                return _proposalConverter.convertToDTOModel(paperRepo.get(paperDto.Id));
            }
        }

        //TODO: de extras intr-un helper
        private User_Conference SearchUserConference(int idUser, int idConferinta)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.getRepository<User_Conference>()
                    .getAll()
                    .FirstOrDefault(userConference => userConference.UserId == idUser && userConference.ConferenceId == idConferinta);
            }
        }
    }
}
