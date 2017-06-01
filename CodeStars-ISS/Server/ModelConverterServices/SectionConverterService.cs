using Model.DTOModels;
using Model.POCOModels;
using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelConverterServices
{
    public class SectionConverterService : IModelConverterService<Section, SectionDTO>
    {
        public SectionDTO convertToDTOModel(Section model)
        {
            SectionDTO dto = new SectionDTO();
            dto.Id = model.Id;
            dto.Title = model.Title;
            dto.StartDate = model.StartDate.ToString();
            dto.EndDate = model.EndDate.ToString();
            dto.ChairId = model.ChairId;
            dto.ConferenceId = model.ConferenceId;
            return dto;
        }

        public Section convertToPOCOModel(SectionDTO model)
        {
            Section poco = new Section();
            poco.Id = model.Id;
            poco.Title = model.Title;
            poco.StartDate = DateTime.Parse(model.StartDate);
            poco.EndDate = DateTime.Parse(model.EndDate);
            poco.ChairId = model.ChairId;
            poco.ConferenceId = model.ConferenceId;
            return poco;
        }

        public IEnumerable<SectionDTO> convertToDTOList(IEnumerable<Section> sections)
        {
            return sections.Select(convertToDTOModel).ToList();
        }
    }
}
