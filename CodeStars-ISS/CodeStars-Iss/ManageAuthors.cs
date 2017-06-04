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
        
        private DataTable users;
        private ProposalDTO prop;
        private ClientController ctr;
        public ManageAuthors(ClientController ctr,ProposalDTO prop)
        {
            this.ctr = ctr;
            this.prop = prop;
            InitializeComponent();
           
        }

        private void ManageAuthors_Load(object sender, EventArgs e)
        {
            users = new DataTable();
            users.Columns.Add("FirstName", typeof(string));
            users.Columns.Add("LastName", typeof(string));
      
        }

        private void reloadUsers(IEnumerable<UserDTO> items)
        {
            users.Clear();
            foreach (var item in items)
            {

                DataRow c = users.NewRow();
                c["FirstName"] = item.FirstName;
                c["LastName"] = item.LastName;
                
                users.Rows.Add(c);
            }
            dataGridUsers.DataSource = users;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text;
            var items = ctr.searchStringInUsers(text);
            reloadUsers(items);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author succesfully added!");
        }

        private void buttonRemoveAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author succesfully removed! ");
        }
    }
}
