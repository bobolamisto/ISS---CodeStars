using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class ProposalMap:EntityTypeConfiguration<Proposal>
    {
        public ProposalMap()
        {
            ToTable("Proposals");
            HasKey(p => p.Id);
            Property(p => p.Title);
            Property(p => p.Subject);
            Property(p => p.Abstract);
            Property(p => p.FullPaper);
            Property(p => p.Keywords);
            Property(p => p.Collaborators);
            Property(p => p.ParticipationId);
            Property(p => p.SectionId);
            Property(p => p.ProposalState);

            HasRequired(p => p.Participation).WithMany().HasForeignKey(p => p.ParticipationId);
            HasOptional(p => p.Section).WithMany(s => s.Proposals).HasForeignKey(p => p.SectionId);
        }
    }
}
