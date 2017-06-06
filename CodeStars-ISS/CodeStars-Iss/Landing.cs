using CodeStars_Iss.Controller;
using Model.Domain;
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
    //ButtonAddConference- adauga conferinta - la click deschide AddConference form
    //ButtonMyConferences - Apare optiunea de a adauga co-chairs pentru conferinta ta
    //ButtonAllConferences
    //GridViewConferinte - lista conferinte
    //ButtonBuyTicket - daca am selectat CheckBoxListener se cumpara automat bilet ( inainte selectam conferinta pt care dorim sa cumparam )
                      //-daca am selectat CheckBoxSpeaker - deschide BuyTicketSpeaker 
 
    //La apasarea ESC de anuleaza fullscreen mode
                    
    public partial class Landing : Form
    {
        private ClientController ctrl;
        private UserDTO user;
        private DataTable conferinte;
        private DataTable proposals;
        public Landing(ClientController c,UserDTO user)
        {
            this.user = user;
            ctrl = c;
            InitializeComponent();
            PanelCoChair.Visible = false;
            panelAddProposal.Visible = false;
            panelReviewProposal.Visible = false;
            panelUpdateProposal.Visible = false;
            
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            if (this.user.Admin == true)
                buttonSwitch.Visible = true;
            else
                buttonSwitch.Visible = false;

            conferinte = new DataTable();
            conferinte.Columns.Add("Name", typeof(string));
            conferinte.Columns.Add("Domain", typeof(string));
            conferinte.Columns.Add("Start Date", typeof(string));
            conferinte.Columns.Add("End Date", typeof(string));
            conferinte.Columns.Add("Abstract Deadline", typeof(string));
            conferinte.Columns.Add("Full Paper Deadline", typeof(string));
            var items = ctrl.getAllConferences();
            reloadConferences(items);

            proposals = new DataTable();
            proposals.Columns.Add("Title", typeof(string));
            proposals.Columns.Add("Subject", typeof(string));
            proposals.Columns.Add("Abstract", typeof(string));
            proposals.Columns.Add("Full Paper", typeof(string));
            proposals.Columns.Add("Key Words", typeof(string));
        }

        //Conferintele la care sunt owner -> adaug co-chairs
        private void ButtonMyConferences_Click(object sender, EventArgs e)
        {
            var items = ctrl.getRelevantConferences(user.Id, (UserRole.Chair).ToString());
            reloadConferences(items);
            PanelCoChair.Visible = true;
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {

            AddConference f = new AddConference(ctrl,this.user);
            f.Show();
            
        }

        

        private void reloadConferences(IEnumerable<ConferenceDTO> items)
        {
            conferinte.Clear();
                foreach (var item in items)
                {

                    DataRow c = conferinte.NewRow();
                    c["Name"] = item.Name;
                    c["Domain"] = item.Domain;
                    c["Start Date"] = item.StartDate;
                    c["End Date"] = item.EndDate;
                    c["Abstract Deadline"] = item.AbstractDeadline;
                    c["Full Paper Deadline"] = item.FullPaperDeadline;
                    conferinte.Rows.Add(c);
                }
            GridViewConferinte.DataSource = conferinte;
        }

        private void ButtonAllConferences_Click(object sender, EventArgs e)
        {
            var items = ctrl.getAllConferences();
            reloadConferences(items);
            PanelCoChair.Visible = false;


        }

        private void ButtonBuyTicket_Click(object sender, EventArgs e)
        {
            if(GridViewConferinte.SelectedRows.Count==0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(),selectedRow.Cells[3].Value.ToString());
            var auto = ctrl.buyTicket(user.Id, conf.Id);
            if (auto == null)
                MessageBox.Show("You have already a ticket at this conference");
            else
                MessageBox.Show("You are now a listener at " + conf.Name);
        }

        //adaug co chair
        private void ButtonCoChair_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            AddCoChair p = new AddCoChair(ctrl, user, conf);
            p.Show();
        }

        //updatez o lucrare
        private void buttonUpdateProposal_Click(object sender, EventArgs e)
        {
            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposals!");
                return;
            }
            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            UpdateProposal p = new UpdateProposal(ctrl,prop);
            p.Show();
            //this.Hide();
        }

        //Conferintele la care particip ca si speaker -> unde trebuie sa imi adaug lucrarile
        private void buttonMyConferencesAsSpeaker_Click(object sender, EventArgs e)
        {
            var items = ctrl.getRelevantConferences(user.Id, (UserRole.Speaker).ToString());
            reloadConferences(items);
            panelAddProposal.Visible = true;
        }

        //lucrarile la care pot sa fac review
        private void buttonProposalsToBeReviewed_Click(object sender, EventArgs e)
        {
            panelReviewProposal.Visible = true;
            var items = ctrl.GetUserProposals(user.Id);
            reloadProposals(items);
        }

        //lucrarile mele 
        private void buttonMyProposals_Click(object sender, EventArgs e)
        {
            var window = new MyProposals(ctrl, user, OpenedFrom.UserWindow);
            window.Show();
        }

        //adaug lucrare la o conferinta la care particip ca speaker
        private void buttonAddProposal_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            AddProposal p = new AddProposal(ctrl,user.Id,conf.Id);
            p.Show();
        }

        /* 
         * verifica daca s-a facut deja sau nu review la proposalul dat ca parametru de catre userul curent
         * daca da, returneaza false
         * daca nu, returneaza true
        */
        private bool allowReview(ProposalDTO prop)
        {
            var reviews = ctrl.getAllForProposal(prop.Id);
            foreach (var review in reviews)
            {
                if (review.ReviewerId == user.Id)
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
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            var conferences = ctrl.getRelevantConferences(user.Id, "Reviewer");
            
            foreach (var conference in conferences)
            {
                if (conference.Id == conf.Id)
                {
                    return true;
                }
            }

            return false;
        }

        //fac review la un proposal
        private void buttonReviewProposal_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference.");
                return;
            }

            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposal!");
                return;
            }

            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());

            if (allowReview(prop)==false)
            {
                MessageBox.Show("You already made a review for this proposal.");
                return;
            }

            ReviewProposal p = new ReviewProposal(ctrl, prop, user.Id);
            p.Show();
            //this.Hide();
        }

        private void buttonMyConferencesAsListener_Click(object sender, EventArgs e)
        {
            var items = ctrl.getRelevantConferences(user.Id, (UserRole.Listener).ToString());
            reloadConferences(items);
            panelAddProposal.Visible = true;
        }


        private void GridViewConferinte_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());

            var chair = ctrl.getChairOfConference(conf.Id);
            if (chair!=null&&user.Id == chair.Id)
                buttonSections.Visible = true;
            else buttonSections.Visible = false;
            if (isReviewer())
            {
                buttonReviewProposal.Visible = true;
            }
            else
            {
                buttonReviewProposal.Visible = false;
            }
            if (updateAllowed(conf))
            {
                buttonUpdateDeadlines.Visible = true;
            }
            else
            {
                buttonUpdateDeadlines.Visible = false;
            }

            var prop = ctrl.GetUserProposal(user.Id, conf.Id);
            if (prop == null)
                return;

            List<ProposalDTO> items = new List<ProposalDTO>();
            items.Add(prop);
            reloadProposals(items);
        }

        private void reloadProposals(IEnumerable<ProposalDTO> items)
        {
            proposals.Clear();
                foreach (var item in items)
                {
                    DataRow c = proposals.NewRow();
                    c["Title"] = item.Title;
                    c["Subject"] = item.Subject;
                    c["Abstract"] = item.Abstract;
                    c["Full Paper"] = item.FullPaper;
                    c["Key Words"] = item.Keywords;
                    proposals.Rows.Add(c);
                }
            GridViewProposals.DataSource = proposals;
        }

        private void buttonSections_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference.");
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            AddSections window = new AddSections(conf, ctrl);
            window.Show();
        }

        private void ManageAuthorsButton_Click(object sender, EventArgs e)
        {
            if (GridViewProposals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a proposals!");
                return;
            }
            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            ManageAuthors p = new ManageAuthors(ctrl, prop);
            p.Show();
        }

        private void GridViewConferinte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            LandingAdmin window = new LandingAdmin(this.ctrl, this.user);
            window.Show();
            this.Close();
        }

        //se adauga reviewer
        private void ButtonReviewer_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            AddReviewer p = new AddReviewer(ctrl, user, conf);
            p.Show();
        }

        /*
         * verifica daca userul curent este chair sau co-chair pentru conferinta primita ca parametru, adica daca are permisiunea sa faca update la deadlineuri sau nu
         * daca este chair sau co-chair la conferinta primita ca parametru, returneaza true
         * altfel, returneaza false
        */
        private bool updateAllowed(ConferenceDTO conferenceDTO)
        {
            var allowedConferences1 = ctrl.getRelevantConferences(conferenceDTO.Id, "Chair");
            
            foreach (var conf in allowedConferences1)
            {
                if (conf.Id == conferenceDTO.Id)
                {
                    return true;
                }
            }

            var allowedConferences2 = ctrl.getRelevantConferences(conferenceDTO.Id, "CoChair");
            foreach (var conf in allowedConferences2)
            {
                if (conf.Id == conferenceDTO.Id)
                {
                    return true;
                }
            }

            return false;
        }

        private void buttonUpdateDeadlines_Click(object sender, EventArgs e)
        {
            if (GridViewConferinte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
        
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());

            UpdateDeadlines ud = new UpdateDeadlines(ctrl, conf);
            ud.Show();
        }
    }
}
