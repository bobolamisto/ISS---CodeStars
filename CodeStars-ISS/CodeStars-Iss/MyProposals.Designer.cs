namespace CodeStars_Iss
{
    partial class MyProposals
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
            this.GridViewProposals = new System.Windows.Forms.DataGridView();
            this.comboBoxProposalState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewProposals
            // 
            this.GridViewProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProposals.Location = new System.Drawing.Point(12, 59);
            this.GridViewProposals.Name = "GridViewProposals";
            this.GridViewProposals.Size = new System.Drawing.Size(543, 263);
            this.GridViewProposals.TabIndex = 0;
            // 
            // comboBoxProposalState
            // 
            this.comboBoxProposalState.FormattingEnabled = true;
            this.comboBoxProposalState.Location = new System.Drawing.Point(12, 32);
            this.comboBoxProposalState.Name = "comboBoxProposalState";
            this.comboBoxProposalState.Size = new System.Drawing.Size(543, 21);
            this.comboBoxProposalState.TabIndex = 1;
            this.comboBoxProposalState.SelectedIndexChanged += new System.EventHandler(this.comboBoxProposalState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Proposed Papers";
            // 
            // MyProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProposalState);
            this.Controls.Add(this.GridViewProposals);
            this.Name = "MyProposals";
            this.Text = "MyProposals";
            this.Load += new System.EventHandler(this.Landing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewProposals;
        private System.Windows.Forms.ComboBox comboBoxProposalState;
        private System.Windows.Forms.Label label1;
    }
}