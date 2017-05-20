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
    //GridViewConferinte - lista conferinte
    //ButtonBuyTicket - daca am selectat CheckBoxListener se cumpara automat bilet ( inainte selectam conferinta pt care dorim sa cumparam )
                      //-daca am selectat CheckBoxSpeaker - deschide BuyTicketSpeaker 
 
    //La apasarea ESC de anuleaza fullscreen mode
                    
    public partial class Landing : Form
    {
        private ClientController ctrl;
        public Landing(ClientController c)
        {
            ctrl = c;
            InitializeComponent();
            PanelCoChair.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Landing_Load(object sender, EventArgs e)
        {
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
