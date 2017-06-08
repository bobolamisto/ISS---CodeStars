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
    public partial class ConferenceDetails : Form
    {
        private ClientController ctrl;
        private DataTable sectionsTable;
        private DataTable membersTable;
        private int conferenceId;
        public ConferenceDetails(ClientController ct,int confId)
        {
            ctrl = ct;
            conferenceId = confId;
            InitializeComponent();
        }

        private void dataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConferenceDetails_Load(object sender, EventArgs e)
        {
            initializeTables();
            reloadMembers(ctrl.getPCMembersForConference(conferenceId));
            reloadSections(ctrl.getSectionsOfConference(conferenceId));
        }
        private void initializeTables()
        {
            sectionsTable = new DataTable();
            sectionsTable.Columns.Add("Title", typeof(string));
            sectionsTable.Columns.Add("Start Date", typeof(string));
            sectionsTable.Columns.Add("End Date", typeof(string));

            membersTable = new DataTable();
            membersTable.Columns.Add("Name", typeof(string));
            membersTable.Columns.Add("Role", typeof(string));
            membersTable.Columns.Add("Web Page", typeof(string));
            

        }

        private void reloadSections(IEnumerable<SectionDTO> items)
        {
            sectionsTable.Clear();
            foreach (var item in items)
            {

                DataRow c = sectionsTable.NewRow();
                c["Title"] = item.Title;
                c["Start Date"] = item.StartDate;
                c["End Date"] = item.EndDate;
                sectionsTable.Rows.Add(c);
            }
            dataGridViewSections.DataSource = sectionsTable;
        }

        private void reloadMembers(IEnumerable<UserDTO> items)
        {
            membersTable.Clear();
            foreach (var item in items)
            {

                DataRow c = membersTable.NewRow();
                c["Name"] = item.FirstName+" "+item.LastName;
                c["Role"] = ctrl.getRoleOfUserAtConference(this.conferenceId, item.Id).ToString();
                c["Web Page"] = item.WebPage;
                membersTable.Rows.Add(c);
            }
            dataGridViewMembers.DataSource = membersTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
