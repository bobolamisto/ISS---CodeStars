using Model.POCOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public enum ConferenceState
    {
        Proposed=1,
        Building,
        Accepted,
        Declined //in cazul in care nu stergem direct o conferinta daca e refuzata     
    }

    public class ConferenceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Domain { get; set; }
        public string MainDescription { get; set; }
        public int Edition { get; set; }
        public float Price { get; set; }
        public DateTime AbstractDeadline { get; set; }
        public DateTime FullPaperDeadline { get; set; }
        public ConferenceState State { get; set; }

        public virtual ICollection<User_Conference> Participations { get; set; }
        public virtual ICollection<Section> Sections { get; set; }

        public ConferenceDTO()
        {
            Participations = new HashSet<User_Conference>();
            Sections = new HashSet<Section>();
        }
    }
}
