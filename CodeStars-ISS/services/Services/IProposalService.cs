using Model.DTOModels;
using System.Collections;
using System.Collections.Generic;
using Model.Domain;

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
        /// Propunerile la o conferinta in functie de stadiu
        /// </summary>
        IEnumerable<ProposalDTO> GetProposalsByState(ProposalState proposalState,int confId);

        /// <summary>
        /// Propunerile unui user in functie de stadiu
        /// </summary>
        IEnumerable<ProposalDTO> GetProposalsByState(int idUser, ProposalState proposalState);

        ProposalDTO FindProposal( string title,string subject,string keywords);
        IEnumerable<ProposalDTO> GetProposalsOfSection(int sectionId);
        void addProposalToSection(int idProposal, int idSection);
        void removeProposalFromAnySection(int idProposal);
        ProposalDTO getProposalById(int id);
        IEnumerable<ProposalDTO> getProposalsOutsideSections(int conferenceId);

        ProposalState evaluateProposal(int id);

        void addColaborator(string username, int id);

        
    }
}
