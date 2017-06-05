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
    public partial class ViewReviewsForProposal : Form
    {
        private ClientController _ctrl;
        private DataTable _dataTable;
        private int _proposalId;

        public ViewReviewsForProposal(ClientController controller, int proposalId)
        {
            _ctrl = controller;
            _proposalId = proposalId;
            InitializeComponent();
        }
        private void ViewReviewsForProposal_Load(object sender, EventArgs e)
        {
            label1.Text += _proposalId.ToString();

            _dataTable = new DataTable();

            _dataTable.Columns.Add("Id", typeof(int));
            _dataTable.Columns.Add("Mark", typeof(string));
            _dataTable.Columns.Add("Recommendation", typeof(string));
            _dataTable.Columns.Add("Reviewer Id", typeof(int));

            loadReviews(_ctrl.getAllForProposal(_proposalId));
        }

        private void loadReviews(IEnumerable<ReviewDTO> items)
        {
            _dataTable.Clear();
            foreach (var item in items)
            {
                DataRow row = _dataTable.NewRow();
                row["Id"] = item.Id;
                row["Mark"] = item.Mark;
                row["Recommendation"] = item.Recommendation;
                row["Reviewer Id"] = item.ReviewerId;
                _dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = _dataTable;
        }
    }
}
