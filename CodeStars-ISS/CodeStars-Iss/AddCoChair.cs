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
    public partial class AddCoChair : Form
    {
        private ClientController _clientController;
        private UserDTO _user;
        private ConferenceDTO _conference;

        public AddCoChair(ClientController clientController, UserDTO user, ConferenceDTO conference)
        {
            _clientController = clientController;
            _user = user;
            _conference = conference;
            InitializeComponent();
            conferenceNameLabel.Text = $"{conferenceNameLabel.Text} {_conference.Name}";
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _clientController
                .getAllValidatedUsers()
                .Where(user => user.Id != _user.Id)
                .ToList();

            DataTable usersTable = new DataTable();
            usersTable.Columns.Add("Id", typeof(string));
            usersTable.Columns.Add("Name", typeof(string));

            foreach (var user in users)
            {
                var row = usersTable.NewRow();
                row["Id"] = user.Id;
                row["Name"] = $"{user.FirstName} {user.LastName}";
                usersTable.Rows.Add(row);
            }
            this.selectCoChairComboBox.DataSource = usersTable;
            this.selectCoChairComboBox.DisplayMember = "Name";
            this.selectCoChairComboBox.ValueMember = "Id";
        }

        private void addCoChairButton_Click(object sender, EventArgs e)
        {
            if (selectCoChairComboBox.SelectedIndex > -1)
            {
                var userId = int.Parse((string)selectCoChairComboBox.SelectedValue);
                var userConference = new User_ConferenceDTO
                {
                    UserId = userId,
                    ConferenceId = _conference.Id,
                    Role = UserRole.CoChair.ToString()
                };
                _clientController.addCoChair(userConference);
                MessageBox.Show("The co-chair was added successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a co-chair!");
            }
        }
    }
}
