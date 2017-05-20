using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class ReviewMap:EntityTypeConfiguration<Review>
    {
        public ReviewMap()
        {
            ToTable("Reviews");
            HasKey(r => r.Id);
            Property(r => r.Mark);
            Property(r => r.ProposalId);
            Property(r => r.ReviewerId);
            Property(r => r.Recommendation);
            HasRequired(r => r.Proposal).WithMany().HasForeignKey(r => r.ProposalId);
            HasRequired(r => r.Reviewer).WithMany().HasForeignKey(r => r.ReviewerId);
        }
    }
}
