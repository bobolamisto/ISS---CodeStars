namespace CodeStars_Iss
{
    partial class Landing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonMyConferences = new System.Windows.Forms.Button();
            this.ButtonAllConferences = new System.Windows.Forms.Button();
            this.ButtonBuyTicket = new System.Windows.Forms.Button();
            this.PanelCoChair = new System.Windows.Forms.Panel();
            this.ButtonCoChair = new System.Windows.Forms.Button();
            this.ButtonAddConference = new System.Windows.Forms.Button();
            this.GridViewConferinte = new System.Windows.Forms.DataGridView();
            this.panelReviewProposal = new System.Windows.Forms.Panel();
            this.buttonReviewProposal = new System.Windows.Forms.Button();
            this.GridViewProposals = new System.Windows.Forms.DataGridView();
            this.buttonProposalsToBeReviewed = new System.Windows.Forms.Button();
            this.buttonMyProposals = new System.Windows.Forms.Button();
            this.panelUpdateProposal = new System.Windows.Forms.Panel();
            this.buttonUpdateProposal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMyConferencesAsSpeaker = new System.Windows.Forms.Button();
            this.panelAddProposal = new System.Windows.Forms.Panel();
            this.buttonAddProposal = new System.Windows.Forms.Button();
            this.buttonMyConferencesAsListener = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSections = new System.Windows.Forms.Button();
            this.ManageAuthorsButton = new System.Windows.Forms.Button();
            this.PanelCoChair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConferinte)).BeginInit();
            this.panelReviewProposal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).BeginInit();
            this.panelUpdateProposal.SuspendLayout();
            this.panelAddProposal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conferences";
            // 
            // ButtonMyConferences
            // 
            this.ButtonMyConferences.Location = new System.Drawing.Point(37, 217);
            this.ButtonMyConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonMyConferences.Name = "ButtonMyConferences";
            this.ButtonMyConferences.Size = new System.Drawing.Size(165, 38);
            this.ButtonMyConferences.TabIndex = 4;
            this.ButtonMyConferences.Text = "Conferences I\'m chair at";
            this.ButtonMyConferences.UseVisualStyleBackColor = true;
            this.ButtonMyConferences.Click += new System.EventHandler(this.ButtonMyConferences_Click);
            // 
            // ButtonAllConferences
            // 
            this.ButtonAllConferences.Location = new System.Drawing.Point(37, 173);
            this.ButtonAllConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAllConferences.Name = "ButtonAllConferences";
            this.ButtonAllConferences.Size = new System.Drawing.Size(165, 38);
            this.ButtonAllConferences.TabIndex = 5;
            this.ButtonAllConferences.Text = "All Conferences";
            this.ButtonAllConferences.UseVisualStyleBackColor = true;
            this.ButtonAllConferences.Click += new System.EventHandler(this.ButtonAllConferences_Click);
            // 
            // ButtonBuyTicket
            // 
            this.ButtonBuyTicket.Location = new System.Drawing.Point(37, 67);
            this.ButtonBuyTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonBuyTicket.Name = "ButtonBuyTicket";
            this.ButtonBuyTicket.Size = new System.Drawing.Size(165, 27);
            this.ButtonBuyTicket.TabIndex = 6;
            this.ButtonBuyTicket.Text = "Buy Ticket";
            this.ButtonBuyTicket.UseVisualStyleBackColor = true;
            this.ButtonBuyTicket.Click += new System.EventHandler(this.ButtonBuyTicket_Click);
            // 
            // PanelCoChair
            // 
            this.PanelCoChair.Controls.Add(this.ButtonCoChair);
            this.PanelCoChair.Location = new System.Drawing.Point(756, 261);
            this.PanelCoChair.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCoChair.Name = "PanelCoChair";
            this.PanelCoChair.Size = new System.Drawing.Size(127, 50);
            this.PanelCoChair.TabIndex = 7;
            // 
            // ButtonCoChair
            // 
            this.ButtonCoChair.Location = new System.Drawing.Point(19, 15);
            this.ButtonCoChair.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCoChair.Name = "ButtonCoChair";
            this.ButtonCoChair.Size = new System.Drawing.Size(92, 20);
            this.ButtonCoChair.TabIndex = 0;
            this.ButtonCoChair.Text = "Add Co-Chair";
            this.ButtonCoChair.UseVisualStyleBackColor = true;
            this.ButtonCoChair.Click += new System.EventHandler(this.ButtonCoChair_Click);
            // 
            // ButtonAddConference
            // 
            this.ButtonAddConference.Location = new System.Drawing.Point(37, 15);
            this.ButtonAddConference.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddConference.Name = "ButtonAddConference";
            this.ButtonAddConference.Size = new System.Drawing.Size(165, 32);
            this.ButtonAddConference.TabIndex = 8;
            this.ButtonAddConference.Text = "Add Conference";
            this.ButtonAddConference.UseVisualStyleBackColor = true;
            this.ButtonAddConference.Click += new System.EventHandler(this.ButtonAddConference_Click);
            // 
            // GridViewConferinte
            // 
            this.GridViewConferinte.AllowUserToAddRows = false;
            this.GridViewConferinte.AllowUserToDeleteRows = false;
            this.GridViewConferinte.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewConferinte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewConferinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewConferinte.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewConferinte.Location = new System.Drawing.Point(240, 53);
            this.GridViewConferinte.Name = "GridViewConferinte";
            this.GridViewConferinte.ReadOnly = true;
            this.GridViewConferinte.RowHeadersVisible = false;
            this.GridViewConferinte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewConferinte.Size = new System.Drawing.Size(771, 193);
            this.GridViewConferinte.TabIndex = 9;
            this.GridViewConferinte.Click += new System.EventHandler(this.GridViewConferinte_Click);
            // 
            // panelReviewProposal
            // 
            this.panelReviewProposal.Controls.Add(this.buttonReviewProposal);
            this.panelReviewProposal.Location = new System.Drawing.Point(756, 612);
            this.panelReviewProposal.Name = "panelReviewProposal";
            this.panelReviewProposal.Size = new System.Drawing.Size(133, 50);
            this.panelReviewProposal.TabIndex = 11;
            // 
            // buttonReviewProposal
            // 
            this.buttonReviewProposal.Location = new System.Drawing.Point(6, 14);
            this.buttonReviewProposal.Name = "buttonReviewProposal";
            this.buttonReviewProposal.Size = new System.Drawing.Size(105, 29);
            this.buttonReviewProposal.TabIndex = 0;
            this.buttonReviewProposal.Text = "Review proposal";
            this.buttonReviewProposal.UseVisualStyleBackColor = true;
            this.buttonReviewProposal.Click += new System.EventHandler(this.buttonReviewProposal_Click);
            // 
            // GridViewProposals
            // 
            this.GridViewProposals.AllowUserToAddRows = false;
            this.GridViewProposals.AllowUserToDeleteRows = false;
            this.GridViewProposals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewProposals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProposals.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewProposals.Location = new System.Drawing.Point(240, 341);
            this.GridViewProposals.Name = "GridViewProposals";
            this.GridViewProposals.ReadOnly = true;
            this.GridViewProposals.RowHeadersVisible = false;
            this.GridViewProposals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProposals.Size = new System.Drawing.Size(771, 254);
            this.GridViewProposals.TabIndex = 12;
            // 
            // buttonProposalsToBeReviewed
            // 
            this.buttonProposalsToBeReviewed.Location = new System.Drawing.Point(37, 497);
            this.buttonProposalsToBeReviewed.Name = "buttonProposalsToBeReviewed";
            this.buttonProposalsToBeReviewed.Size = new System.Drawing.Size(165, 44);
            this.buttonProposalsToBeReviewed.TabIndex = 13;
            this.buttonProposalsToBeReviewed.Text = "Proposals to be reviewed";
            this.buttonProposalsToBeReviewed.UseVisualStyleBackColor = true;
            this.buttonProposalsToBeReviewed.Click += new System.EventHandler(this.buttonProposalsToBeReviewed_Click);
            // 
            // buttonMyProposals
            // 
            this.buttonMyProposals.Location = new System.Drawing.Point(37, 557);
            this.buttonMyProposals.Name = "buttonMyProposals";
            this.buttonMyProposals.Size = new System.Drawing.Size(165, 38);
            this.buttonMyProposals.TabIndex = 14;
            this.buttonMyProposals.Text = "My proposals";
            this.buttonMyProposals.UseVisualStyleBackColor = true;
            this.buttonMyProposals.Click += new System.EventHandler(this.buttonMyProposals_Click);
            // 
            // panelUpdateProposal
            // 
            this.panelUpdateProposal.Controls.Add(this.ManageAuthorsButton);
            this.panelUpdateProposal.Controls.Add(this.buttonUpdateProposal);
            this.panelUpdateProposal.Location = new System.Drawing.Point(461, 615);
            this.panelUpdateProposal.Name = "panelUpdateProposal";
            this.panelUpdateProposal.Size = new System.Drawing.Size(286, 47);
            this.panelUpdateProposal.TabIndex = 15;
            // 
            // buttonUpdateProposal
            // 
            this.buttonUpdateProposal.Location = new System.Drawing.Point(12, 10);
            this.buttonUpdateProposal.Name = "buttonUpdateProposal";
            this.buttonUpdateProposal.Size = new System.Drawing.Size(118, 30);
            this.buttonUpdateProposal.TabIndex = 0;
            this.buttonUpdateProposal.Text = "Update proposal";
            this.buttonUpdateProposal.UseVisualStyleBackColor = true;
            this.buttonUpdateProposal.Click += new System.EventHandler(this.buttonUpdateProposal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proposals";
            // 
            // buttonMyConferencesAsSpeaker
            // 
            this.buttonMyConferencesAsSpeaker.Location = new System.Drawing.Point(37, 261);
            this.buttonMyConferencesAsSpeaker.Name = "buttonMyConferencesAsSpeaker";
            this.buttonMyConferencesAsSpeaker.Size = new System.Drawing.Size(165, 38);
            this.buttonMyConferencesAsSpeaker.TabIndex = 17;
            this.buttonMyConferencesAsSpeaker.Text = "Conferences I\'m speaker at";
            this.buttonMyConferencesAsSpeaker.UseVisualStyleBackColor = true;
            this.buttonMyConferencesAsSpeaker.Click += new System.EventHandler(this.buttonMyConferencesAsSpeaker_Click);
            // 
            // panelAddProposal
            // 
            this.panelAddProposal.Controls.Add(this.buttonAddProposal);
            this.panelAddProposal.Location = new System.Drawing.Point(589, 261);
            this.panelAddProposal.Name = "panelAddProposal";
            this.panelAddProposal.Size = new System.Drawing.Size(148, 50);
            this.panelAddProposal.TabIndex = 18;
            // 
            // buttonAddProposal
            // 
            this.buttonAddProposal.Location = new System.Drawing.Point(18, 15);
            this.buttonAddProposal.Name = "buttonAddProposal";
            this.buttonAddProposal.Size = new System.Drawing.Size(105, 23);
            this.buttonAddProposal.TabIndex = 0;
            this.buttonAddProposal.Text = "Add Proposal";
            this.buttonAddProposal.UseVisualStyleBackColor = true;
            this.buttonAddProposal.Click += new System.EventHandler(this.buttonAddProposal_Click);
            // 
            // buttonMyConferencesAsListener
            // 
            this.buttonMyConferencesAsListener.Location = new System.Drawing.Point(37, 308);
            this.buttonMyConferencesAsListener.Name = "buttonMyConferencesAsListener";
            this.buttonMyConferencesAsListener.Size = new System.Drawing.Size(165, 38);
            this.buttonMyConferencesAsListener.TabIndex = 19;
            this.buttonMyConferencesAsListener.Text = "Conferences I\'m listener at";
            this.buttonMyConferencesAsListener.UseVisualStyleBackColor = true;
            this.buttonMyConferencesAsListener.Click += new System.EventHandler(this.buttonMyConferencesAsListener_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSections);
            this.panel1.Location = new System.Drawing.Point(422, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 50);
            this.panel1.TabIndex = 20;
            // 
            // buttonSections
            // 
            this.buttonSections.Location = new System.Drawing.Point(3, 15);
            this.buttonSections.Name = "buttonSections";
            this.buttonSections.Size = new System.Drawing.Size(142, 23);
            this.buttonSections.TabIndex = 0;
            this.buttonSections.Text = "Manage Sections";
            this.buttonSections.UseVisualStyleBackColor = true;
            this.buttonSections.Click += new System.EventHandler(this.buttonSections_Click);
            // 
            // ManageAuthorsButton
            // 
            this.ManageAuthorsButton.Location = new System.Drawing.Point(146, 10);
            this.ManageAuthorsButton.Name = "ManageAuthorsButton";
            this.ManageAuthorsButton.Size = new System.Drawing.Size(130, 30);
            this.ManageAuthorsButton.TabIndex = 1;
            this.ManageAuthorsButton.Text = "Manage Authors";
            this.ManageAuthorsButton.UseVisualStyleBackColor = true;
            this.ManageAuthorsButton.Click += new System.EventHandler(this.ManageAuthorsButton_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMyConferencesAsListener);
            this.Controls.Add(this.panelAddProposal);
            this.Controls.Add(this.buttonMyConferencesAsSpeaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelUpdateProposal);
            this.Controls.Add(this.buttonMyProposals);
            this.Controls.Add(this.buttonProposalsToBeReviewed);
            this.Controls.Add(this.GridViewProposals);
            this.Controls.Add(this.panelReviewProposal);
            this.Controls.Add(this.GridViewConferinte);
            this.Controls.Add(this.ButtonAddConference);
            this.Controls.Add(this.PanelCoChair);
            this.Controls.Add(this.ButtonBuyTicket);
            this.Controls.Add(this.ButtonAllConferences);
            this.Controls.Add(this.ButtonMyConferences);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Landing";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.PanelCoChair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConferinte)).EndInit();
            this.panelReviewProposal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).EndInit();
            this.panelUpdateProposal.ResumeLayout(false);
            this.panelAddProposal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonMyConferences;
        private System.Windows.Forms.Button ButtonAllConferences;
        private System.Windows.Forms.Button ButtonBuyTicket;
        private System.Windows.Forms.Panel PanelCoChair;
        private System.Windows.Forms.Button ButtonCoChair;
        private System.Windows.Forms.Button ButtonAddConference;
        private System.Windows.Forms.DataGridView GridViewConferinte;
        private System.Windows.Forms.Panel panelReviewProposal;
        private System.Windows.Forms.Button buttonReviewProposal;
        private System.Windows.Forms.DataGridView GridViewProposals;
        private System.Windows.Forms.Button buttonProposalsToBeReviewed;
        private System.Windows.Forms.Button buttonMyProposals;
        private System.Windows.Forms.Panel panelUpdateProposal;
        private System.Windows.Forms.Button buttonUpdateProposal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMyConferencesAsSpeaker;
        private System.Windows.Forms.Panel panelAddProposal;
        private System.Windows.Forms.Button buttonAddProposal;
        private System.Windows.Forms.Button buttonMyConferencesAsListener;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSections;
        private System.Windows.Forms.Button ManageAuthorsButton;
    }
}

