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
    //textBoxTitle
    //textBoxSubject

    //textBoxAbstract
    //textBoxFull
    //textBoxKeywords
    public partial class AddProposal : Form
    {
        private ClientController ctr;
        public AddProposal( ClientController ctr)
        {
            this.ctr = ctr;
            InitializeComponent();
        }

        //add proposal
        private void buttonAddProposal_Click(object sender, EventArgs e)
        {

        }
    }
}
