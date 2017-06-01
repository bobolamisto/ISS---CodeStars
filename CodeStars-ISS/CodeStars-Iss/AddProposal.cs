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
        private int userId, confId;
        public AddProposal( ClientController ctr,int userId,int confId)
        {
            this.ctr = ctr;
            this.userId = userId;
            this.confId = confId;
            InitializeComponent();
        }

        //add proposal
        private void buttonAddProposal_Click(object sender, EventArgs e)
        {
            var title = textBoxTitle.Text;
            var subject = textBoxSubject.Text;
            var abstrac = textBoxAbstract.Text;
            var fullpaper = textBoxFull.Text;
            var keywords = textBoxKeywords.Text;
            var ok = ctr.AddProposal(userId, confId, new Model.DTOModels.ProposalDTO(0, title, subject, abstrac, fullpaper, keywords, 0,1));
            if (ok != null)
            { MessageBox.Show("Proposal added successfully!");
                this.Close();
            }
        }
    }
}
