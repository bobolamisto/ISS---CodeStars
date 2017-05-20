using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class ConferenceMap : EntityTypeConfiguration<Conference>
    {
        public ConferenceMap()
        {
            ToTable("Conferences");
            HasKey(c => c.Id);
            Property(c => c.Name);
            Property(c => c.StartDate);
            Property(c => c.EndDate);
            Property(c => c.Domain);
            Property(c => c.AbstractDeadline);
            Property(c => c.FullPaperDeadline);
            Property(c => c.MainDescription);
            Property(c => c.State);
            Property(c => c.Price);
            Property(c => c.Edition);
            HasMany(c => c.Participations).WithRequired(uc => uc.Conference).HasForeignKey(uc => uc.ConferenceId);
        }
    }
}
