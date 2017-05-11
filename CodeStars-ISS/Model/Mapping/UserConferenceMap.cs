using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class UserConferenceMap: EntityTypeConfiguration<User_Conference>
    {
        public UserConferenceMap()
        {
            ToTable("User_Conferences");
            HasKey(uc => uc.Id);
            Property(uc => uc.Role);
            Property(uc => uc.ConferenceId);
            Property(uc => uc.UserId);
            HasRequired(uc => uc.User).WithMany(u => u.ConferenceParticipations).HasForeignKey(uc => uc.UserId);
        }
    }
}
