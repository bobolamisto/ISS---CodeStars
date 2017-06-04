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
    //dataGridConferences
    //dataGridUsers

    public partial class LandingAdmin : Form
    {
        private ClientController ctrl;

        private DataTable conferinte;
        private DataTable users;
        private UserDTO user;
        public LandingAdmin(ClientController ctrl,UserDTO user)
        {
            this.user = user;
            this.ctrl = ctrl;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            panelAcceptDeclineConferences.Visible = false;
            panelAcceptDeclineUsers.Visible = false;
        }
       
        //Vezi users in pending
        private void buttonPendingUsers_Click(object sender, EventArgs e)
        {
            

            panelAcceptDeclineUsers.Visible = true;

            
        }


        //vezi conferinte in pending
        private void buttonPendingConferences_Click(object sender, EventArgs e)
        {

            reloadConferences(ctrl.getFilteredConferences(ConferenceState.Proposed.ToString()));
            panelAcceptDeclineConferences.Visible = true;
        }

        //review conferences
        private void buttonReviewConferences_Click(object sender, EventArgs e)
        {

            reloadConferences(ctrl.getFilteredConferences(ConferenceState.Declined.ToString()));
            panelAcceptDeclineConferences.Visible = false;
        }

        //conferinte accepted
        private void buttonAcceptedConferences_Click(object sender, EventArgs e)
        {
            reloadConferences(ctrl.getFilteredConferences(ConferenceState.Accepted.ToString()));
            panelAcceptDeclineConferences.Visible = false;
        }

        //users accepted
        private void buttonAcceptedUsers_Click(object sender, EventArgs e)
        {
            panelAcceptDeclineUsers.Visible = false;
        }

        //Accepta o conferinta
        private void buttonAcceptConference_Click(object sender, EventArgs e)
        {
            if (dataGridConferences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = dataGridConferences.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            ctrl.acceptFullConference(conf.Id);
            reloadConferences(ctrl.getAllConferences());
        }

        //respinge o conferinta
        private void buttonDeclineConference_Click(object sender, EventArgs e)
        {
            if (dataGridConferences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference!");
                return;
            }
            var selectedRow = dataGridConferences.SelectedRows[0];
            var conf = ctrl.FindConference(selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            ctrl.declineConferencProposal(conf.Id);
            reloadConferences(ctrl.getAllConferences());
        }

        //accepta un user
        private void buttonAcceptUser_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridUsers.SelectedRows[0];
            ctrl.validateAccount(selectedRow.Cells[0].Value.ToString(),selectedRow.Cells[1].Value.ToString(),selectedRow.Cells[2].Value.ToString());
            reloadUsers(ctrl.getAllUsers());
        }


        //respinge un user
        private void buttonDeclineUser_Click(object sender, EventArgs e)
        {

        }

        private void LandingAdmin_Load(object sender, EventArgs e)
        {
            conferinte = new DataTable();
            conferinte.Columns.Add("Name", typeof(string));
            conferinte.Columns.Add("Domain", typeof(string));
            conferinte.Columns.Add("Start Date", typeof(string));
            conferinte.Columns.Add("End Date", typeof(string));
            conferinte.Columns.Add("Abstract Deadline", typeof(string));
            conferinte.Columns.Add("Full Paper Deadline", typeof(string));
            var items = ctrl.getAllConferences();
            reloadConferences(items);

            users = new DataTable();
            users.Columns.Add("Username", typeof(string));
            users.Columns.Add("First Name", typeof(string));
            users.Columns.Add("Last Name", typeof(string));
            var items2 = ctrl.getAllUsers();
            reloadUsers(items2);
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
            dataGridConferences.DataSource = conferinte;
        }

        private void reloadUsers(IEnumerable<UserDTO> items)
        {
            users.Clear();
            foreach(var item in items)
            {
                DataRow u = users.NewRow();
                u["Username"] = item.Username;
                u["First Name"] = item.FirstName;
                u["Last Name"] = item.LastName;
                users.Rows.Add(u);
            }
            dataGridUsers.DataSource = users;
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            Landing window = new Landing(this.ctrl, this.user);
            window.Show();
            this.Close();
        }
    }
}
