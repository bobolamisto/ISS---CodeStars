namespace CodeStars_Iss
{
    partial class AddConference
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.ButtonAddConference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(130, 71);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(148, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(130, 125);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGenre.TabIndex = 4;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(130, 177);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDate.TabIndex = 5;
            // 
            // ButtonAddConference
            // 
            this.ButtonAddConference.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddConference.Location = new System.Drawing.Point(212, 259);
            this.ButtonAddConference.Name = "ButtonAddConference";
            this.ButtonAddConference.Size = new System.Drawing.Size(87, 28);
            this.ButtonAddConference.TabIndex = 6;
            this.ButtonAddConference.Text = "Done";
            this.ButtonAddConference.UseVisualStyleBackColor = true;
            this.ButtonAddConference.Click += new System.EventHandler(this.ButtonAddConference_Click);
            // 
            // AddConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 342);
            this.Controls.Add(this.ButtonAddConference);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxGenre);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddConference";
            this.Text = "AddConference";
            this.Load += new System.EventHandler(this.AddConference_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.Button ButtonAddConference;
    }
}