using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Model.DTOModels;

namespace services.Services
{
    public interface IPaperService
    {
        /// <summary>
        /// Adauga o lucrare noua ca si propusa de un user la o anumita conferinta
        /// </summary>
        User_ConferenceDTO AddPaper(int idUser, int idConferinta, ProposalDTO paper);
        /// <summary>
        /// Sterge lucrarea propusa de user cu id-ul idPaper de la conferinta data.
        /// Se face verificarea ca userul este cel care a propus lucrarea.
        /// </summary>
        User_ConferenceDTO RemovePaper(int idUser, int idConferinta, int idPaper);
        /// <summary>
        /// Update le lucrarea propusa de user la o anumita conferinta.
        /// Se face verificarea ca userul este cel care a propus lucrarea.
        /// </summary>
        User_ConferenceDTO UpdatePaper(int idUser, int idConferinta, ProposalDTO paper);
    }
}
