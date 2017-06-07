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
    public partial class UpdateDeadlines : Form
    {
        private ClientController _ctrl;
        private ConferenceDTO _conf;

        public UpdateDeadlines(ClientController ctrl, ConferenceDTO conf)
        {
            _ctrl = ctrl;
            _conf = conf;            
            InitializeComponent();
        }

        private void UpdateDeadlines_Load(object sender, EventArgs e)
        {
            label1.Text += _conf.Name;
            label2.Text += _conf.AbstractDeadline;
            label3.Text += _conf.FullPaperDeadline;

            dateTimePickerAbstract.Format = DateTimePickerFormat.Custom;
            dateTimePickerAbstract.CustomFormat = "MM/dd/yyyy hh:mm tt";

            dateTimePickerFullPaper.Format = DateTimePickerFormat.Custom;
            dateTimePickerFullPaper.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void buttonUpdateAbstract_Click(object sender, EventArgs e)
        {
            var oldDeadline = _conf.AbstractDeadline;
            try
            {                
                _conf.AbstractDeadline = dateTimePickerAbstract.Text;
                _ctrl.updateConference(_conf);
                label2.Text = _conf.AbstractDeadline;
            }
            catch (Exception ex)
            {
                _conf.AbstractDeadline = oldDeadline;
                HandleException(ex);
            }
        }

        private void buttonUpdateFull_Click(object sender, EventArgs e)
        {
            var oldDeadline = _conf.FullPaperDeadline;
            try
            {
                _conf.FullPaperDeadline = dateTimePickerFullPaper.Text;
                _ctrl.updateConference(_conf);
                label3.Text = _conf.FullPaperDeadline;
            }
            catch (Exception ex)
            {
                _conf.FullPaperDeadline = oldDeadline;
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK);
        }
    }
}
