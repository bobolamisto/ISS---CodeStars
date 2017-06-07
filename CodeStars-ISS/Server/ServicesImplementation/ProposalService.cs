using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;
using Server.ModelConverterServices;
using System;
using System.Collections.Generic;
using Model.POCOModels;

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
            paperDto.ProposalState = ProposalState.Pending;
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

        public void addProposalToSection(int idProposal, int idSection)
        {
            using(var uow=new UnitOfWork())
            {
                var proposal = uow.getRepository<Proposal>().get(idProposal);
                var section = uow.getRepository<Section>().get(idSection);
                section.Proposals.Add(proposal);
                uow.saveChanges();
            }
        }

        
        public ProposalState evaluateProposal(int id)
        {
            var okRejected = true;
            var okAccepted = true;
            var proposal = this.getProposalById(id);
            using (var uow = new UnitOfWork())
            {
                var reviews = uow.getRepository<Review>().getAll().Where(r => r.ProposalId.Equals(id));
                
                foreach(Review r in reviews)
                {
                    if (r.Mark.Equals(Mark.Accept.ToString()) || r.Mark.Equals(Mark.StrongAccept.ToString()) || r.Mark.Equals(Mark.WeakAccept.ToString()))
                        okRejected = false;
                    else
                        okAccepted = false;
                }
            }
            if (okAccepted == true)
              proposal.ProposalState = ProposalState.Accepted;

            if (okRejected == false)
                proposal.ProposalState = ProposalState.Declined;

            else
                proposal.ProposalState = ProposalState.Pending;

            this.UpdatePaper(proposal);
            return proposal.ProposalState;

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

        public ProposalDTO getProposalById(int id)
        {
            using(var uow=new UnitOfWork())
            {
                var proposal = uow.getRepository<Proposal>().get(id);
                if (proposal == null)
                    return null;
                return _proposalConverter.convertToDTOModel(proposal);
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

        public IEnumerable<ProposalDTO> getProposalsOutsideSections(int conferenceId)
        {
            using(var uow=new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll().Where(p => p.Participation.ConferenceId == conferenceId);
                proposals = proposals.Where(p => p.SectionId == null);
                return _proposalConverter.convertToDTOList(proposals);
            }
        }

        public IEnumerable<ProposalDTO> GetProposalsByState(ProposalState proposalState,int confId)
        {
            using(var uow = new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll().Where(proposal => proposal.ProposalState == proposalState&&proposal.Participation.ConferenceId==confId);
                return _proposalConverter.convertToDTOList(proposals);
            }
        }

        public IEnumerable<ProposalDTO> GetProposalsByState(int idUser, ProposalState proposalState)
        {
            using (var uow = new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll().Where(proposal => proposal.Participation.UserId == idUser && proposal.ProposalState == proposalState);
                return _proposalConverter.convertToDTOList(proposals);
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

        public ProposalDTO RemovePaper(int idPaper)
        {
        //    var userConference = SearchUserConference(idUser, idConferinta);
        //    if (userConference == null) return null;
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

        public void removeProposalFromAnySection(int idProposal)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Proposal>();
                var proposal = repo.get(idProposal);
                proposal.SectionId = null;
                repo.update(proposal.Id, proposal);
                uow.saveChanges();
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

        public void evaluateAllProposalsForAConference(int conferenceId)
        {           
            using (var uow = new UnitOfWork())
            {               
                var proposals = uow.getRepository<Proposal>().getAll().Where(r => r.Participation.ConferenceId.Equals(conferenceId));
                foreach (Proposal r in proposals)
                {
                    var reviews = uow.getRepository<Review>().getAll().Where(e => e.ProposalId.Equals(r.Id));
                    if (reviews.Count() >= 3)
                    {
                        this.evaluateProposal(r.Id);
                    }
                }
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

        public void addColaborator(string username, int id)
        {
            using (var uow = new UnitOfWork())
            {
                var proposals = uow.getRepository<Proposal>().getAll();
                foreach(Proposal p in proposals)
                {
                    if (p.Id.Equals(id))
                    {
                        p.Collaborators += username+"; ";
                    }
                }
                uow.saveChanges();
            }
        }

        
    }
}
