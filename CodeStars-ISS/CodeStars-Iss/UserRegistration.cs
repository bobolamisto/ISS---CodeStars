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
    public partial class UserRegistration : Form
    {
        private ClientController uc;
        public UserRegistration(ClientController ctrl)
        {
            this.uc = ctrl;
            InitializeComponent();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var pass = maskedTextBoxPassword.Text;
            var rePass = maskedTextBoxRePassword.Text;
            var fName = textBoxFirstName.Text;
            var lName = textBoxLastName.Text;
            var email = textBoxEmail.Text;
            var webPage = textBoxWebPage.Text;

            if(pass!=rePass)
            {
                MessageBox.Show("Password doesn't match");
                return;
            }
            var account = uc.createAccount(username, pass, fName, lName, email, webPage);
            if (account==null)
            {
                MessageBox.Show("This username already exists");
                return;
            }
            {
                MessageBox.Show("Account created successfully. Wait for confirmation.");
                this.Hide();
                LogIn l = new LogIn(uc);
                l.Show();


            }

        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            
        }
    }
}
