﻿using Model.Domain;
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
            dto.Collaborators = model.Collaborators;
            dto.ParticipationId = model.ParticipationId;
            dto.SectionId = model.SectionId;
            dto.ProposalState = model.ProposalState;

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
            poco.Collaborators = model.Collaborators;
            poco.SectionId = model.SectionId;
            poco.ParticipationId = model.ParticipationId;
            poco.ProposalState = model.ProposalState;
            return poco;
        }
    }
}
