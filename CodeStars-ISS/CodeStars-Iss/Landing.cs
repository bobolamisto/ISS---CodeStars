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
        public Landing(ClientController c,UserDTO user)
        {
            this.user = user;
            ctrl = c;
            InitializeComponent();
            PanelCoChair.Visible = false;
            panelAddProposal.Visible = false;
            panelReviewProposal.Visible = false;
            panelUpdateProposal.Visible = false;
            conferinte = new DataTable();
            this.WindowState = FormWindowState.Maximized;
            this.GetConferences(false);
        }

        private void Landing_Load(object sender, EventArgs e)
        {
        }

        //Conferintele la care sunt owner -> adaug co-chairs
        private void ButtonMyConferences_Click(object sender, EventArgs e)
        {
            reloadConferences(false);
            PanelCoChair.Visible = true;
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {

            AddConference f = new AddConference(ctrl,this.user);
            f.Show();
            
        }

        private void GetConferences(Boolean boolean)
        {
            conferinte.Columns.Add("Name", typeof(string));
            conferinte.Columns.Add("Domain", typeof(string));
            conferinte.Columns.Add("Start Date", typeof(string));
            conferinte.Columns.Add("End Date", typeof(string));
            conferinte.Columns.Add("Abstract Deadline", typeof(string));
            conferinte.Columns.Add("Full Paper Deadline", typeof(string));

            var items = ctrl.getAllConferences();
            var myConf = ctrl.getRelevantConferences(user.Id);

            if (boolean)
                foreach (var item in items)
                {

                    DataRow c = conferinte.NewRow();
                    c["Name"] = item.Name;
                    c["Domain"] = item.Domain;
                    c["Start Date"] = item.StartDate;
                    c["End Date"] = item.StartDate;
                    c["Abstract Deadline"] = item.StartDate;
                    c["Full Paper Deadline"] = item.StartDate;
                    conferinte.Rows.Add(c);
                }
            else
            {
                foreach (var item in myConf)
                {

                    DataRow c = conferinte.NewRow();
                    c["Name"] = item.Name;
                    c["Domain"] = item.Domain;
                    c["Start Date"] = item.StartDate;
                    c["End Date"] = item.StartDate;
                    c["Abstract Deadline"] = item.StartDate;
                    c["Full Paper Deadline"] = item.StartDate;
                    conferinte.Rows.Add(c);
                }
            }
            GridViewConferinte.DataSource = conferinte;
            GridViewConferinte.ClearSelection();
        }

        private void reloadConferences(Boolean boolean)
        {
            conferinte.Clear();
            var myConf = ctrl.getRelevantConferences(user.Id);
            var items = ctrl.getAllConferences();
            if (boolean)
                foreach (var item in items)
                {

                    DataRow c = conferinte.NewRow();
                    c["Name"] = item.Name;
                    c["Domain"] = item.Domain;
                    c["Start Date"] = item.StartDate;
                    c["End Date"] = item.StartDate;
                    c["Abstract Deadline"] = item.StartDate;
                    c["Full Paper Deadline"] = item.StartDate;
                    conferinte.Rows.Add(c);
                }
            else
            {
                foreach (var item in myConf)
                {

                    DataRow c = conferinte.NewRow();
                    c["Name"] = item.Name;
                    c["Domain"] = item.Domain;
                    c["Start Date"] = item.StartDate;
                    c["End Date"] = item.StartDate;
                    c["Abstract Deadline"] = item.StartDate;
                    c["Full Paper Deadline"] = item.StartDate;
                    conferinte.Rows.Add(c);
                }
            }
            GridViewConferinte.DataSource = conferinte;
            GridViewConferinte.ClearSelection();


        }

        private void ButtonAllConferences_Click(object sender, EventArgs e)
        {

            reloadConferences(true);
            PanelCoChair.Visible = false;


        }

        private void ButtonBuyTicket_Click(object sender, EventArgs e)
        {
            var selectedRow = GridViewConferinte.SelectedRows[0];
            var items = ctrl.getAllConferences().Where(x => x.Name.Equals(selectedRow.Cells[0].Value.ToString()));
            ConferenceDTO conf = items.ElementAt(0);
            var auto = ctrl.buyTicket(user.Id, conf.Id);
        }

        //adaug co chair
        private void ButtonCoChair_Click(object sender, EventArgs e)
        {

        }

        //updatez o lucrare
        private void buttonUpdateProposal_Click(object sender, EventArgs e)
        {
            UpdateProposal p = new UpdateProposal(ctrl);
            p.Show();
        }

        //Conferintele la care particip ca si speaker -> unde trebuie sa imi adaug lucrarile
        private void buttonMyConferencesAsSpeaker_Click(object sender, EventArgs e)
        {
            reloadConferences(false);
            panelAddProposal.Visible = true;
        }

        //lucrarile la care pot sa fac review
        private void buttonProposalsToBeReviewed_Click(object sender, EventArgs e)
        {
            panelReviewProposal.Visible = true;
        }

        //lucrarile mele 
        private void buttonMyProposals_Click(object sender, EventArgs e)
        {
            panelUpdateProposal.Visible = true;
        }

        //adaug lucrare la o conferinta la care particip ca speaker
        private void buttonAddProposal_Click(object sender, EventArgs e)
        {
            AddProposal p = new AddProposal(ctrl);
            p.Show();
        }

        //fac review la un proposal
        private void buttonReviewProposal_Click(object sender, EventArgs e)
        {
            ReviewProposal p = new ReviewProposal(ctrl);
            p.Show();
        }
    }
}
