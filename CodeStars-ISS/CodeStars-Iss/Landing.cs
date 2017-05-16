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
    public partial class Landing : Form
    {
        private ClientController ctrl;
        public Landing(ClientController c)
        {
            ctrl = c;
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
        }
    }
}
