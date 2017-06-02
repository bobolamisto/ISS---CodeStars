using CodeStars_Iss.Controller;
using Model.DTOModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeStars_Iss
{
    public partial class AddSections : Form
    {
        private ClientController ctrl;
        private ConferenceDTO conference;
        private DataTable remainingProposals;
        private DataTable chosenProposals;
        private List<ProposalDTO> remProposals;
        private List<ProposalDTO> chsnProposals;
        private List<SectionDTO> sections;
        private int currentSectionId;
        public AddSections(ConferenceDTO conf,ClientController ct)
        {
            conference = conf;
            ctrl = ct;
            remainingProposals = new DataTable();
            remainingProposals.Columns.Add("Id", typeof(int));
            remainingProposals.Columns.Add("Title", typeof(string));
            remainingProposals.Columns.Add("Subject", typeof(string));
            remainingProposals.Columns.Add("Url", typeof(string));

            chosenProposals = new DataTable();
            chosenProposals.Columns.Add("Id", typeof(int));
            chosenProposals.Columns.Add("Title", typeof(string));
            chosenProposals.Columns.Add("Subject", typeof(string));
            chosenProposals.Columns.Add("Url", typeof(string));

            labelAllProposals.Text = "Remaining Proposals";
            labelChosenProposals.Text = "Chosen Proposals";

            InitializeComponent();
            initializeData();
        }

        private void initializeData()
        {
            remProposals = new List<ProposalDTO>();
            reloadGridRemainingProposals(remProposals);

            sections = ctrl.getSectionsOfConference(conference.Id).ToList();
            currentSectionId = sections[0].Id;
            reloadGridChosenProposals(currentSectionId);
        }

        private void reloadGridChosenProposals(int sectionId)
        {
            var proposals = ctrl.GetProposalsOfSection(sectionId);
            foreach (var item in proposals)
            {
                DataRow c = chosenProposals.NewRow();
                c["Id"] = item.Id;
                c["Title"] = item.Title;
                c["Subject"] = item.Subject;
                c["Url"] = item.FullPaper;
                chosenProposals.Rows.Add(c);
            }
            GridViewChosenProposals.DataSource = chosenProposals;
        }

        private void reloadGridRemainingProposals(List<ProposalDTO> proposals)
        {
            foreach (var item in proposals)
            {
                DataRow c = remainingProposals.NewRow();
                c["Id"] = item.Id;
                c["Title"] = item.Title;
                c["Subject"] = item.Subject;
                c["Url"] = item.FullPaper;
                remainingProposals.Rows.Add(c);
            }
            GridViewAllProposals.DataSource = remainingProposals;
        }
    }
}
