using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public enum AccountState
    {
        Validated=1,
        Wainting,
        Unvalidated
    }
    public class User
    {
        public User()
        {
            ConferenceParticipations = new HashSet<User_Conference>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string WebPage { get; set; }
        public bool Admin { get; set; }
        public AccountState Validation { get; set; }
        public virtual ICollection<User_Conference> ConferenceParticipations { get; set; }

    }
}
