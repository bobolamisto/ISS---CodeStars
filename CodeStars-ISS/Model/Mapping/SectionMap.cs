using Model.POCOModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class SectionMap:EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            ToTable("Sections");
            HasKey(s => s.Id);
            Property(s => s.Title);
            Property(s => s.ChairId);
            Property(s => s.ConferenceId);
            Property(s => s.StartDate);
            Property(s => s.EndDate);
            HasRequired(s => s.Chair).WithMany().HasForeignKey(s => s.ChairId);
        }
    }
}
