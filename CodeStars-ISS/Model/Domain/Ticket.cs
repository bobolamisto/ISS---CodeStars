using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int ParticipationId { get; set; }
        public virtual User_Conference Participation { get; set; }
    }
}
