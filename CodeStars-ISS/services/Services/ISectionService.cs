using Model.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Services
{
    public interface ISectionService
    {
        IEnumerable<SectionDTO> getSectionsOfConference(int conferenceId);
        SectionDTO addSection(SectionDTO section);
        void updateSection(SectionDTO section);
        void deleteSection(int id);
        SectionDTO getSectionById(int id);

    }
}
