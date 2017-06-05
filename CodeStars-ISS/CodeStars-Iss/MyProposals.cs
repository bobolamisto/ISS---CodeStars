using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeStars_Iss.Controller;
using Model.Domain;
using Model.DTOModels;

namespace CodeStars_Iss
{
    public enum OpenedFrom
    {
        UserWindow,
        AdminWindow
    }

    public partial class MyProposals : Form
    {
        private ClientController _ctrl;
        private UserDTO _user;
        private DataTable _dataTable;
        private OpenedFrom _openedFrom;

        public MyProposals(ClientController controller, UserDTO user, OpenedFrom openedFrom)
        {
            _user = user;
            _ctrl = controller;
            _openedFrom = openedFrom;
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            _dataTable = new DataTable();

            _dataTable.Columns.Add("Title", typeof(string));
            _dataTable.Columns.Add("Subject", typeof(string));
            _dataTable.Columns.Add("Abstract Paper", typeof(string));
            _dataTable.Columns.Add("Full Paper", typeof(string));
            _dataTable.Columns.Add("Keywords", typeof(string));

            comboBoxProposalState.DataSource = Enum.GetValues(typeof(ProposalState));

            reloadProposals(getItems());
        }

        private void reloadProposals(IEnumerable<ProposalDTO> items)
        {
            _dataTable.Clear();
            foreach (var item in items)
            {
                DataRow row = _dataTable.NewRow();
                row["Title"] = item.Title;
                row["Subject"] = item.Subject;
                row["Abstract Paper"] = item.Abstract;
                row["Full Paper"] = item.FullPaper;
                row["Keywords"] = item.Keywords;
                _dataTable.Rows.Add(row);
            }
            GridViewProposals.DataSource = _dataTable;
        }

        private void comboBoxProposalState_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadProposals(getItems());
        }

        IEnumerable<ProposalDTO> getItems()
        {
            var selectedState = (ProposalState) comboBoxProposalState.SelectedItem;
            return _openedFrom == OpenedFrom.AdminWindow
                ? _ctrl.getProposalsByState(selectedState)
                : _ctrl.getProposalsByState(_user.Id, selectedState);
        }

        private void buttonAddColaborators_Click(object sender, EventArgs e)
        {
            var selectedRow = GridViewProposals.SelectedRows[0];
            var prop = _ctrl.FindProposal(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            ManageAuthors m = new ManageAuthors(_ctrl, prop);
            m.Show();
        }
    }
}
