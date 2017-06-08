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
            this.buttonSubmittedProposals = new System.Windows.Forms.Button();
            this.buttonMyProposals = new System.Windows.Forms.Button();
            this.buttonMyConferencesAsSpeaker = new System.Windows.Forms.Button();
            this.panelAddProposal = new System.Windows.Forms.Panel();
            this.buttonAddProposal = new System.Windows.Forms.Button();
            this.buttonMyConferencesAsListener = new System.Windows.Forms.Button();
            this.panelSections = new System.Windows.Forms.Panel();
            this.buttonSections = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.PanelReviewer = new System.Windows.Forms.Panel();
            this.ButtonReviewer = new System.Windows.Forms.Button();
            this.panelUpdateDeadlines = new System.Windows.Forms.Panel();
            this.buttonUpdateDeadlines = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PanelCoChair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConferinte)).BeginInit();
            this.panelAddProposal.SuspendLayout();
            this.panelSections.SuspendLayout();
            this.PanelReviewer.SuspendLayout();
            this.panelUpdateDeadlines.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conferences";
            // 
            // ButtonMyConferences
            // 
            this.ButtonMyConferences.Location = new System.Drawing.Point(122, 225);
            this.ButtonMyConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonMyConferences.Name = "ButtonMyConferences";
            this.ButtonMyConferences.Size = new System.Drawing.Size(198, 38);
            this.ButtonMyConferences.TabIndex = 4;
            this.ButtonMyConferences.Text = "Conferences I\'m chair at";
            this.ButtonMyConferences.UseVisualStyleBackColor = true;
            this.ButtonMyConferences.Click += new System.EventHandler(this.ButtonMyConferences_Click);
            // 
            // ButtonAllConferences
            // 
            this.ButtonAllConferences.Location = new System.Drawing.Point(122, 163);
            this.ButtonAllConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAllConferences.Name = "ButtonAllConferences";
            this.ButtonAllConferences.Size = new System.Drawing.Size(198, 38);
            this.ButtonAllConferences.TabIndex = 5;
            this.ButtonAllConferences.Text = "All Conferences";
            this.ButtonAllConferences.UseVisualStyleBackColor = true;
            this.ButtonAllConferences.Click += new System.EventHandler(this.ButtonAllConferences_Click);
            // 
            // ButtonBuyTicket
            // 
            this.ButtonBuyTicket.Location = new System.Drawing.Point(278, 15);
            this.ButtonBuyTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonBuyTicket.Name = "ButtonBuyTicket";
            this.ButtonBuyTicket.Size = new System.Drawing.Size(198, 57);
            this.ButtonBuyTicket.TabIndex = 6;
            this.ButtonBuyTicket.Text = "Buy Ticket";
            this.ButtonBuyTicket.UseVisualStyleBackColor = true;
            this.ButtonBuyTicket.Click += new System.EventHandler(this.ButtonBuyTicket_Click);
            // 
            // PanelCoChair
            // 
            this.PanelCoChair.Controls.Add(this.ButtonCoChair);
            this.PanelCoChair.Location = new System.Drawing.Point(1055, 541);
            this.PanelCoChair.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCoChair.Name = "PanelCoChair";
            this.PanelCoChair.Size = new System.Drawing.Size(172, 61);
            this.PanelCoChair.TabIndex = 7;
            // 
            // ButtonCoChair
            // 
            this.ButtonCoChair.Location = new System.Drawing.Point(3, 11);
            this.ButtonCoChair.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCoChair.Name = "ButtonCoChair";
            this.ButtonCoChair.Size = new System.Drawing.Size(166, 37);
            this.ButtonCoChair.TabIndex = 0;
            this.ButtonCoChair.Text = "Add Co-Chair";
            this.ButtonCoChair.UseVisualStyleBackColor = true;
            this.ButtonCoChair.Click += new System.EventHandler(this.ButtonCoChair_Click);
            // 
            // ButtonAddConference
            // 
            this.ButtonAddConference.Location = new System.Drawing.Point(25, 15);
            this.ButtonAddConference.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddConference.Name = "ButtonAddConference";
            this.ButtonAddConference.Size = new System.Drawing.Size(198, 57);
            this.ButtonAddConference.TabIndex = 8;
            this.ButtonAddConference.Text = "Add Conference";
            this.ButtonAddConference.UseVisualStyleBackColor = true;
            this.ButtonAddConference.Click += new System.EventHandler(this.ButtonAddConference_Click);
            // 
            // GridViewConferinte
            // 
            this.GridViewConferinte.AllowUserToAddRows = false;
            this.GridViewConferinte.AllowUserToDeleteRows = false;
            this.GridViewConferinte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewConferinte.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewConferinte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewConferinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewConferinte.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewConferinte.Location = new System.Drawing.Point(475, 151);
            this.GridViewConferinte.Name = "GridViewConferinte";
            this.GridViewConferinte.ReadOnly = true;
            this.GridViewConferinte.RowHeadersVisible = false;
            this.GridViewConferinte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewConferinte.Size = new System.Drawing.Size(795, 334);
            this.GridViewConferinte.TabIndex = 9;
            this.GridViewConferinte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewConferinte_CellContentClick);
            this.GridViewConferinte.Click += new System.EventHandler(this.GridViewConferinte_Click);
            // 
            // buttonSubmittedProposals
            // 
            this.buttonSubmittedProposals.Location = new System.Drawing.Point(426, 640);
            this.buttonSubmittedProposals.Name = "buttonSubmittedProposals";
            this.buttonSubmittedProposals.Size = new System.Drawing.Size(232, 44);
            this.buttonSubmittedProposals.TabIndex = 13;
            this.buttonSubmittedProposals.Text = "All Submitted Proposals";
            this.buttonSubmittedProposals.UseVisualStyleBackColor = true;
            this.buttonSubmittedProposals.Click += new System.EventHandler(this.buttonSubmittedProposals_Click);
            // 
            // buttonMyProposals
            // 
            this.buttonMyProposals.Location = new System.Drawing.Point(698, 640);
            this.buttonMyProposals.Name = "buttonMyProposals";
            this.buttonMyProposals.Size = new System.Drawing.Size(232, 44);
            this.buttonMyProposals.TabIndex = 14;
            this.buttonMyProposals.Text = "My proposals";
            this.buttonMyProposals.UseVisualStyleBackColor = true;
            this.buttonMyProposals.Click += new System.EventHandler(this.buttonMyProposals_Click);
            // 
            // buttonMyConferencesAsSpeaker
            // 
            this.buttonMyConferencesAsSpeaker.Location = new System.Drawing.Point(122, 423);
            this.buttonMyConferencesAsSpeaker.Name = "buttonMyConferencesAsSpeaker";
            this.buttonMyConferencesAsSpeaker.Size = new System.Drawing.Size(198, 38);
            this.buttonMyConferencesAsSpeaker.TabIndex = 17;
            this.buttonMyConferencesAsSpeaker.Text = "Conferences I\'m speaker at";
            this.buttonMyConferencesAsSpeaker.UseVisualStyleBackColor = true;
            this.buttonMyConferencesAsSpeaker.Click += new System.EventHandler(this.buttonMyConferencesAsSpeaker_Click);
            // 
            // panelAddProposal
            // 
            this.panelAddProposal.Controls.Add(this.buttonAddProposal);
            this.panelAddProposal.Location = new System.Drawing.Point(977, 640);
            this.panelAddProposal.Name = "panelAddProposal";
            this.panelAddProposal.Size = new System.Drawing.Size(232, 44);
            this.panelAddProposal.TabIndex = 18;
            // 
            // buttonAddProposal
            // 
            this.buttonAddProposal.Location = new System.Drawing.Point(0, 0);
            this.buttonAddProposal.Name = "buttonAddProposal";
            this.buttonAddProposal.Size = new System.Drawing.Size(232, 44);
            this.buttonAddProposal.TabIndex = 0;
            this.buttonAddProposal.Text = "Add Proposal";
            this.buttonAddProposal.UseVisualStyleBackColor = true;
            this.buttonAddProposal.Click += new System.EventHandler(this.buttonAddProposal_Click);
            // 
            // buttonMyConferencesAsListener
            // 
            this.buttonMyConferencesAsListener.Location = new System.Drawing.Point(122, 486);
            this.buttonMyConferencesAsListener.Name = "buttonMyConferencesAsListener";
            this.buttonMyConferencesAsListener.Size = new System.Drawing.Size(198, 38);
            this.buttonMyConferencesAsListener.TabIndex = 19;
            this.buttonMyConferencesAsListener.Text = "Conferences I\'m listener at";
            this.buttonMyConferencesAsListener.UseVisualStyleBackColor = true;
            this.buttonMyConferencesAsListener.Click += new System.EventHandler(this.buttonMyConferencesAsListener_Click);
            // 
            // panelSections
            // 
            this.panelSections.Controls.Add(this.buttonSections);
            this.panelSections.Location = new System.Drawing.Point(582, 541);
            this.panelSections.Name = "panelSections";
            this.panelSections.Size = new System.Drawing.Size(172, 61);
            this.panelSections.TabIndex = 20;
            // 
            // buttonSections
            // 
            this.buttonSections.Location = new System.Drawing.Point(3, 11);
            this.buttonSections.Name = "buttonSections";
            this.buttonSections.Size = new System.Drawing.Size(166, 37);
            this.buttonSections.TabIndex = 0;
            this.buttonSections.Text = "Manage Sections";
            this.buttonSections.UseVisualStyleBackColor = true;
            this.buttonSections.Click += new System.EventHandler(this.buttonSections_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(1150, 15);
            this.buttonSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(201, 32);
            this.buttonSwitch.TabIndex = 21;
            this.buttonSwitch.Text = "Switch to Admin Page";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // PanelReviewer
            // 
            this.PanelReviewer.Controls.Add(this.ButtonReviewer);
            this.PanelReviewer.Location = new System.Drawing.Point(815, 541);
            this.PanelReviewer.Name = "PanelReviewer";
            this.PanelReviewer.Size = new System.Drawing.Size(172, 61);
            this.PanelReviewer.TabIndex = 22;
            // 
            // ButtonReviewer
            // 
            this.ButtonReviewer.Location = new System.Drawing.Point(3, 11);
            this.ButtonReviewer.Name = "ButtonReviewer";
            this.ButtonReviewer.Size = new System.Drawing.Size(166, 37);
            this.ButtonReviewer.TabIndex = 1;
            this.ButtonReviewer.Text = "Add Reviewer";
            this.ButtonReviewer.UseVisualStyleBackColor = true;
            this.ButtonReviewer.Click += new System.EventHandler(this.ButtonReviewer_Click);
            // 
            // panelUpdateDeadlines
            // 
            this.panelUpdateDeadlines.Controls.Add(this.buttonUpdateDeadlines);
            this.panelUpdateDeadlines.Location = new System.Drawing.Point(352, 541);
            this.panelUpdateDeadlines.Name = "panelUpdateDeadlines";
            this.panelUpdateDeadlines.Size = new System.Drawing.Size(172, 61);
            this.panelUpdateDeadlines.TabIndex = 21;
            // 
            // buttonUpdateDeadlines
            // 
            this.buttonUpdateDeadlines.Location = new System.Drawing.Point(3, 11);
            this.buttonUpdateDeadlines.Name = "buttonUpdateDeadlines";
            this.buttonUpdateDeadlines.Size = new System.Drawing.Size(166, 37);
            this.buttonUpdateDeadlines.TabIndex = 0;
            this.buttonUpdateDeadlines.Text = "Update deadlines";
            this.buttonUpdateDeadlines.UseVisualStyleBackColor = true;
            this.buttonUpdateDeadlines.Click += new System.EventHandler(this.buttonUpdateDeadlines_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Conferences I\'m reviewer at";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Conferences I\'m co-chair at";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 646);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1277, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 107);
            this.button4.TabIndex = 26;
            this.button4.Text = "Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 707);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelUpdateDeadlines);
            this.Controls.Add(this.PanelReviewer);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.panelSections);
            this.Controls.Add(this.buttonMyConferencesAsListener);
            this.Controls.Add(this.panelAddProposal);
            this.Controls.Add(this.buttonMyConferencesAsSpeaker);
            this.Controls.Add(this.buttonMyProposals);
            this.Controls.Add(this.buttonSubmittedProposals);
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
            this.panelAddProposal.ResumeLayout(false);
            this.panelSections.ResumeLayout(false);
            this.PanelReviewer.ResumeLayout(false);
            this.panelUpdateDeadlines.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonSubmittedProposals;
        private System.Windows.Forms.Button buttonMyProposals;
        private System.Windows.Forms.Button buttonMyConferencesAsSpeaker;
        private System.Windows.Forms.Panel panelAddProposal;
        private System.Windows.Forms.Button buttonAddProposal;
        private System.Windows.Forms.Button buttonMyConferencesAsListener;
        private System.Windows.Forms.Panel panelSections;
        private System.Windows.Forms.Button buttonSections;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Panel PanelReviewer;
        private System.Windows.Forms.Button ButtonReviewer;
        private System.Windows.Forms.Panel panelUpdateDeadlines;
        private System.Windows.Forms.Button buttonUpdateDeadlines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

