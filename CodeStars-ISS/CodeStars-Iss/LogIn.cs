using CodeStars_Iss.Controller;
using Model.Domain;
using services.Services;
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
    public partial class LogIn : Form
    {
        private ClientController uc;
        public LogIn(ClientController ctrl)
        {
            uc = ctrl;
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            var userDTO = uc.logIn(user, password);
            if (userDTO != null)
            {
                if (!userDTO.Admin)
                {
                    Landing l = new Landing(uc, userDTO);
                    l.Show();
                    this.Hide();
                }
                else
                {
                    LandingAdmin l = new LandingAdmin(uc, userDTO);
                    l.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            UserRegistration f = new UserRegistration(uc);
            f.Show();
            this.Hide();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }

}