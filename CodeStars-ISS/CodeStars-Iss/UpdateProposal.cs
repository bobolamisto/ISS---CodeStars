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
    //textBoxAbstract
    //textBoxFull
    public partial class UpdateProposal : Form
    {
        private ClientController ctrl;
        public UpdateProposal(ClientController ctrl)
        {
            this.ctrl = ctrl;
            InitializeComponent();
        }

        //update proposal
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
