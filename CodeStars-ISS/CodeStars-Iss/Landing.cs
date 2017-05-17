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
    //ButtonAddConference- adauga conferinta - la click deschide AddConference form
    //ButtonMyConferences - Apare optiunea de a adauga co-chairs pentru conferinta ta
    //ButtonAllConferences
    //ConferencesList - lista conferinte
    //ButtonBuyTicket - daca am selectat CheckBoxListener se cumpara automat bilet ( inainte selectam conferinta pt care dorim sa cumparam )
                      //-daca am selectat CheckBoxSpeaker - deschide BuyTicketSpeaker 
    //ButtonFullScreen 
    //La apasarea ESC de anuleaza fullscreen mode
                    
    public partial class Landing : Form
    {
        private ClientController ctrl;
        public Landing(ClientController c)
        {
            ctrl = c;
            InitializeComponent();
            PanelCoChair.Visible = false;
        }

        private void Landing_Load(object sender, EventArgs e)
        {
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Landing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void ButtonMyConferences_Click(object sender, EventArgs e)
        {
            PanelCoChair.Visible = true;
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {
            AddConference f = new AddConference(ctrl);
            f.Show();
            
        }

        private void ButtonAllConferences_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBuyTicket_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonCoChair_Click(object sender, EventArgs e)
        {

        }

        
    }
}
