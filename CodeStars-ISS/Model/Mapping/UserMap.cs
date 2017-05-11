using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    internal class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users");
            HasKey(u => u.Id);
            Property(u => u.Username);
            Property(u => u.Password);
            Property(u => u.FirstName);
            Property(u => u.LastName);
            Property(u => u.Email);
            Property(u => u.WebPage);
            Property(u => u.Admin);
            HasMany(u => u.ConferenceParticipations).WithRequired(uc => uc.User).HasForeignKey(uc => uc.UserId);
        }
    }
}
