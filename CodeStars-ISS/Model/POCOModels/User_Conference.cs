using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public enum UserRole{
        Chair=1,
        CoChair,
        Listener,
        Speaker,
        Reviewer
    }
    public class User_Conference
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public int ConferenceId { get; set; }
        public int UserId { get; set; }
        public virtual Conference Conference{ get; set; }
        public virtual User User { get; set; }
    }
}
