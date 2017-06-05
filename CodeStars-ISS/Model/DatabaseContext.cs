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
        public DbSet<Conference> Conferences { get; set; }
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
                if (conference.AbstractDeadline.CompareTo(conference.EndDate) >= 0)
                    errors.Add(new DbValidationError("AbstractDeadline", String.Format("The deadline for abstracts submission must be before {0}", conference.EndDate)));
                if (conference.FullPaperDeadline.CompareTo(conference.EndDate) >= 0)
                    errors.Add(new DbValidationError("FullPapersDeadline", String.Format("The deadline for full papers submission must be before {0}", conference.EndDate)));
                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }
            if (entityEntry.Entity is Proposal && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var proposal = (Proposal)entityEntry.Entity;

               
                if (proposal.Title == "")
                    errors.Add(new DbValidationError("Title", "Proposal title can't be null"));
                if (proposal.Subject == "")
                    errors.Add(new DbValidationError("Subject", "Proposal subject can't be null"));
                if (proposal.Abstract == "")
                    errors.Add(new DbValidationError("Abstract", "Proposal abstract can't be null"));
                if (proposal.FullPaper == "")
                    errors.Add(new DbValidationError("FullPaper", "Proposal fullpaper can't be null"));
                if (proposal.Keywords == "")
                    errors.Add(new DbValidationError("Keywords", "Proposal keywords can't be null"));
                if (proposal.Collaborators == "")
                    errors.Add(new DbValidationError("Collaborators", "Proposal collaborators can't be null"));
                if ((proposal.ProposalState!=ProposalState.Accepted) || (proposal.ProposalState != ProposalState.Declined) || (proposal.ProposalState != ProposalState.Pending))
                    errors.Add(new DbValidationError("ProposalState", "ProposalState must be Accepted, Declined or Pending"));

                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }

            if (entityEntry.Entity is Review && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var review = (Review)entityEntry.Entity;
                if (review.Recommendation == "")
                    errors.Add(new DbValidationError("Recommendation", "Review recommendation can't be null"));
                if ((review.Mark != Mark.StrongAccept) || (review.Mark != Mark.Accept) || (review.Mark != Mark.WeakAccept) || (review.Mark != Mark.BorderlinePaper) || (review.Mark != Mark.WeakReject) || (review.Mark != Mark.Reject) || (review.Mark != Mark.StrongReject))
                    errors.Add(new DbValidationError("Mark", "Mark must be StrongAccept, Accept, WeakAccept, BordelinePaper, WeakReject, Reject or StrongReject"));
                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }

            if (entityEntry.Entity is User_Conference && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var userconf = (User_Conference)entityEntry.Entity;

                if ((userconf.Role != UserRole.Chair) || (userconf.Role != UserRole.CoChair) || (userconf.Role != UserRole.Listener) || (userconf.Role != UserRole.Speaker) || (userconf.Role != UserRole.Reviewer))
                    errors.Add(new DbValidationError("Role", "Role must be Chair, CoChair, Listener, Speaker or Reviewer"));
                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }

            if (entityEntry.Entity is Section && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var section = (Section)entityEntry.Entity;
                if (section.Title == "")
                    errors.Add(new DbValidationError("Title", "Section title can't be null"));
                if (section.StartDate.CompareTo(section.EndDate) >= 0)
                    errors.Add(new DbValidationError("EndDate", String.Format("The end date must be after start date ({0})", section.StartDate)));
                
                if (Sections.Any(s => s.Id != section.Id &&
                        (section.EndDate.CompareTo(s.StartDate) >= 0 && section.StartDate.CompareTo(s.EndDate) <= 0)))
                    errors.Add(new DbValidationError("StartDate", String.Format("The section '{0}' time must be in some of the conferences", section.Title )));
                if (section.ChairId < 0)
                    errors.Add(new DbValidationError("ChairId", "Section ChairId must be positive"));

                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }

            if (entityEntry.Entity is User && (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified))
            {
                var user = (User)entityEntry.Entity;
                if (user.Username == "")
                    errors.Add(new DbValidationError("Username", "Username can't be null"));
                if (user.Password == "")
                    errors.Add(new DbValidationError("Password", "Password can't be null"));

                string str = user.FirstName;
                bool isLetter = !String.IsNullOrEmpty(str) && Char.IsLetter(str[0]);
                if (isLetter == true)
                {
                    if (str[0] >= 'A' && str[0] <= 'Z')
                        errors.Add(new DbValidationError("FirstName", "Firstname's first letter must pe uppercase"));
                }

                string str1 = user.LastName;
                bool isLetter1 = !String.IsNullOrEmpty(str) && Char.IsLetter(str1[0]);
                if (isLetter1 == true)
                {
                    if (str1[0] >= 'A' && str1[0] <= 'Z')
                        errors.Add(new DbValidationError("Lastname", "Lastname's first letter must pe uppercase"));
                }

 
                var addr = new System.Net.Mail.MailAddress(user.Email);
                if (addr.Address!=user.Email)
                    errors.Add(new DbValidationError("Email", "This email is not valid"));

                if (user.WebPage == "")
                    errors.Add(new DbValidationError("Webpage", "Webpage can't be null"));

                if ((user.Validation != AccountState.Validated) || (user.Validation != AccountState.Waiting) || (user.Validation != AccountState.Unvalidated))
                    errors.Add(new DbValidationError("Validation", "Validation must be Validated, Waiting or Unvalidated"));

                if (errors.Count > 0)
                    return new DbEntityValidationResult(entityEntry, errors);
            }

            return base.ValidateEntity(entityEntry, items);
        }

        

    }
}
