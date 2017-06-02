using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCOModels
{
    public class Section
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ChairId { get; set; }
        public int ConferenceId { get; set; }
        public virtual User Chair { get; set; }
        public virtual Conference Conference { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; }
        public Section()
        {
            Proposals = new HashSet<Proposal>();
        }
    }
}
