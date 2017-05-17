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
    //TextBoxName
    //TextBoxGenre
    //TextBoxDate
    //ButtonAddConference - pentru a adauga
    public partial class AddConference : Form
    {
        private ClientController ctrl;
        public AddConference(ClientController ctrl)
        {
            this.ctrl = ctrl;
            InitializeComponent();
        }

        private void AddConference_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {

        }
    }
}
