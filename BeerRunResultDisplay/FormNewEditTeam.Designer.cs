namespace BeerRunResultDisplay
{
    partial class FormNewEditTeam
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
            this.mLblTeamName = new System.Windows.Forms.Label();
            this.mLblTeamMembers = new System.Windows.Forms.Label();
            this.mLblStart = new System.Windows.Forms.Label();
            this.mLblEnd = new System.Windows.Forms.Label();
            this.mLblPenaltyMinutes = new System.Windows.Forms.Label();
            this.mBtnCancel = new System.Windows.Forms.Button();
            this.mBtnAddEdit = new System.Windows.Forms.Button();
            this.mTbTeamName = new System.Windows.Forms.TextBox();
            this.mTbTeamMembers = new System.Windows.Forms.TextBox();
            this.mTbStart = new System.Windows.Forms.TextBox();
            this.mTbEnd = new System.Windows.Forms.TextBox();
            this.mNumUDPenaltyMinutes = new System.Windows.Forms.NumericUpDown();
            this.linkLabelSetTimeNow = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDPenaltyMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // mLblTeamName
            // 
            this.mLblTeamName.AutoSize = true;
            this.mLblTeamName.Location = new System.Drawing.Point(32, 9);
            this.mLblTeamName.Name = "mLblTeamName";
            this.mLblTeamName.Size = new System.Drawing.Size(66, 13);
            this.mLblTeamName.TabIndex = 0;
            this.mLblTeamName.Text = "Název týmu:";
            // 
            // mLblTeamMembers
            // 
            this.mLblTeamMembers.AutoSize = true;
            this.mLblTeamMembers.Location = new System.Drawing.Point(49, 35);
            this.mLblTeamMembers.Name = "mLblTeamMembers";
            this.mLblTeamMembers.Size = new System.Drawing.Size(49, 13);
            this.mLblTeamMembers.TabIndex = 1;
            this.mLblTeamMembers.Text = "Členové:";
            // 
            // mLblStart
            // 
            this.mLblStart.AutoSize = true;
            this.mLblStart.Location = new System.Drawing.Point(66, 59);
            this.mLblStart.Name = "mLblStart";
            this.mLblStart.Size = new System.Drawing.Size(32, 13);
            this.mLblStart.TabIndex = 1;
            this.mLblStart.Text = "Start:";
            // 
            // mLblEnd
            // 
            this.mLblEnd.AutoSize = true;
            this.mLblEnd.Location = new System.Drawing.Point(57, 85);
            this.mLblEnd.Name = "mLblEnd";
            this.mLblEnd.Size = new System.Drawing.Size(41, 13);
            this.mLblEnd.TabIndex = 1;
            this.mLblEnd.Text = "Konec:";
            // 
            // mLblPenaltyMinutes
            // 
            this.mLblPenaltyMinutes.AutoSize = true;
            this.mLblPenaltyMinutes.Location = new System.Drawing.Point(19, 111);
            this.mLblPenaltyMinutes.Name = "mLblPenaltyMinutes";
            this.mLblPenaltyMinutes.Size = new System.Drawing.Size(79, 13);
            this.mLblPenaltyMinutes.TabIndex = 1;
            this.mLblPenaltyMinutes.Text = "Trestné minuty:";
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mBtnCancel.Location = new System.Drawing.Point(69, 160);
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mBtnCancel.TabIndex = 6;
            this.mBtnCancel.Text = "Zrušit";
            this.mBtnCancel.UseVisualStyleBackColor = true;
            // 
            // mBtnAddEdit
            // 
            this.mBtnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnAddEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mBtnAddEdit.Location = new System.Drawing.Point(218, 160);
            this.mBtnAddEdit.Name = "mBtnAddEdit";
            this.mBtnAddEdit.Size = new System.Drawing.Size(75, 23);
            this.mBtnAddEdit.TabIndex = 5;
            this.mBtnAddEdit.Text = "Přidat";
            this.mBtnAddEdit.UseVisualStyleBackColor = true;
            this.mBtnAddEdit.Click += new System.EventHandler(this.mBtnAddEdit_Click);
            // 
            // mTbTeamName
            // 
            this.mTbTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbTeamName.Location = new System.Drawing.Point(104, 6);
            this.mTbTeamName.Name = "mTbTeamName";
            this.mTbTeamName.Size = new System.Drawing.Size(228, 20);
            this.mTbTeamName.TabIndex = 0;
            // 
            // mTbTeamMembers
            // 
            this.mTbTeamMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbTeamMembers.Location = new System.Drawing.Point(104, 32);
            this.mTbTeamMembers.Name = "mTbTeamMembers";
            this.mTbTeamMembers.Size = new System.Drawing.Size(228, 20);
            this.mTbTeamMembers.TabIndex = 1;
            // 
            // mTbStart
            // 
            this.mTbStart.Location = new System.Drawing.Point(104, 56);
            this.mTbStart.Name = "mTbStart";
            this.mTbStart.Size = new System.Drawing.Size(68, 20);
            this.mTbStart.TabIndex = 2;
            this.mTbStart.Validating += new System.ComponentModel.CancelEventHandler(this.mTbStart_Validating);
            // 
            // mTbEnd
            // 
            this.mTbEnd.Location = new System.Drawing.Point(104, 82);
            this.mTbEnd.Name = "mTbEnd";
            this.mTbEnd.Size = new System.Drawing.Size(68, 20);
            this.mTbEnd.TabIndex = 3;
            this.mTbEnd.Validating += new System.ComponentModel.CancelEventHandler(this.mTbEnd_Validating);
            // 
            // mNumUDPenaltyMinutes
            // 
            this.mNumUDPenaltyMinutes.Location = new System.Drawing.Point(104, 109);
            this.mNumUDPenaltyMinutes.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.mNumUDPenaltyMinutes.Name = "mNumUDPenaltyMinutes";
            this.mNumUDPenaltyMinutes.Size = new System.Drawing.Size(45, 20);
            this.mNumUDPenaltyMinutes.TabIndex = 4;
            this.mNumUDPenaltyMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // linkLabelSetTimeNow
            // 
            this.linkLabelSetTimeNow.AutoSize = true;
            this.linkLabelSetTimeNow.Location = new System.Drawing.Point(187, 85);
            this.linkLabelSetTimeNow.Name = "linkLabelSetTimeNow";
            this.linkLabelSetTimeNow.Size = new System.Drawing.Size(24, 13);
            this.linkLabelSetTimeNow.TabIndex = 7;
            this.linkLabelSetTimeNow.TabStop = true;
            this.linkLabelSetTimeNow.Text = "teď";
            this.linkLabelSetTimeNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetTimeNow_LinkClicked);
            // 
            // FormNewEditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 216);
            this.Controls.Add(this.linkLabelSetTimeNow);
            this.Controls.Add(this.mNumUDPenaltyMinutes);
            this.Controls.Add(this.mTbEnd);
            this.Controls.Add(this.mTbStart);
            this.Controls.Add(this.mTbTeamMembers);
            this.Controls.Add(this.mTbTeamName);
            this.Controls.Add(this.mBtnAddEdit);
            this.Controls.Add(this.mBtnCancel);
            this.Controls.Add(this.mLblPenaltyMinutes);
            this.Controls.Add(this.mLblEnd);
            this.Controls.Add(this.mLblStart);
            this.Controls.Add(this.mLblTeamMembers);
            this.Controls.Add(this.mLblTeamName);
            this.Name = "FormNewEditTeam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Přidat tým";
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDPenaltyMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLblTeamName;
        private System.Windows.Forms.Label mLblTeamMembers;
        private System.Windows.Forms.Label mLblStart;
        private System.Windows.Forms.Label mLblEnd;
        private System.Windows.Forms.Label mLblPenaltyMinutes;
        private System.Windows.Forms.Button mBtnCancel;
        private System.Windows.Forms.Button mBtnAddEdit;
        private System.Windows.Forms.TextBox mTbTeamName;
        private System.Windows.Forms.TextBox mTbTeamMembers;
        private System.Windows.Forms.TextBox mTbStart;
        private System.Windows.Forms.TextBox mTbEnd;
        private System.Windows.Forms.NumericUpDown mNumUDPenaltyMinutes;
        private System.Windows.Forms.LinkLabel linkLabelSetTimeNow;
    }
}