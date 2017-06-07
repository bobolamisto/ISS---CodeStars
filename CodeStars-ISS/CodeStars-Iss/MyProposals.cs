using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeStars_Iss.Controller;
using Model.Domain;
using Model.DTOModels;

namespace CodeStars_Iss
{
    public enum OpenedFrom
    {
        UserWindow,
        AdminWindow
    }

    public partial class MyProposals : Form
    {
        private ClientController _ctrl;
        private UserDTO _user;
        private DataTable _dataTable;
        private OpenedFrom _openedFrom;
        private ConferenceDTO _conference;

        public MyProposals(ClientController controller, UserDTO user, OpenedFrom openedFrom,ConferenceDTO conference)
        {
            _user = user;
            _ctrl = controller;
            _openedFrom = openedFrom;
            _conference = conference;
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            _dataTable = new DataTable();

            _dataTable.Columns.Add("Title", typeof(string));
            _dataTable.Columns.Add("Subject", typeof(string));
            _dataTable.Columns.Add("Abstract Paper", typeof(string));
            _dataTable.Columns.Add("Full Paper", typeof(string));
            _dataTable.Columns.Add("Keywords", typeof(string));
            _dataTable.Columns.Add("Collaborators", typeof(string));

            comboBoxProposalState.DataSource = Enum.GetValues(typeof(ProposalState));

            reloadProposals(getItems());

            if (_conference == null)
            {
                panelUpdate.Visible = true;
                buttonReviewProposal.Visible = false;
                label1.Text = "My proposed papers";
            }
            else
            {
                panelUpdate.Visible = false;
                buttonReviewProposal.Visible = true;
                label1.Text = "Proposed papers for conference \'" + this._conference.Name + "\'";
            }

            

        }

        public void reloadProposals(IEnumerable<ProposalDTO> items)
        {
            _dataTable.Clear();
            foreach (var item in items)
            {
                DataRow row = _dataTable.NewRow();
                row["Title"] = item.Title;
                row["Subject"] = item.Subject;
                row["Abstract Paper"] = item.Abstract;
                row["Full Paper"] = item.FullPaper;
                row["Keywords"] = item.Keywords;
                row["Collaborators"] = item.Collaborators;
                _dataTable.Rows.Add(row);
            }
            GridViewProposals.DataSource = _dataTable;
        }

        private void comboBoxProposalState_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadProposals(getItems());
        }

        public IEnumerable<ProposalDTO> getItems()
        {
            var selectedState = (ProposalState) comboBoxProposalState.SelectedItem;
            //return _openedFrom == OpenedFrom.AdminWindow
            return _conference!=null
                ? _ctrl.getProposalsByState(selectedState,_conference.Id)
                : _ctrl.getProposalsByState(_user.Id, selectedState);
        }

        private void buttonAddColaborators_Click(object sender, EventArgs e)
        {
            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposal!");
                return;
            }
            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = _ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            ManageAuthors m = new ManageAuthors(_ctrl, prop,this);
            m.Show();
        }

        private void buttonUpdateProposal_Click(object sender, EventArgs e)
        {
            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposal!");
                return;
            }
            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = _ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            UpdateProposal p = new UpdateProposal(_ctrl, prop,this);
            p.Show();
        }

        private void MyProposals_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonReviewProposal_Click(object sender, EventArgs e)
        {

            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposal!");
                return;
            }

            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = _ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());

            if (allowReview(prop) == false)
            {
                MessageBox.Show("You already made a review for this proposal.");
                return;
            }

            ReviewProposal p = new ReviewProposal(_ctrl, prop, _user.Id);
            p.Show();
        }

        private bool allowReview(ProposalDTO prop)
        {
            var reviews = _ctrl.getAllForProposal(prop.Id);
            foreach (var review in reviews)
            {
                if (review.ReviewerId == _user.Id)
                {
                    return false;
                }
            }
            return true;
        }

        /*
         * verifica daca userul curent este sau nu reviewer la conferinta curenta
         * daca da, returneaza true
         * daca nu, returneaza false
         */
        private bool isReviewer()
        {
            var conferences = _ctrl.getRelevantConferences(_user.Id, "Reviewer");

            foreach (var conference in conferences)
            {
                if (conference.Id == _conference.Id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
