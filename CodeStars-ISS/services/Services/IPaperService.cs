using Model.DTOModels;

namespace services.Services
{
    public interface IPaperService
    {
        /// <summary>
        /// Adauga o lucrare noua ca si propusa de un user la o anumita conferinta
        /// </summary>
        ProposalDTO AddPaper(int idUser, int idConferinta, ProposalDTO paperDto);
        /// <summary>
        /// Sterge lucrarea propusa de user cu id-ul idPaper de la conferinta data.
        /// Se face verificarea ca userul este cel care a propus lucrarea, pentru a nu avea situatia in care un user sterge lucrarea altcuiva.
        /// De aceea si idUser si idConferinta sunt parametrii, pe langa idPaper 
        /// </summary>
        ProposalDTO RemovePaper(int idUser, int idConferinta, int idPaper);
        /// <summary>
        /// Update le lucrarea propusa de user la o anumita conferinta.
        /// Se face verificarea ca userul este cel care a propus lucrarea.
        /// Se face verificarea ca userul este cel care a propus lucrarea, pentru a nu avea situatia in care un user modifica lucrarea altcuiva.
        /// De aceea si idUser si idConferinta sunt parametrii, pe langa idPaper 
        /// </summary>
        ProposalDTO UpdatePaper(int idUser, int idConferinta, ProposalDTO paperDto);
    }
}
