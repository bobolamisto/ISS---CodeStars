using Model.DTOModels;
using System.Collections;
using System.Collections.Generic;

namespace services.Services
{
    public interface IProposalService
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
        ProposalDTO RemovePaper(int idPaper);
        /// <summary>
        /// Update le lucrarea propusa de user la o anumita conferinta.
        /// Se face verificarea ca userul este cel care a propus lucrarea.
        /// Se face verificarea ca userul este cel care a propus lucrarea, pentru a nu avea situatia in care un user modifica lucrarea altcuiva.
        /// De aceea si idUser si idConferinta sunt parametrii, pe langa idPaper 
        /// </summary>
        ProposalDTO UpdatePaper( ProposalDTO paperDto);

        ProposalDTO GetUserProposal(int idUser, int idConferinta);

        IEnumerable<ProposalDTO> GetUserProposals(int idUser);
        /// <summary>
        /// Propunerile care trebuie evaluate de la conferinta la care eu sunt chair
        /// </summary>
        IEnumerable<ProposalDTO> GetProposalsToBeReviewed(int idUser, int idConf);

        ProposalDTO FindProposal( string title,string subject,string keywords);
        IEnumerable<ProposalDTO> GetProposalsOfSection(int sectionId);
        void addProposalToSection(int idProposal, int idSection);
        void removeProposalFromAnySection(int idProposal);
        ProposalDTO getProposalById(int id);
        IEnumerable<ProposalDTO> getProposalsOutsideSections(int conferenceId);
    }
}
