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
using Model.Domain;

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
                var proposalsRepo = uow.getRepository<Proposal>();
                foreach(var p in existing.Proposals)
                {
                    p.SectionId = null;
                    proposalsRepo.update(p.Id, p);
                    uow.saveChanges();
                }
                repo.remove(id);
                uow.saveChanges();
            }
        }

        public SectionDTO getSectionById(int id)
        {
            using(var uow=new UnitOfWork())
            {
                var repo = uow.getRepository<Section>();
                var found = repo.get(id);
                if (found == null)
                    return null;
                return converter.convertToDTOModel(found);
            }
        }

        public IEnumerable<SectionDTO> getSectionsOfConference(int conferenceId)
        {
            using(var uow=new UnitOfWork())
            {
                var sections = uow.getRepository<Conference>().get(conferenceId).Sections;
                sections.OrderBy(s => s.StartDate);
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
