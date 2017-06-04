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
        private List<SectionDTO> sections;
        private SectionDTO currentSection;
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

            InitializeComponent();
            initializeData();
        }

        public void initializeData()
        {
            
            labelConference.Text = conference.Name + ", Edition " + conference.Edition;
            labelConferenceStarts.Text = conference.StartDate;
            labelConferenceEnds.Text = conference.EndDate;

            sections = ctrl.getSectionsOfConference(conference.Id).ToList();
            if(sections.Count>0)
                currentSection = sections[0];
            reloadGridRemainingProposals(ctrl.getProposalsOutsideSections(conference.Id));
            if (sections.Count==0)
            { 
                return;
            }
            
            labelSectionStarts.Text = currentSection.StartDate;
            labelSectionEnds.Text = currentSection.EndDate;
            
            reloadGridChosenProposals(ctrl.GetProposalsOfSection(currentSection.Id));
        }

        private void reloadGridChosenProposals(IEnumerable<ProposalDTO> proposals)
        {
            chosenProposals.Clear();

            labelChosenProposals.Text = "Chosen Proposals For Section \'" + currentSection.Title + "\'";
            labelSectionStarts.Text = currentSection.StartDate;
            labelSectionEnds.Text = currentSection.EndDate;
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

        private void reloadGridRemainingProposals(IEnumerable<ProposalDTO> proposals)
        {
            remainingProposals.Clear();

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
            setVisibility();
        }

        private void buttonPreviousSection_Click(object sender, EventArgs e)
        {
            if(sections.Count==1)
            {
                MessageBox.Show("This is the only section.");
                return;
            }
            if(sections[0].Id==currentSection.Id)
            {
                MessageBox.Show("This is the first section.");
                return;
            }
            int index = sections.IndexOf(currentSection);
            currentSection = sections.ElementAt(index - 1);
            reloadGridChosenProposals(ctrl.GetProposalsOfSection(currentSection.Id));
        }

        private void buttonNextSection_Click(object sender, EventArgs e)
        {
            if (sections.Count == 1)
            {
                MessageBox.Show("This is the only section.");
                return;
            }
            if (sections.Last().Id == currentSection.Id)
            {
                MessageBox.Show("This is the last section.");
                return;
            }
            int index = sections.IndexOf(currentSection);
            currentSection = sections.ElementAt(index + 1);
            reloadGridChosenProposals(ctrl.GetProposalsOfSection(currentSection.Id));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridViewAllProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a proposal!!");
                return;
            }
            var selectedRow = GridViewAllProposals.SelectedRows[0];
            var selectedId = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            
            ctrl.addProposalToSection(selectedId,currentSection.Id);
            reloadGridChosenProposals(ctrl.GetProposalsOfSection(currentSection.Id));
            reloadGridRemainingProposals(ctrl.getProposalsOutsideSections(conference.Id));
        }

        private void buttonRemoveProposal_Click(object sender, EventArgs e)
        {
            if (GridViewChosenProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a proposal!!");
                return;
            }
            var selectedRow = GridViewChosenProposals.SelectedRows[0];
            var selectedId = Int32.Parse(selectedRow.Cells[0].Value.ToString());

            ctrl.removeProposalFromAnySection(selectedId);
            reloadGridRemainingProposals(ctrl.getProposalsOutsideSections(conference.Id));
            reloadGridChosenProposals(ctrl.GetProposalsOfSection(currentSection.Id));
        }

        private void setVisibility()
        {
            if (currentSection == null)
            {
                labelChosenProposals.Text = "There are no sections in this conference.";
                buttonPreviousSection.Visible = false;
                buttonNextSection.Visible = false;
                buttonAddProposal.Visible = false;
                buttonRemoveProposal.Visible = false;
                groupBoxSectionDates.Visible = false;
            }
            else
            {
                buttonPreviousSection.Visible = true;
                buttonNextSection.Visible = true;
                buttonAddProposal.Visible = true;
                buttonRemoveProposal.Visible = true;
                groupBoxSectionDates.Visible = true;
            }
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            if(ctrl.getPCMembersAvailableForSectionChair(conference.Id).ToList().Count==0  )
            {
                MessageBox.Show("There are no available PC Members tobe Section Chair.");
                return;
            }
            var window = new SectionDetails(conference.Id,ctrl,this);
            window.Show();
        }

        private void buttonRemoveSection_Click(object sender, EventArgs e)
        {
            if(ctrl.GetProposalsOfSection(currentSection.Id).ToList().Count!=0)
            {
                MessageBox.Show("If  you want to delete this section you must remove all proposals from it.");
                return;
            }
            ctrl.deleteSection(currentSection.Id);
            currentSection = null;
            initializeData();
            setVisibility();
        }
    }
}
