﻿namespace CodeStars_Iss
{
    partial class AddCoChair
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
            this.selectCoChairLabel = new System.Windows.Forms.Label();
            this.addCoChairButton = new System.Windows.Forms.Button();
            this.conferenceNameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectCoChairLabel
            // 
            this.selectCoChairLabel.AutoSize = true;
            this.selectCoChairLabel.Location = new System.Drawing.Point(32, 43);
            this.selectCoChairLabel.Name = "selectCoChairLabel";
            this.selectCoChairLabel.Size = new System.Drawing.Size(94, 13);
            this.selectCoChairLabel.TabIndex = 0;
            this.selectCoChairLabel.Text = "Insert a username ";
            // 
            // addCoChairButton
            // 
            this.addCoChairButton.Location = new System.Drawing.Point(191, 59);
            this.addCoChairButton.Name = "addCoChairButton";
            this.addCoChairButton.Size = new System.Drawing.Size(75, 23);
            this.addCoChairButton.TabIndex = 2;
            this.addCoChairButton.Text = "Add co-chair";
            this.addCoChairButton.UseVisualStyleBackColor = true;
            this.addCoChairButton.Click += new System.EventHandler(this.addCoChairButton_Click);
            // 
            // conferenceNameLabel
            // 
            this.conferenceNameLabel.AutoSize = true;
            this.conferenceNameLabel.Location = new System.Drawing.Point(32, 19);
            this.conferenceNameLabel.Name = "conferenceNameLabel";
            this.conferenceNameLabel.Size = new System.Drawing.Size(68, 13);
            this.conferenceNameLabel.TabIndex = 3;
            this.conferenceNameLabel.Text = "Conference: ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(32, 62);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // AddCoChair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 124);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.conferenceNameLabel);
            this.Controls.Add(this.addCoChairButton);
            this.Controls.Add(this.selectCoChairLabel);
            this.Name = "AddCoChair";
            this.Text = "AddCoChair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectCoChairLabel;
        private System.Windows.Forms.Button addCoChairButton;
        private System.Windows.Forms.Label conferenceNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}