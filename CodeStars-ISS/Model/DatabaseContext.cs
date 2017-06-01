using Model.Domain;
using Model.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Model.POCOModels;

namespace Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ConferenceDTO> Conferences { get; set; }
        public DbSet<User_Conference> ConferenceParticipations { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Section> Sections { get; set; }
        public object ObjectStateManager { get; set; }

        public DatabaseContext() : base("DatabaseContext")
        {

        }

        public DatabaseContext(DbConnection connection) : base(connection, true) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<NavigationPropertyNameForeignKeyDiscoveryConvention>();                      

            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ConferenceMap());
            modelBuilder.Configurations.Add(new UserConferenceMap());
            modelBuilder.Configurations.Add(new ReviewMap());
            modelBuilder.Configurations.Add(new ProposalMap());
            modelBuilder.Configurations.Add(new SectionMap());
        }
/*
        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            List<DbValidationError> errors = new List<DbValidationError>();
            if(entityEntry.Entity is Conference && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var conference = (Conference)entityEntry.Entity;
                if (conference.StartDate.CompareTo(conference.EndDate) >= 0)
                    errors.Add(new DbValidationError("EndDate", String.Format("The end date must be after start date ({0})", conference.StartDate)));
                if (Conferences.Any(c => c.Id != conference.Id &&
                        (conference.EndDate.CompareTo(c.StartDate) >= 0 && conference.StartDate.CompareTo(c.EndDate) <= 0)))
                    errors.Add( new DbValidationError("StartDate",String.Format("The conference '{0}' time must not interfere with those existent",conference.Name)));
                if (conference.Name == "")
                    errors.Add(new DbValidationError("Name", "Conference name can't be null"));
                if (conference.Domain == "")
                    errors.Add(new DbValidationError("Domain", "Conference domain can't be null"));
                if (conference.AbstractDeadline.CompareTo(conference.StartDate) >= 0)
                    errors.Add(new DbValidationError("AbstractDeadline", String.Format("The deadline for abstracts submission must be before {0}", conference.StartDate)));
                if (conference.FullPaperDeadline.CompareTo(conference.StartDate) >= 0)
                    errors.Add(new DbValidationError("FullPapersDeadline", String.Format("The deadline for full papers submission must be before {0}", conference.StartDate)));
                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }
            return base.ValidateEntity(entityEntry, items);
        }
        */
    }
}
