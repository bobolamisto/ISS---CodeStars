using CodeStars_Iss.Controller;
using Model.DTOModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeStars_Iss
{
    public partial class AddConference : Form
    {
        private ClientController ctrl;
        private UserDTO user;
        public AddConference(ClientController ctrl,UserDTO user)
        {
            this.user = user;
            this.ctrl = ctrl;
            InitializeComponent();
        }

        private void AddConference_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.CustomFormat = "MM/dd/yyyy hh:mm tt";

            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.CustomFormat = "MM/dd/yyyy hh:mm tt";

            dateTimePickerAbstractDeadline.Format = DateTimePickerFormat.Custom;
            dateTimePickerAbstractDeadline.CustomFormat = "MM/dd/yyyy hh:mm tt";

            dateTimePickerFullPaperDeadline.Format = DateTimePickerFormat.Custom;
            dateTimePickerFullPaperDeadline.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {
            string startTime = dateTimePickerStartDate.Text;
            string endTime = dateTimePickerEndDate.Text;
            string abstractTime = dateTimePickerAbstractDeadline.Text;
            string fullPaperTime = dateTimePickerFullPaperDeadline.Text;


            DateTime startDate = DateTime.Parse(startTime);
            DateTime endDate = DateTime.Parse(endTime);
            DateTime abstractDate = DateTime.Parse(abstractTime);
            DateTime fullPaperDate = DateTime.Parse(fullPaperTime);
            string pret = TextBoxTicket.Text;
            float price;
            try
            {
                price = float.Parse(pret);
            }
            catch(Exception ec)
            {
                MessageBox.Show("Invalid price.");
                return;
            }
            

            try
            {
                this.ctrl.addConference(this.user.Id, 0, TextBoxName.Text, startDate, endDate, TextBoxDomain.Text, abstractDate, fullPaperDate, price, TextBoxMainDescription.Text);
                MessageBox.Show("The conference was added successfully");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxFullPaperDeadline_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
