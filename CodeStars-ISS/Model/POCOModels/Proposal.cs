﻿using Model.POCOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Proposal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Abstract { get; set; }
        public string FullPaper { get; set; }
        public string Keywords { get; set; }
        public int ParticipationId { get; set; }
        public int? SectionId { get; set; }
        public virtual User_Conference Participation { get; set; }
        public virtual Section Section { get; set; }        
    }
}
