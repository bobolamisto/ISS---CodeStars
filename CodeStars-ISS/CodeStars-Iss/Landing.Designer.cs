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
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.ConferencesList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonMyConferences = new System.Windows.Forms.Button();
            this.ButtonAllConferences = new System.Windows.Forms.Button();
            this.ButtonBuyTicket = new System.Windows.Forms.Button();
            this.PanelCoChair = new System.Windows.Forms.Panel();
            this.ButtonCoChair = new System.Windows.Forms.Button();
            this.ButtonAddConference = new System.Windows.Forms.Button();
            this.PanelCoChair.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Location = new System.Drawing.Point(575, 15);
            this.FullScreenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(88, 27);
            this.FullScreenButton.TabIndex = 0;
            this.FullScreenButton.Text = "FullScreen";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // ConferencesList
            // 
            this.ConferencesList.Location = new System.Drawing.Point(236, 53);
            this.ConferencesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConferencesList.Name = "ConferencesList";
            this.ConferencesList.Size = new System.Drawing.Size(269, 316);
            this.ConferencesList.TabIndex = 1;
            this.ConferencesList.UseCompatibleStateImageBehavior = false;
            this.ConferencesList.SelectedIndexChanged += new System.EventHandler(this.ConferencesList_SelectedIndexChanged);
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
            this.ButtonMyConferences.Location = new System.Drawing.Point(37, 53);
            this.ButtonMyConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonMyConferences.Name = "ButtonMyConferences";
            this.ButtonMyConferences.Size = new System.Drawing.Size(111, 31);
            this.ButtonMyConferences.TabIndex = 4;
            this.ButtonMyConferences.Text = "My Conferences";
            this.ButtonMyConferences.UseVisualStyleBackColor = true;
            this.ButtonMyConferences.Click += new System.EventHandler(this.ButtonMyConferences_Click);
            // 
            // ButtonAllConferences
            // 
            this.ButtonAllConferences.Location = new System.Drawing.Point(37, 91);
            this.ButtonAllConferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAllConferences.Name = "ButtonAllConferences";
            this.ButtonAllConferences.Size = new System.Drawing.Size(111, 29);
            this.ButtonAllConferences.TabIndex = 5;
            this.ButtonAllConferences.Text = "All Conferences";
            this.ButtonAllConferences.UseVisualStyleBackColor = true;
            this.ButtonAllConferences.Click += new System.EventHandler(this.ButtonAllConferences_Click);
            // 
            // ButtonBuyTicket
            // 
            this.ButtonBuyTicket.Location = new System.Drawing.Point(37, 153);
            this.ButtonBuyTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonBuyTicket.Name = "ButtonBuyTicket";
            this.ButtonBuyTicket.Size = new System.Drawing.Size(88, 27);
            this.ButtonBuyTicket.TabIndex = 6;
            this.ButtonBuyTicket.Text = "Buy Ticket";
            this.ButtonBuyTicket.UseVisualStyleBackColor = true;
            this.ButtonBuyTicket.Click += new System.EventHandler(this.ButtonBuyTicket_Click);
            // 
            // PanelCoChair
            // 
            this.PanelCoChair.Controls.Add(this.ButtonCoChair);
            this.PanelCoChair.Location = new System.Drawing.Point(37, 301);
            this.PanelCoChair.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCoChair.Name = "PanelCoChair";
            this.PanelCoChair.Size = new System.Drawing.Size(127, 68);
            this.PanelCoChair.TabIndex = 7;
            // 
            // ButtonCoChair
            // 
            this.ButtonCoChair.Location = new System.Drawing.Point(19, 24);
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
            this.ButtonAddConference.Size = new System.Drawing.Size(111, 32);
            this.ButtonAddConference.TabIndex = 8;
            this.ButtonAddConference.Text = "Add Conference";
            this.ButtonAddConference.UseVisualStyleBackColor = true;
            this.ButtonAddConference.Click += new System.EventHandler(this.ButtonAddConference_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.ButtonAddConference);
            this.Controls.Add(this.PanelCoChair);
            this.Controls.Add(this.ButtonBuyTicket);
            this.Controls.Add(this.ButtonAllConferences);
            this.Controls.Add(this.ButtonMyConferences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConferencesList);
            this.Controls.Add(this.FullScreenButton);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Landing";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Landing_KeyDown);
            this.PanelCoChair.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.ListView ConferencesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonMyConferences;
        private System.Windows.Forms.Button ButtonAllConferences;
        private System.Windows.Forms.Button ButtonBuyTicket;
        private System.Windows.Forms.Panel PanelCoChair;
        private System.Windows.Forms.Button ButtonCoChair;
        private System.Windows.Forms.Button ButtonAddConference;
    }
}

