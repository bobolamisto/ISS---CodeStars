using System.Linq;
using Model.Domain;
using Model.DTOModels;
using Persistence.Repository;
using services.Services;
using Server.ModelConverterServices;

namespace Server.ServicesImplementation
{
    public class PaperService : IPaperService
    {
        private ProposalConverterService _proposalConverter;
        private User_ConferenceConverterService _userConferenceConverter;

        public ProposalDTO AddPaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            var userConference = SearchUserConference(idUser, idConferinta);
            if (userConference == null) return null;
            using (var uow = new UnitOfWork())
            {
                var paperRepo = uow.getRepository<Proposal>();
                var paper = _proposalConverter.convertToPOCOModel(paperDto);
                var paperReturned = paperRepo.save(paper);
                uow.saveChanges();

                return _proposalConverter.convertToDTOModel(paperReturned);
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

        public ProposalDTO UpdatePaper(int idUser, int idConferinta, ProposalDTO paperDto)
        {
            var userConference = SearchUserConference(idUser, idConferinta);
            if (userConference == null) return null;
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
