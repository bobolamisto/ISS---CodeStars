namespace CodeStars_Iss
{
    partial class ConferenceDetails
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
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewSections = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSections = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMembers.Location = new System.Drawing.Point(32, 37);
            this.dataGridViewMembers.MultiSelect = false;
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RowHeadersVisible = false;
            this.dataGridViewMembers.Size = new System.Drawing.Size(290, 230);
            this.dataGridViewMembers.TabIndex = 0;
            this.dataGridViewMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembers_CellContentClick);
            // 
            // dataGridViewSections
            // 
            this.dataGridViewSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSections.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSections.Location = new System.Drawing.Point(328, 37);
            this.dataGridViewSections.MultiSelect = false;
            this.dataGridViewSections.Name = "dataGridViewSections";
            this.dataGridViewSections.ReadOnly = true;
            this.dataGridViewSections.RowHeadersVisible = false;
            this.dataGridViewSections.Size = new System.Drawing.Size(346, 230);
            this.dataGridViewSections.TabIndex = 1;
            this.dataGridViewSections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSections_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC Members";
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSections.Location = new System.Drawing.Point(436, 9);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(95, 25);
            this.labelSections.TabIndex = 3;
            this.labelSections.Text = "Sections";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConferenceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSections);
            this.Controls.Add(this.dataGridViewMembers);
            this.Name = "ConferenceDetails";
            this.Text = "ConferenceDetails";
            this.Load += new System.EventHandler(this.ConferenceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.DataGridView dataGridViewSections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSections;
        private System.Windows.Forms.Button button1;
    }
}