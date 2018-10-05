namespace BeerRunResultDisplay
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.mBtnLoadResults = new System.Windows.Forms.Button();
            this.mBtnSaveResults = new System.Windows.Forms.Button();
            this.mTBoxFilePathXMLResult = new System.Windows.Forms.TextBox();
            this.mGrpBoxFileOperations = new System.Windows.Forms.GroupBox();
            this.mBtnFileDialogXMLResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mBtnAddNewTeam = new System.Windows.Forms.Button();
            this.mBtnEditShowResults = new System.Windows.Forms.Button();
            this.mSaveFileDialogXMLResult = new System.Windows.Forms.SaveFileDialog();
            this.mBtnDeleteTeam = new System.Windows.Forms.Button();
            this.mTimerSave5mins = new System.Windows.Forms.Timer(this.components);
            this.mGrpBoxFileOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // mBtnLoadResults
            // 
            this.mBtnLoadResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mBtnLoadResults.Enabled = false;
            this.mBtnLoadResults.Location = new System.Drawing.Point(11, 43);
            this.mBtnLoadResults.Name = "mBtnLoadResults";
            this.mBtnLoadResults.Size = new System.Drawing.Size(102, 51);
            this.mBtnLoadResults.TabIndex = 2;
            this.mBtnLoadResults.Text = "Načíst";
            this.mBtnLoadResults.UseVisualStyleBackColor = true;
            this.mBtnLoadResults.Click += new System.EventHandler(this.mBtnLoadResults_Click);
            // 
            // mBtnSaveResults
            // 
            this.mBtnSaveResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mBtnSaveResults.Enabled = false;
            this.mBtnSaveResults.Location = new System.Drawing.Point(119, 43);
            this.mBtnSaveResults.Name = "mBtnSaveResults";
            this.mBtnSaveResults.Size = new System.Drawing.Size(102, 51);
            this.mBtnSaveResults.TabIndex = 3;
            this.mBtnSaveResults.Text = "Uložit";
            this.mBtnSaveResults.UseVisualStyleBackColor = true;
            this.mBtnSaveResults.Click += new System.EventHandler(this.mBtnSaveResults_Click);
            // 
            // mTBoxFilePathXMLResult
            // 
            this.mTBoxFilePathXMLResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTBoxFilePathXMLResult.Location = new System.Drawing.Point(101, 17);
            this.mTBoxFilePathXMLResult.Name = "mTBoxFilePathXMLResult";
            this.mTBoxFilePathXMLResult.Size = new System.Drawing.Size(476, 20);
            this.mTBoxFilePathXMLResult.TabIndex = 1;
            this.mTBoxFilePathXMLResult.TextChanged += new System.EventHandler(this.mTBoxFilePathXMLResult_TextChanged);
            // 
            // mGrpBoxFileOperations
            // 
            this.mGrpBoxFileOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnFileDialogXMLResult);
            this.mGrpBoxFileOperations.Controls.Add(this.label1);
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnDeleteTeam);
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnAddNewTeam);
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnEditShowResults);
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnSaveResults);
            this.mGrpBoxFileOperations.Controls.Add(this.mTBoxFilePathXMLResult);
            this.mGrpBoxFileOperations.Controls.Add(this.mBtnLoadResults);
            this.mGrpBoxFileOperations.Location = new System.Drawing.Point(12, 12);
            this.mGrpBoxFileOperations.Name = "mGrpBoxFileOperations";
            this.mGrpBoxFileOperations.Size = new System.Drawing.Size(633, 107);
            this.mGrpBoxFileOperations.TabIndex = 3;
            this.mGrpBoxFileOperations.TabStop = false;
            this.mGrpBoxFileOperations.Text = "Soubor";
            // 
            // mBtnFileDialogXMLResult
            // 
            this.mBtnFileDialogXMLResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnFileDialogXMLResult.Location = new System.Drawing.Point(579, 17);
            this.mBtnFileDialogXMLResult.Name = "mBtnFileDialogXMLResult";
            this.mBtnFileDialogXMLResult.Size = new System.Drawing.Size(52, 20);
            this.mBtnFileDialogXMLResult.TabIndex = 0;
            this.mBtnFileDialogXMLResult.Text = "...";
            this.mBtnFileDialogXMLResult.UseVisualStyleBackColor = true;
            this.mBtnFileDialogXMLResult.Click += new System.EventHandler(this.mBtnFileDialogXMLResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cesta k souboru:";
            // 
            // mBtnAddNewTeam
            // 
            this.mBtnAddNewTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnAddNewTeam.Location = new System.Drawing.Point(417, 43);
            this.mBtnAddNewTeam.Name = "mBtnAddNewTeam";
            this.mBtnAddNewTeam.Size = new System.Drawing.Size(102, 51);
            this.mBtnAddNewTeam.TabIndex = 4;
            this.mBtnAddNewTeam.Text = "Přidat tým";
            this.mBtnAddNewTeam.UseVisualStyleBackColor = true;
            this.mBtnAddNewTeam.Click += new System.EventHandler(this.mBtnAddNewTeam_Click);
            // 
            // mBtnEditShowResults
            // 
            this.mBtnEditShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnEditShowResults.Location = new System.Drawing.Point(525, 43);
            this.mBtnEditShowResults.Name = "mBtnEditShowResults";
            this.mBtnEditShowResults.Size = new System.Drawing.Size(102, 51);
            this.mBtnEditShowResults.TabIndex = 5;
            this.mBtnEditShowResults.Text = "Tabulka výsledků";
            this.mBtnEditShowResults.UseVisualStyleBackColor = true;
            this.mBtnEditShowResults.Click += new System.EventHandler(this.mBtnEditShowResults_Click);
            // 
            // mSaveFileDialogXMLResult
            // 
            this.mSaveFileDialogXMLResult.FileName = "result.xml";
            this.mSaveFileDialogXMLResult.Filter = "XML file|*.xml|All Files|*.*";
            this.mSaveFileDialogXMLResult.OverwritePrompt = false;
            this.mSaveFileDialogXMLResult.Title = "Vybrat soubor pro čtení/zápis výsledků";
            // 
            // mBtnDeleteTeam
            // 
            this.mBtnDeleteTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnDeleteTeam.Location = new System.Drawing.Point(309, 43);
            this.mBtnDeleteTeam.Name = "mBtnDeleteTeam";
            this.mBtnDeleteTeam.Size = new System.Drawing.Size(102, 51);
            this.mBtnDeleteTeam.TabIndex = 4;
            this.mBtnDeleteTeam.Text = "Odebrat tým";
            this.mBtnDeleteTeam.UseVisualStyleBackColor = true;
            this.mBtnDeleteTeam.Click += new System.EventHandler(this.mBtnDeleteTeam_Click);
            // 
            // mTimerSave5mins
            // 
            this.mTimerSave5mins.Enabled = true;
            this.mTimerSave5mins.Interval = 300000;
            this.mTimerSave5mins.Tick += new System.EventHandler(this.mTimerSave5mins_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 132);
            this.Controls.Add(this.mGrpBoxFileOperations);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pivní běh - výsledky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.mGrpBoxFileOperations.ResumeLayout(false);
            this.mGrpBoxFileOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mBtnLoadResults;
        private System.Windows.Forms.Button mBtnSaveResults;
        private System.Windows.Forms.TextBox mTBoxFilePathXMLResult;
        private System.Windows.Forms.GroupBox mGrpBoxFileOperations;
        private System.Windows.Forms.Button mBtnFileDialogXMLResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog mSaveFileDialogXMLResult;
        private System.Windows.Forms.Button mBtnEditShowResults;
        private System.Windows.Forms.Button mBtnAddNewTeam;
        private System.Windows.Forms.Button mBtnDeleteTeam;
        private System.Windows.Forms.Timer mTimerSave5mins;
    }
}

