namespace CodeStars_Iss
{
    partial class ManageAuthors
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddColaborator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(126, 26);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(148, 20);
            this.textBoxUsername.TabIndex = 2;
       //     this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert a username";
            // 
            // buttonAddColaborator
            // 
            this.buttonAddColaborator.Location = new System.Drawing.Point(224, 87);
            this.buttonAddColaborator.Name = "buttonAddColaborator";
            this.buttonAddColaborator.Size = new System.Drawing.Size(133, 23);
            this.buttonAddColaborator.TabIndex = 4;
            this.buttonAddColaborator.Text = "Add Colaborator";
            this.buttonAddColaborator.UseVisualStyleBackColor = true;
            this.buttonAddColaborator.Click += new System.EventHandler(this.buttonAddColaborator_Click);
            // 
            // ManageAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 131);
            this.Controls.Add(this.buttonAddColaborator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "ManageAuthors";
            this.Text = "ManageAuthors";
        //    this.Load += new System.EventHandler(this.ManageAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddColaborator;
    }
}