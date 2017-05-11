using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Domain { get; set; }
        public virtual ICollection<User_Conference> Participations { get; set; }

        public Conference()
        {
            Participations = new HashSet<User_Conference>();
        }
    }
}
