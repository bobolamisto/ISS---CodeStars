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
    public partial class AddReviewer : Form
    {
        private ClientController _clientController;
        private UserDTO _user;
        private ConferenceDTO _conference;
        public AddReviewer(ClientController clientController, UserDTO user, ConferenceDTO conference)
        {
            _clientController = clientController;
            _user = user;
            _conference = conference;
            InitializeComponent();
            ConferenceNameLabel.Text = $"{ConferenceNameLabel.Text} {_conference.Name}";
        }

        private void AddReviewerButton_Click(object sender, EventArgs e)
        {
            var users = _clientController
              .getAllValidatedUsers()
              .Where(user => user.Id != _user.Id)
              .ToList();
            var exist = false;
            var userId = 0;
            foreach (var user in users)
            {
                if (user.Username.Equals(UsernameTextBox.Text))
                {
                    exist = true;
                    userId = user.Id;
                }
            }
            if (exist)
            {
                var userss = _clientController
                    .getPCMembersForConference(_conference.Id)
                    .Where(u => u.Id == userId)
                    .ToList();
                if (userss.Count == 0)
                {
                    var userConference = new User_ConferenceDTO
                    {
                        UserId = userId,
                        ConferenceId = _conference.Id,
                        Role = UserRole.Reviewer.ToString()
                    };
                    _clientController.addReviewer(userConference);
                    MessageBox.Show("The reviewer was added successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This user already has a role!");
                }
            }
            else
            {
                MessageBox.Show("Please insert a valid username!");
            }
        }
    }
}
