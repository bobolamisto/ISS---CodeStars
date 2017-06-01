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
    public class ReviewConverterService : IModelConverterService<Review, ReviewDTO>
    {
        public IEnumerable<ReviewDTO> convertToDTOList(IEnumerable<Review> models)
        {
            return models.Select(convertToDTOModel).ToList();
        }

        public ReviewDTO convertToDTOModel(Review model)
        {
            ReviewDTO dto = new ReviewDTO();
            dto.Id = model.Id;
            dto.Mark = model.Mark.ToString();
            dto.ProposalId = model.ProposalId;
            dto.ReviewerId = model.ReviewerId;
            dto.Recommendation = model.Recommendation;
            return dto;
        }

        public Review convertToPOCOModel(ReviewDTO model)
        {
            Review poco = new Review();
            poco.Id = model.Id;
            poco.Mark = (Mark) Enum.Parse(typeof(Mark),model.Mark,true);
            poco.ProposalId = model.ProposalId;
            poco.ReviewerId = model.ReviewerId;
            poco.Recommendation = model.Recommendation;
            return poco;
        }
    }
}
