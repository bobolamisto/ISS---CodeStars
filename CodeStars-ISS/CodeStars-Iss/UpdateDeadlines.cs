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
                var newDeadline = DateTime.Parse(textBox1.Text);
                if (newDeadline >= DateTime.Parse(_conf.EndDate))
                {
                    throw new System.Exception("The deadline for abstracts submission must be before " + _conf.EndDate);
                }
            }
            catch (System.Exception ex)
            {
                HandleException(ex);
                return;
            }
            _conf.AbstractDeadline = textBox1.Text;
            _ctrl.updateConference(_conf);
            label2.Text = "Abstracts deadline: " + _conf.AbstractDeadline;
            MessageBox.Show("The deadline for abstracts was successfully updated.");
        }

        private void buttonUpdateFull_Click(object sender, EventArgs e)
        {
            try
            {
                var newDeadline = DateTime.Parse(textBox2.Text);
                if (newDeadline >= DateTime.Parse(_conf.EndDate))
                {
                    throw new System.Exception("The deadline for full papers submission must be before " + _conf.EndDate);
                }
            }
            catch (System.Exception ex)
            {
                HandleException(ex);
                return;
            }
            _conf.FullPaperDeadline = textBox2.Text;
            _ctrl.updateConference(_conf);
            label3.Text = "Full papers deadline: " + _conf.FullPaperDeadline;
            MessageBox.Show("The deadline for full papers was successfully updated.");
        }

        private void HandleException(System.Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
        }
    }
}
