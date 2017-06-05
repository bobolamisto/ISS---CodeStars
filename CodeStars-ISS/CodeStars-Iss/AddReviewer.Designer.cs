namespace CodeStars_Iss
{
    partial class AddReviewer
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
            this.ConferenceNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.AddReviewerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConferenceNameLabel
            // 
            this.ConferenceNameLabel.AutoSize = true;
            this.ConferenceNameLabel.Location = new System.Drawing.Point(24, 36);
            this.ConferenceNameLabel.Name = "ConferenceNameLabel";
            this.ConferenceNameLabel.Size = new System.Drawing.Size(68, 13);
            this.ConferenceNameLabel.TabIndex = 0;
            this.ConferenceNameLabel.Text = "Conference: ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(24, 59);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(94, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Insert a username ";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(27, 75);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // AddReviewerButton
            // 
            this.AddReviewerButton.Location = new System.Drawing.Point(165, 75);
            this.AddReviewerButton.Name = "AddReviewerButton";
            this.AddReviewerButton.Size = new System.Drawing.Size(90, 23);
            this.AddReviewerButton.TabIndex = 3;
            this.AddReviewerButton.Text = "Add reviewer";
            this.AddReviewerButton.UseVisualStyleBackColor = true;
            this.AddReviewerButton.Click += new System.EventHandler(this.AddReviewerButton_Click);
            // 
            // AddReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 150);
            this.Controls.Add(this.AddReviewerButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ConferenceNameLabel);
            this.Name = "AddReviewer";
            this.Text = "AddReviewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConferenceNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button AddReviewerButton;
    }
}