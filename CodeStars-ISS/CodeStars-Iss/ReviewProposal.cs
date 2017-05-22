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
    public partial class ReviewProposal : Form
    {
       private ClientController ctrl;
        public ReviewProposal(ClientController ctr)
        {
            this.ctrl = ctr;
            InitializeComponent();
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {

        }

        

        private void ReviewProposal_Load(object sender, EventArgs e)
        {

        }
    }
}
