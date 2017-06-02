namespace CodeStars_Iss
{
    partial class AddSections
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
            this.GridViewAllProposals = new System.Windows.Forms.DataGridView();
            this.GridViewChosenProposals = new System.Windows.Forms.DataGridView();
            this.labelAllProposals = new System.Windows.Forms.Label();
            this.labelChosenProposals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAllProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChosenProposals)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewAllProposals
            // 
            this.GridViewAllProposals.AllowUserToAddRows = false;
            this.GridViewAllProposals.AllowUserToDeleteRows = false;
            this.GridViewAllProposals.AllowUserToResizeColumns = false;
            this.GridViewAllProposals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewAllProposals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewAllProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAllProposals.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewAllProposals.Location = new System.Drawing.Point(68, 63);
            this.GridViewAllProposals.Name = "GridViewAllProposals";
            this.GridViewAllProposals.RowHeadersVisible = false;
            this.GridViewAllProposals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewAllProposals.Size = new System.Drawing.Size(351, 294);
            this.GridViewAllProposals.TabIndex = 0;
            // 
            // GridViewChosenProposals
            // 
            this.GridViewChosenProposals.AllowUserToAddRows = false;
            this.GridViewChosenProposals.AllowUserToDeleteRows = false;
            this.GridViewChosenProposals.AllowUserToResizeColumns = false;
            this.GridViewChosenProposals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewChosenProposals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewChosenProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChosenProposals.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewChosenProposals.Location = new System.Drawing.Point(496, 63);
            this.GridViewChosenProposals.Name = "GridViewChosenProposals";
            this.GridViewChosenProposals.RowHeadersVisible = false;
            this.GridViewChosenProposals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewChosenProposals.Size = new System.Drawing.Size(351, 294);
            this.GridViewChosenProposals.TabIndex = 1;
            // 
            // labelAllProposals
            // 
            this.labelAllProposals.AutoSize = true;
            this.labelAllProposals.Location = new System.Drawing.Point(159, 23);
            this.labelAllProposals.Name = "labelAllProposals";
            this.labelAllProposals.Size = new System.Drawing.Size(26, 13);
            this.labelAllProposals.TabIndex = 2;
            this.labelAllProposals.Text = "yjvh";
            // 
            // labelChosenProposals
            // 
            this.labelChosenProposals.AutoSize = true;
            this.labelChosenProposals.Location = new System.Drawing.Point(589, 23);
            this.labelChosenProposals.Name = "labelChosenProposals";
            this.labelChosenProposals.Size = new System.Drawing.Size(26, 13);
            this.labelChosenProposals.TabIndex = 3;
            this.labelChosenProposals.Text = "yjvh";
            // 
            // AddSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 415);
            this.Controls.Add(this.labelChosenProposals);
            this.Controls.Add(this.labelAllProposals);
            this.Controls.Add(this.GridViewChosenProposals);
            this.Controls.Add(this.GridViewAllProposals);
            this.Name = "AddSections";
            this.Text = "AddSections";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAllProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChosenProposals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewAllProposals;
        private System.Windows.Forms.DataGridView GridViewChosenProposals;
        private System.Windows.Forms.Label labelAllProposals;
        private System.Windows.Forms.Label labelChosenProposals;
    }
}