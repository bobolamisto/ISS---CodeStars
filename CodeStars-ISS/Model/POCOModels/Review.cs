using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public enum Mark
    {
        StrongAccept=1,
        Accept,
        WeakAccept,
        BorderlinePaper,
        WeakReject,
        Reject,
        StrongReject
    }
    public class Review
    {
        public int Id { get; set; }
        public Mark Mark { get; set; }
        public string Recommendation { get; set; }
        public int ProposalId { get; set; }
        public int ReviewerId { get; set; }
        public virtual User Reviewer { get; set; }
        public virtual Proposal Proposal { get; set; }
    }
}
