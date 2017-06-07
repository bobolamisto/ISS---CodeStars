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
    public partial class ViewReviewsForProposal : Form
    {
        private ClientController _ctrl;
        private DataTable _dataTable;
        private ProposalDTO _proposal;

        public ViewReviewsForProposal(ClientController controller, ProposalDTO proposal)
        {
            _ctrl = controller;
            _proposal = proposal;
            InitializeComponent();
        }
        private void ViewReviewsForProposal_Load(object sender, EventArgs e)
        {
            label1.Text = _proposal.Title;

            _dataTable = new DataTable();

            _dataTable.Columns.Add("Id", typeof(int));
            _dataTable.Columns.Add("Mark", typeof(string));
            _dataTable.Columns.Add("Recommendation", typeof(string));
            _dataTable.Columns.Add("Reviewer", typeof(string));

            loadReviews(_ctrl.getAllForProposal(_proposal.Id));
        }

        private void loadReviews(IEnumerable<ReviewDTO> items)
        {
            _dataTable.Clear();
            foreach (var item in items)
            {
                DataRow row = _dataTable.NewRow();
                row["Mark"] = item.Mark;
                row["Recommendation"] = item.Recommendation;
                row["Reviewer"] = _ctrl.findUser(item.ReviewerId).FirstName + " "+ _ctrl.findUser(item.ReviewerId).LastName;
                _dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = _dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_ctrl.getAllForProposal(_proposal.Id).ToList().Count<3)
            { MessageBox.Show("This proposal needs tohave at least 3 reviews to be evaluated.");
                return;
            }
            var proposalState = _ctrl.evaluateProposal(this._proposal.Id);
            if(proposalState.Equals(ProposalState.Pending))
            {
                MessageBox.Show("The proposal can't be automatically evaluated because it has conflicted marks.");
                return;
            }
            MessageBox.Show("The proposal was automatically" + proposalState.ToString()+"\n The user has become speaker.");
            if (proposalState.Equals(ProposalState.Accepted))
            {
                var participation = _ctrl.GetParticipationOfProposal(this._proposal.Id);
                _ctrl.updateUserRole(participation.UserId, participation.ConferenceId, UserRole.Speaker);

            }
        }
    }
}
