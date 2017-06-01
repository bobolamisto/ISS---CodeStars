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
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> getAllForProposal(int proposalId)
        {
            throw new NotImplementedException();
        }

        public ReviewDTO getReview(int id)
        {
            throw new NotImplementedException();
        }

        public void removeReview(int id)
        {
            throw new NotImplementedException();
        }

        public void updateReview(ReviewDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
