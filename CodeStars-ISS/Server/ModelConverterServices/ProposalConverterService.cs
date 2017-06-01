using Model.Domain;
using Model.DTOModels;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelConverterServices
{
    public class ProposalConverterService : IModelConverterService<Proposal, ProposalDTO>
    {
        public IEnumerable<ProposalDTO> convertToDTOList(IEnumerable<Proposal> models)
        {
            return models.Select(convertToDTOModel).ToList();
        }

        public ProposalDTO convertToDTOModel(Proposal model)
        {
            ProposalDTO dto = new ProposalDTO();
            dto.Id = model.Id;
            dto.Title = model.Title;
            dto.Subject = model.Subject;
            dto.Abstract = model.Abstract;
            dto.FullPaper = model.FullPaper;
            dto.Keywords = model.Keywords;
            dto.ParticipationId = model.ParticipationId;
            return dto;
        }

        public Proposal convertToPOCOModel(ProposalDTO model)
        {
            Proposal poco = new Proposal();
            poco.Id = model.Id;
            poco.Title = model.Title;
            poco.Subject = model.Subject;
            poco.Abstract = model.Abstract;
            poco.FullPaper = model.FullPaper;
            poco.Keywords = model.Keywords;
            poco.ParticipationId = model.ParticipationId;
            return poco;
        }
    }
}
