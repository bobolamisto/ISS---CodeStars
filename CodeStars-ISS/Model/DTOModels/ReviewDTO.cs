using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOModels
{
    [Serializable]
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Recommendation { get; set; }
        public int ProposalId { get; set; }
        public int ReviewerId { get; set; }

        public ReviewDTO() {}
    }
}
