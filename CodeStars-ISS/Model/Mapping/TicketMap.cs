using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class TicketMap:EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            ToTable("Tickets");
            HasKey(t => t.Id);
            Property(t => t.Price);
            HasRequired(t => t.Participation).WithMany().HasForeignKey(t => t.ParticipationId);
        }
    }
}
