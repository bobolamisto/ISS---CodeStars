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
    public partial class SectionDetails : Form
    {
        private int conferenceId;
        private ClientController ctrl;
        private AddSections form;
        public SectionDetails(int confid,ClientController ctrl,AddSections form)
        {
            this.ctrl = ctrl;
            conferenceId = confid;
            this.form = form;
            InitializeComponent();

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";

            loadCombo();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string start = dateTimePickerStart.Text;
            string end = dateTimePickerEnd.Text;
            string chair = comboBoxChair.Text;
            int chiarId = ctrl.findByUsername(chair);
            var section = new SectionDTO { Title = title, StartDate = start, EndDate = end, ChairId = chiarId, ConferenceId = conferenceId };
            var ok=ctrl.addsection(section);
            if(ok!=null)
            { MessageBox.Show("Section added successfully");
                this.Close();
            }
        }

        private void loadCombo()
        {
            var users = ctrl.getPCMembersAvailableForSectionChair(conferenceId);            
            comboBoxChair.DataSource = users;
            comboBoxChair.DisplayMember = "Username";
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SectionDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.initializeData();
        }
    }
}
