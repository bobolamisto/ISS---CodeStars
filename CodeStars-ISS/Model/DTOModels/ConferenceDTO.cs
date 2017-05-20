using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOModels
{
    [Serializable]
    public class ConferenceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Edition { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Domain { get; set; }
        public string AbstractDeadline { get; set; }
        public string FullPaperDeadline { get; set; }
        public string MainDescription { get; set; }

        public float Price { get; set; }
        public string State { get; set; }

        public ConferenceDTO() {}
    }
}
