﻿namespace CodeStars_Iss
{
    partial class LandingAdmin
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
            this.dataGridConferences = new System.Windows.Forms.DataGridView();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.Conferences = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPendingConferences = new System.Windows.Forms.Button();
            this.buttonAcceptedConferences = new System.Windows.Forms.Button();
            this.buttonReviewConferences = new System.Windows.Forms.Button();
            this.panelAcceptDeclineConferences = new System.Windows.Forms.Panel();
            this.buttonDeclineConference = new System.Windows.Forms.Button();
            this.buttonAcceptConference = new System.Windows.Forms.Button();
            this.buttonAcceptUser = new System.Windows.Forms.Button();
            this.buttonPendingUsers = new System.Windows.Forms.Button();
            this.buttonDeclineUser = new System.Windows.Forms.Button();
            this.panelAcceptDeclineUsers = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.panelAcceptDeclineConferences.SuspendLayout();
            this.panelAcceptDeclineUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridConferences
            // 
            this.dataGridConferences.AllowUserToAddRows = false;
            this.dataGridConferences.AllowUserToDeleteRows = false;
            this.dataGridConferences.AllowUserToResizeColumns = false;
            this.dataGridConferences.AllowUserToResizeRows = false;
            this.dataGridConferences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridConferences.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridConferences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConferences.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridConferences.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridConferences.Location = new System.Drawing.Point(340, 84);
            this.dataGridConferences.MultiSelect = false;
            this.dataGridConferences.Name = "dataGridConferences";
            this.dataGridConferences.ReadOnly = true;
            this.dataGridConferences.RowHeadersVisible = false;
            this.dataGridConferences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConferences.Size = new System.Drawing.Size(885, 262);
            this.dataGridConferences.TabIndex = 0;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridUsers.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridUsers.Location = new System.Drawing.Point(418, 413);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(359, 243);
            this.dataGridUsers.TabIndex = 1;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // Conferences
            // 
            this.Conferences.AutoSize = true;
            this.Conferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conferences.Location = new System.Drawing.Point(577, 27);
            this.Conferences.Name = "Conferences";
            this.Conferences.Size = new System.Drawing.Size(129, 24);
            this.Conferences.TabIndex = 2;
            this.Conferences.Text = "Conferences";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Conferences:";
            // 
            // buttonPendingConferences
            // 
            this.buttonPendingConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPendingConferences.Location = new System.Drawing.Point(158, 169);
            this.buttonPendingConferences.Name = "buttonPendingConferences";
            this.buttonPendingConferences.Size = new System.Drawing.Size(91, 34);
            this.buttonPendingConferences.TabIndex = 6;
            this.buttonPendingConferences.Text = "Pending";
            this.buttonPendingConferences.UseVisualStyleBackColor = true;
            this.buttonPendingConferences.Click += new System.EventHandler(this.buttonPendingConferences_Click);
            // 
            // buttonAcceptedConferences
            // 
            this.buttonAcceptedConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptedConferences.Location = new System.Drawing.Point(158, 125);
            this.buttonAcceptedConferences.Name = "buttonAcceptedConferences";
            this.buttonAcceptedConferences.Size = new System.Drawing.Size(91, 38);
            this.buttonAcceptedConferences.TabIndex = 7;
            this.buttonAcceptedConferences.Text = "Accepted";
            this.buttonAcceptedConferences.UseVisualStyleBackColor = true;
            this.buttonAcceptedConferences.Click += new System.EventHandler(this.buttonAcceptedConferences_Click);
            // 
            // buttonReviewConferences
            // 
            this.buttonReviewConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReviewConferences.Location = new System.Drawing.Point(158, 209);
            this.buttonReviewConferences.Name = "buttonReviewConferences";
            this.buttonReviewConferences.Size = new System.Drawing.Size(91, 32);
            this.buttonReviewConferences.TabIndex = 8;
            this.buttonReviewConferences.Text = "Declined";
            this.buttonReviewConferences.UseVisualStyleBackColor = true;
            this.buttonReviewConferences.Click += new System.EventHandler(this.buttonReviewConferences_Click);
            // 
            // panelAcceptDeclineConferences
            // 
            this.panelAcceptDeclineConferences.Controls.Add(this.buttonDeclineConference);
            this.panelAcceptDeclineConferences.Controls.Add(this.buttonAcceptConference);
            this.panelAcceptDeclineConferences.Location = new System.Drawing.Point(136, 271);
            this.panelAcceptDeclineConferences.Name = "panelAcceptDeclineConferences";
            this.panelAcceptDeclineConferences.Size = new System.Drawing.Size(157, 100);
            this.panelAcceptDeclineConferences.TabIndex = 9;
            // 
            // buttonDeclineConference
            // 
            this.buttonDeclineConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeclineConference.Location = new System.Drawing.Point(26, 62);
            this.buttonDeclineConference.Name = "buttonDeclineConference";
            this.buttonDeclineConference.Size = new System.Drawing.Size(75, 23);
            this.buttonDeclineConference.TabIndex = 1;
            this.buttonDeclineConference.Text = "Decline";
            this.buttonDeclineConference.UseVisualStyleBackColor = true;
            this.buttonDeclineConference.Click += new System.EventHandler(this.buttonDeclineConference_Click);
            // 
            // buttonAcceptConference
            // 
            this.buttonAcceptConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptConference.Location = new System.Drawing.Point(26, 22);
            this.buttonAcceptConference.Name = "buttonAcceptConference";
            this.buttonAcceptConference.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptConference.TabIndex = 0;
            this.buttonAcceptConference.Text = "Accept";
            this.buttonAcceptConference.UseVisualStyleBackColor = true;
            this.buttonAcceptConference.Click += new System.EventHandler(this.buttonAcceptConference_Click);
            // 
            // buttonAcceptUser
            // 
            this.buttonAcceptUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptUser.Location = new System.Drawing.Point(32, 14);
            this.buttonAcceptUser.Name = "buttonAcceptUser";
            this.buttonAcceptUser.Size = new System.Drawing.Size(103, 23);
            this.buttonAcceptUser.TabIndex = 10;
            this.buttonAcceptUser.Text = "Accept User";
            this.buttonAcceptUser.UseVisualStyleBackColor = true;
            this.buttonAcceptUser.Click += new System.EventHandler(this.buttonAcceptUser_Click);
            // 
            // buttonPendingUsers
            // 
            this.buttonPendingUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPendingUsers.Location = new System.Drawing.Point(862, 500);
            this.buttonPendingUsers.Name = "buttonPendingUsers";
            this.buttonPendingUsers.Size = new System.Drawing.Size(145, 38);
            this.buttonPendingUsers.TabIndex = 11;
            this.buttonPendingUsers.Text = "Pending Users";
            this.buttonPendingUsers.UseVisualStyleBackColor = true;
            this.buttonPendingUsers.Click += new System.EventHandler(this.buttonPendingUsers_Click);
            // 
            // buttonDeclineUser
            // 
            this.buttonDeclineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeclineUser.Location = new System.Drawing.Point(32, 55);
            this.buttonDeclineUser.Name = "buttonDeclineUser";
            this.buttonDeclineUser.Size = new System.Drawing.Size(111, 30);
            this.buttonDeclineUser.TabIndex = 14;
            this.buttonDeclineUser.Text = "Decline User";
            this.buttonDeclineUser.UseVisualStyleBackColor = true;
            this.buttonDeclineUser.Click += new System.EventHandler(this.buttonDeclineUser_Click);
            // 
            // panelAcceptDeclineUsers
            // 
            this.panelAcceptDeclineUsers.Controls.Add(this.buttonDeclineUser);
            this.panelAcceptDeclineUsers.Controls.Add(this.buttonAcceptUser);
            this.panelAcceptDeclineUsers.Location = new System.Drawing.Point(848, 588);
            this.panelAcceptDeclineUsers.Name = "panelAcceptDeclineUsers";
            this.panelAcceptDeclineUsers.Size = new System.Drawing.Size(176, 100);
            this.panelAcceptDeclineUsers.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(884, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "View Users:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitch.Location = new System.Drawing.Point(1159, 12);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(191, 27);
            this.buttonSwitch.TabIndex = 18;
            this.buttonSwitch.Text = "Switch to User Page";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Declined Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(862, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 22;
            this.button2.Text = "Accepted Users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 652);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LandingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelAcceptDeclineUsers);
            this.Controls.Add(this.buttonPendingUsers);
            this.Controls.Add(this.panelAcceptDeclineConferences);
            this.Controls.Add(this.buttonReviewConferences);
            this.Controls.Add(this.buttonAcceptedConferences);
            this.Controls.Add(this.buttonPendingConferences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Conferences);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.dataGridConferences);
            this.Name = "LandingAdmin";
            this.Text = "LandingAdmin";
            this.Load += new System.EventHandler(this.LandingAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.panelAcceptDeclineConferences.ResumeLayout(false);
            this.panelAcceptDeclineUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConferences;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Label Conferences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPendingConferences;
        private System.Windows.Forms.Button buttonAcceptedConferences;
        private System.Windows.Forms.Button buttonReviewConferences;
        private System.Windows.Forms.Panel panelAcceptDeclineConferences;
        private System.Windows.Forms.Button buttonDeclineConference;
        private System.Windows.Forms.Button buttonAcceptConference;
        private System.Windows.Forms.Button buttonAcceptUser;
        private System.Windows.Forms.Button buttonPendingUsers;
        private System.Windows.Forms.Button buttonDeclineUser;
        private System.Windows.Forms.Panel panelAcceptDeclineUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}