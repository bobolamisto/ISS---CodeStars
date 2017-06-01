using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOModels;
using Model.POCOModels;
using Server.ModelConverterServices;
using Persistence.Repository;

namespace Server.ServicesImplementation
{
    public class SectionService : ISectionService
    {
        private IModelConverterService<Section, SectionDTO> converter;
        public SectionService()
        {
            converter = new SectionConverterService();
        }
        public SectionDTO addSection(SectionDTO section)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Section>();
                var existing = repo.getAll().FirstOrDefault(s => s.ConferenceId == section.ConferenceId &&
                                                                  s.EndDate == DateTime.Parse(section.EndDate) &&
                                                                  s.StartDate == DateTime.Parse(section.StartDate));
                if (existing != null)
                    return null;
                var saved = repo.save(converter.convertToPOCOModel(section));
                uow.saveChanges();
                return converter.convertToDTOModel(saved);
            }
        }

        public void deleteSection(int id)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Section>();
                var existing = repo.getAll().FirstOrDefault(s => s.Id == id);
                if (existing == null)
                    return;
                repo.remove(id);
                uow.saveChanges();
            }
        }

        public IEnumerable<SectionDTO> getSectionsOfConference(int conferenceId)
        {
            using(var uow=new UnitOfWork())
            {
                var sections = uow.getRepository<Section>().getAll().Where(s => s.ConferenceId == conferenceId).ToList();
                return converter.convertToDTOList(sections);
            }
        }

        public void updateSection(SectionDTO section)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Section>();
                var existing = repo.getAll().FirstOrDefault(s => s.Id == section.Id);
                if (existing == null)
                    return;
                repo.update(section.Id, converter.convertToPOCOModel(section));
                uow.saveChanges();
            }
        }
    }
}
