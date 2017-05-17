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
    //TextBoxName
    //TextBoxStartDate - masked
    //TextBoxEndDate - masked
    //ButtonAddConference - pentru a adauga
    //TextBoxDomain
    //TextBoxAbstractDeadeline - masked
    //TextBoxFullPaperDeadline - masked
    //TextBoxMainDescription
    public partial class AddConference : Form
    {
        private ClientController ctrl;
        public AddConference(ClientController ctrl)
        {
            this.ctrl = ctrl;
            InitializeComponent();
        }

        private void AddConference_Load(object sender, EventArgs e)
        {
            TextBoxStartDate.Mask= "00.00.0000";
            TextBoxEndDate.Mask= "00.00.0000";
            TextBoxAbstractDeadline.Mask= "00.00.0000";
            TextBoxFullPaperDeadline.Mask= "00.00.0000"; 
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {

        }

        
    }
}
