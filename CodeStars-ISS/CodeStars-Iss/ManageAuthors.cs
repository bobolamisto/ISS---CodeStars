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
    public partial class ManageAuthors : Form
    {
        
        private ProposalDTO prop;
        private ClientController ctr;
        public ManageAuthors(ClientController ctr,ProposalDTO prop)
        {
            this.ctr = ctr;
            this.prop = prop;
            InitializeComponent();
           
        }

        private void buttonAddColaborator_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            var users = ctr
               .getAllValidatedUsers()
               .ToList();
            var exist = false;
            var userId = 0;
            foreach (var user in users)
            {
                if (user.Username.Equals(textBoxUsername.Text))
                {
                    exist = true;
                    userId = user.Id;
                }
            }
            if (exist)
            {
                    ctr.addColaborator(textBoxUsername.Text, prop);
                    
                    MessageBox.Show("The colaborator was added successfully");
                    this.Close();
            }             
           
            else
            {
                MessageBox.Show("Please insert a valid username!");
            }
        }
    }
}
