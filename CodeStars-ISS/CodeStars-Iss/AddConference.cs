using CodeStars_Iss.Controller;
using Model.DTOModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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
    //TextBoxTicket
    //TextBoxAbstractDeadeline - masked
    //TextBoxFullPaperDeadline - masked
    //TextBoxMainDescription
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
            
        }

        private void ButtonAddConference_Click(object sender, EventArgs e)
        {
            string startTime = TextBoxStartDate.Text;
            string endTime = TextBoxEndDate.Text;
            string abstractTime = TextBoxAbstractDeadline.Text;
            string fullPaperTime = TextBoxFullPaperDeadline.Text;

            string[] parse = startTime.Split('.');
            DateTime startDate = new DateTime(int.Parse(parse[2]), int.Parse(parse[1]), int.Parse(parse[0]));
            parse = endTime.Split('.');
            DateTime endDate = new DateTime(int.Parse(parse[2]), int.Parse(parse[1]), int.Parse(parse[0]));
            parse = abstractTime.Split('.');
            DateTime abstractDate = new DateTime(int.Parse(parse[2]), int.Parse(parse[1]), int.Parse(parse[0]));
            parse = fullPaperTime.Split('.');
            DateTime fullPaperDate = new DateTime(int.Parse(parse[2]), int.Parse(parse[1]), int.Parse(parse[0]));
            string pret = TextBoxTicket.Text;
            float price = float.Parse(pret);


            try
            {
                this.ctrl.addConference(this.user.Id, 0, TextBoxName.Text, startDate, endDate, TextBoxDomain.Text, abstractDate, fullPaperDate, price,TextBoxMainDescription.Text);
                MessageBox.Show("The conference was added successfully");
                this.Close();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                        error.PropertyName, error.ErrorMessage);
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void TextBoxFullPaperDeadline_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
