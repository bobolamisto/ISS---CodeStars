﻿using CodeStars_Iss.Controller;
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
    public partial class ReviewProposal : Form
    {
       private ClientController ctrl;
        private ProposalDTO proposal;
        private int reviewerId;
        public ReviewProposal(ClientController ctr,ProposalDTO proposal,int reviewerId)
        {
            this.ctrl = ctr;
            this.proposal = proposal;
            this.reviewerId = reviewerId;
            InitializeComponent();
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            string mark = comboBox1.Text;
            string recomm = textBoxReview.Text;
            var ok=ctrl.addReview(new ReviewDTO(0, mark, recomm, proposal.Id, reviewerId));
            if(ok!=null)
            {
                MessageBox.Show("Review added successfully");
                this.Close();
            }
        }

        

        private void ReviewProposal_Load(object sender, EventArgs e)
        {
            textBoxAbstract.Text = proposal.Abstract;
            textBoxFull.Text = proposal.FullPaper;

            var marks = ctrl.getData<Mark>();
            comboBox1.DataSource = marks;
            comboBox1.DisplayMember = "Value";
        }
    }
}
