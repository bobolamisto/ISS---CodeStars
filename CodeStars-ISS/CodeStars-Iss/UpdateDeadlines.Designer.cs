namespace CodeStars_Iss
{
    partial class UpdateDeadlines
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdateAbstract = new System.Windows.Forms.Button();
            this.buttonUpdateFull = new System.Windows.Forms.Button();
            this.dateTimePickerAbstract = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFullPaper = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conference name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abstract deadline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full paper deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New abstract deadline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "New full paper deadline:";
            // 
            // buttonUpdateAbstract
            // 
            this.buttonUpdateAbstract.Location = new System.Drawing.Point(15, 95);
            this.buttonUpdateAbstract.Name = "buttonUpdateAbstract";
            this.buttonUpdateAbstract.Size = new System.Drawing.Size(319, 23);
            this.buttonUpdateAbstract.TabIndex = 7;
            this.buttonUpdateAbstract.Text = "Update abstract deadline";
            this.buttonUpdateAbstract.UseVisualStyleBackColor = true;
            this.buttonUpdateAbstract.Click += new System.EventHandler(this.buttonUpdateAbstract_Click);
            // 
            // buttonUpdateFull
            // 
            this.buttonUpdateFull.Location = new System.Drawing.Point(358, 95);
            this.buttonUpdateFull.Name = "buttonUpdateFull";
            this.buttonUpdateFull.Size = new System.Drawing.Size(315, 23);
            this.buttonUpdateFull.TabIndex = 8;
            this.buttonUpdateFull.Text = "Update full paper deadline";
            this.buttonUpdateFull.UseVisualStyleBackColor = true;
            this.buttonUpdateFull.Click += new System.EventHandler(this.buttonUpdateFull_Click);
            // 
            // dateTimePickerAbstract
            // 
            this.dateTimePickerAbstract.Location = new System.Drawing.Point(134, 69);
            this.dateTimePickerAbstract.Name = "dateTimePickerAbstract";
            this.dateTimePickerAbstract.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAbstract.TabIndex = 9;
            // 
            // dateTimePickerFullPaper
            // 
            this.dateTimePickerFullPaper.Location = new System.Drawing.Point(473, 69);
            this.dateTimePickerFullPaper.Name = "dateTimePickerFullPaper";
            this.dateTimePickerFullPaper.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFullPaper.TabIndex = 10;
            // 
            // UpdateDeadlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 128);
            this.Controls.Add(this.dateTimePickerFullPaper);
            this.Controls.Add(this.dateTimePickerAbstract);
            this.Controls.Add(this.buttonUpdateFull);
            this.Controls.Add(this.buttonUpdateAbstract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeadlines";
            this.Text = "Update Deadlines";
            this.Load += new System.EventHandler(this.UpdateDeadlines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdateAbstract;
        private System.Windows.Forms.Button buttonUpdateFull;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbstract;
        private System.Windows.Forms.DateTimePicker dateTimePickerFullPaper;
    }
}