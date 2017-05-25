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
    //textBoxAbstract
    //textBoxFull
    public partial class UpdateProposal : Form
    {
        private ClientController ctrl;
        private ProposalDTO proposal;
        public UpdateProposal(ClientController ctrl,ProposalDTO prop)
        {
            this.ctrl = ctrl;
            this.proposal = prop;
            InitializeComponent();
        }

        //update proposal
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.proposal.Abstract = textBoxAbstract.Text;
            this.proposal.FullPaper = textBoxFull.Text;
            var ok = ctrl.UpdatePaper(this.proposal);
            if (ok != null)
            {
                MessageBox.Show("Proposal updated successfully!");
                this.Close();
            }
            
        }
    }
}
