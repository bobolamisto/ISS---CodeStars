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
    public class ConferenceConverterService : IModelConverterService<Conference, ConferenceDTO>
    {
        public ConferenceDTO convertToDTOModel(Conference model)
        {
            Model.DTOModels.ConferenceDTO dto = new Model.DTOModels.ConferenceDTO();
            dto.Id = model.Id;
            dto.Name = model.Name;
            dto.Edition = model.Edition;
            dto.StartDate = model.StartDate.ToString();
            dto.EndDate = model.EndDate.ToString();
            dto.Domain = model.Domain;
            dto.AbstractDeadline = model.AbstractDeadline.ToString();
            dto.FullPaperDeadline = model.FullPaperDeadline.ToString();
            dto.MainDescription = model.MainDescription;
            dto.Price = model.Price;
            dto.State = model.State.ToString();
            return dto;
        }

        public Conference convertToPOCOModel(Model.DTOModels.ConferenceDTO model)
        {
            Conference poco = new Conference();
            poco.Id = model.Id;
            poco.Name = model.Name;
            poco.Edition = model.Edition;
            poco.StartDate = DateTime.Parse(model.StartDate);
            poco.EndDate = DateTime.Parse(model.EndDate);
            poco.Domain = model.Domain;
            poco.AbstractDeadline = DateTime.Parse( model.AbstractDeadline);
            poco.FullPaperDeadline =DateTime.Parse( model.FullPaperDeadline);
            poco.MainDescription = model.MainDescription;
            poco.Price = model.Price;
            poco.State = (ConferenceState) Enum.Parse(typeof(ConferenceState),model.State,true);
            return poco;
        }

        public IEnumerable<ConferenceDTO> convertToDTOList(IEnumerable<Conference> conferences)
        {
            return conferences.Select(convertToDTOModel).ToList();
        }
        
    }
}
