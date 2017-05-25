using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOModels
{
    [Serializable]
    public class ProposalDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Abstract { get; set; }
        public string FullPaper { get; set; }
        public string Keywords { get; set; }
        public int ParticipationId { get; set; }

        public ProposalDTO() { }
        public ProposalDTO(int id, string title, string subject, string bastract, string fullpaper, string keywords, int partID)
        {
            Id = id;
            Title = title;
            Subject = subject;
            Abstract = bastract;
            FullPaper = fullpaper;
            Keywords = keywords;
            ParticipationId = partID;
        }

    }
}
