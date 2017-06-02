using services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTOModels;
using Model.Domain;
using Server.ModelConverterServices;
using Persistence.Repository;

namespace Server.ServicesImplementation
{
    public class ReviewService : IReviewService
    {
        private IModelConverterService<Review, ReviewDTO> converter;
        public ReviewService()
        {
            converter = new ReviewConverterService();
        }
        public ReviewDTO addReview(ReviewDTO model)
        {
            using(var uow=new UnitOfWork())
            {
                var review = converter.convertToPOCOModel(model);
                var repo = uow.getRepository<Review>();
                var added = repo.save(review);
                uow.saveChanges();
                if (added == null)
                    return null;
                return converter.convertToDTOModel(added);
            }
        }

        public IEnumerable<ReviewDTO> getAll()
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Review>();
                return converter.convertToDTOList(repo.getAll());
            }
        }

        public IEnumerable<ReviewDTO> getAllForProposal(int proposalId)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Review>();
                return converter.convertToDTOList(repo.getAll().Where(review => review.ProposalId == proposalId));
            }
        }

        public ReviewDTO getReview(int id)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Review>();
                return converter.convertToDTOModel(repo.get(id));
            }
        }

        public void removeReview(int id)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Review>();
                repo.remove(id);
                uow.saveChanges();
            }
        }

        public void updateReview(ReviewDTO model)
        {
            using (var uow = new UnitOfWork())
            {
                var repo = uow.getRepository<Review>();
                repo.update(model.Id, converter.convertToPOCOModel(model));
                uow.saveChanges();
            }
        }
    }
}
