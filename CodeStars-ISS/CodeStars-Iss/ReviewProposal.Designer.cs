﻿namespace CodeStars_Iss
{
    partial class ReviewProposal
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
            this.textBoxAbstract = new System.Windows.Forms.TextBox();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAbstract
            // 
            this.textBoxAbstract.Location = new System.Drawing.Point(169, 42);
            this.textBoxAbstract.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAbstract.Name = "textBoxAbstract";
            this.textBoxAbstract.ReadOnly = true;
            this.textBoxAbstract.Size = new System.Drawing.Size(408, 26);
            this.textBoxAbstract.TabIndex = 0;
            // 
            // textBoxFull
            // 
            this.textBoxFull.Location = new System.Drawing.Point(169, 101);
            this.textBoxFull.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFull.Name = "textBoxFull";
            this.textBoxFull.ReadOnly = true;
            this.textBoxFull.Size = new System.Drawing.Size(408, 26);
            this.textBoxFull.TabIndex = 1;
            // 
            // textBoxReview
            // 
            this.textBoxReview.Location = new System.Drawing.Point(174, 153);
            this.textBoxReview.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReview.Multiline = true;
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(403, 121);
            this.textBoxReview.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Strong Accept",
            "Strong Reject",
            "Weak Accept",
            "Accept",
            "BorderLine Paper",
            "Reject",
            "Weak Reject"});
            this.comboBox1.Location = new System.Drawing.Point(174, 299);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReview.Location = new System.Drawing.Point(441, 300);
            this.buttonAddReview.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(136, 59);
            this.buttonAddReview.TabIndex = 4;
            this.buttonAddReview.Text = "Add Review";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abstract link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Paper Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recommendations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxReview);
            this.Controls.Add(this.textBoxFull);
            this.Controls.Add(this.textBoxAbstract);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewProposal";
            this.Text = "ReviewProposal";
            this.Load += new System.EventHandler(this.ReviewProposal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbstract;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}