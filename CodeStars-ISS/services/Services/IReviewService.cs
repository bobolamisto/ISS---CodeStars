using Model.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Services
{
    public interface IReviewService
    {
        ReviewDTO addReview(ReviewDTO model);
        void updateReview(ReviewDTO model);
        void removeReview(int id);
        IEnumerable<ReviewDTO> getAll();
        ReviewDTO getReview(int id);
    }
}
