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
        }

        private void buttonUpdateAbstract_Click(object sender, EventArgs e)
        {
            try
            {
                _conf.AbstractDeadline = textBox1.Text;
                _ctrl.updateConference(_conf);
            }
            catch (System.Exception ex)
            {
                HandleException(ex);
            }
        }

        private void buttonUpdateFull_Click(object sender, EventArgs e)
        {
            try
            {
                _conf.FullPaperDeadline = textBox1.Text;
                _ctrl.updateConference(_conf);
            }
            catch (System.Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(System.Exception ex)
        {
            MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
        }
    }
}
