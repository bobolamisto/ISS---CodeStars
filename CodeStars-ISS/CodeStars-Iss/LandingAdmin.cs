using CodeStars_Iss.Controller;
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
        public LandingAdmin(ClientController ctrl)
        {
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
            panelAcceptDeclineConferences.Visible = true;
        }

        //review conferences
        private void buttonReviewConferences_Click(object sender, EventArgs e)
        {
            panelAcceptDeclineConferences.Visible = true;
        }

        //conferinte accepted
        private void buttonAcceptedConferences_Click(object sender, EventArgs e)
        {
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

        }

        //respinge o conferinta
        private void buttonDeclineConference_Click(object sender, EventArgs e)
        {

        }

        //accepta un user
        private void buttonAcceptUser_Click(object sender, EventArgs e)
        {

        }


        //respinge un user
        private void buttonDeclineUser_Click(object sender, EventArgs e)
        {

        }
    }
}
