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
            this.buttonAddColaborators = new System.Windows.Forms.Button();
            this.buttonUpdateProposal = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttonReviewProposal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewProposals
            // 
            this.GridViewProposals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewProposals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProposals.GridColor = System.Drawing.SystemColors.Control;
            this.GridViewProposals.Location = new System.Drawing.Point(12, 59);
            this.GridViewProposals.Name = "GridViewProposals";
            this.GridViewProposals.RowHeadersVisible = false;
            this.GridViewProposals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProposals.Size = new System.Drawing.Size(619, 263);
            this.GridViewProposals.TabIndex = 0;
            // 
            // comboBoxProposalState
            // 
            this.comboBoxProposalState.FormattingEnabled = true;
            this.comboBoxProposalState.Location = new System.Drawing.Point(12, 32);
            this.comboBoxProposalState.Name = "comboBoxProposalState";
            this.comboBoxProposalState.Size = new System.Drawing.Size(619, 21);
            this.comboBoxProposalState.TabIndex = 1;
            this.comboBoxProposalState.SelectedIndexChanged += new System.EventHandler(this.comboBoxProposalState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Proposed Papers";
            // 
            // buttonAddColaborators
            // 
            this.buttonAddColaborators.Location = new System.Drawing.Point(144, 3);
            this.buttonAddColaborators.Name = "buttonAddColaborators";
            this.buttonAddColaborators.Size = new System.Drawing.Size(118, 23);
            this.buttonAddColaborators.TabIndex = 3;
            this.buttonAddColaborators.Text = "Add Collaborators";
            this.buttonAddColaborators.UseVisualStyleBackColor = true;
            this.buttonAddColaborators.Click += new System.EventHandler(this.buttonAddColaborators_Click);
            // 
            // buttonUpdateProposal
            // 
            this.buttonUpdateProposal.Location = new System.Drawing.Point(20, 3);
            this.buttonUpdateProposal.Name = "buttonUpdateProposal";
            this.buttonUpdateProposal.Size = new System.Drawing.Size(118, 23);
            this.buttonUpdateProposal.TabIndex = 4;
            this.buttonUpdateProposal.Text = "Update Proposal";
            this.buttonUpdateProposal.UseVisualStyleBackColor = true;
            this.buttonUpdateProposal.Click += new System.EventHandler(this.buttonUpdateProposal_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.buttonUpdateProposal);
            this.panelUpdate.Controls.Add(this.buttonAddColaborators);
            this.panelUpdate.Location = new System.Drawing.Point(172, 328);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(278, 32);
            this.panelUpdate.TabIndex = 5;
            // 
            // buttonReviewProposal
            // 
            this.buttonReviewProposal.Location = new System.Drawing.Point(496, 331);
            this.buttonReviewProposal.Name = "buttonReviewProposal";
            this.buttonReviewProposal.Size = new System.Drawing.Size(118, 23);
            this.buttonReviewProposal.TabIndex = 6;
            this.buttonReviewProposal.Text = "Review Proposal";
            this.buttonReviewProposal.UseVisualStyleBackColor = true;
            this.buttonReviewProposal.Click += new System.EventHandler(this.buttonReviewProposal_Click);
            // 
            // MyProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 369);
            this.Controls.Add(this.buttonReviewProposal);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProposalState);
            this.Controls.Add(this.GridViewProposals);
            this.Name = "MyProposals";
            this.Text = "MyProposals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyProposals_FormClosed);
            this.Load += new System.EventHandler(this.Landing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProposals)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewProposals;
        private System.Windows.Forms.ComboBox comboBoxProposalState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddColaborators;
        private System.Windows.Forms.Button buttonUpdateProposal;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button buttonReviewProposal;
    }
}