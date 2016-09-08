namespace TicketMaker
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
            this.mBtnCreate = new System.Windows.Forms.Button();
            this.mNumUDFrom = new System.Windows.Forms.NumericUpDown();
            this.mNumUDTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mProgressBarCreated = new System.Windows.Forms.ProgressBar();
            this.mLblInputPath = new System.Windows.Forms.Label();
            this.mTbInputPath = new System.Windows.Forms.TextBox();
            this.mBtnInputPath = new System.Windows.Forms.Button();
            this.mLblOutputPath = new System.Windows.Forms.Label();
            this.mTbOutputPath = new System.Windows.Forms.TextBox();
            this.mBtnOutputPath = new System.Windows.Forms.Button();
            this.mOpenFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.mSaveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDTo)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnCreate
            // 
            this.mBtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnCreate.Enabled = false;
            this.mBtnCreate.Location = new System.Drawing.Point(319, 158);
            this.mBtnCreate.Name = "mBtnCreate";
            this.mBtnCreate.Size = new System.Drawing.Size(126, 62);
            this.mBtnCreate.TabIndex = 0;
            this.mBtnCreate.Text = "Create";
            this.mBtnCreate.UseVisualStyleBackColor = true;
            this.mBtnCreate.Click += new System.EventHandler(this.mBtnCreate_Click);
            // 
            // mNumUDFrom
            // 
            this.mNumUDFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDFrom.Location = new System.Drawing.Point(179, 158);
            this.mNumUDFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDFrom.Name = "mNumUDFrom";
            this.mNumUDFrom.Size = new System.Drawing.Size(120, 20);
            this.mNumUDFrom.TabIndex = 1;
            this.mNumUDFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDFrom.ValueChanged += new System.EventHandler(this.mNumUDFrom_ValueChanged);
            // 
            // mNumUDTo
            // 
            this.mNumUDTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDTo.Location = new System.Drawing.Point(179, 200);
            this.mNumUDTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDTo.Name = "mNumUDTo";
            this.mNumUDTo.Size = new System.Drawing.Size(120, 20);
            this.mNumUDTo.TabIndex = 2;
            this.mNumUDTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDTo.ValueChanged += new System.EventHandler(this.mNumUDTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konec:";
            // 
            // mProgressBarCreated
            // 
            this.mProgressBarCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mProgressBarCreated.Location = new System.Drawing.Point(12, 226);
            this.mProgressBarCreated.Name = "mProgressBarCreated";
            this.mProgressBarCreated.Size = new System.Drawing.Size(433, 23);
            this.mProgressBarCreated.TabIndex = 4;
            // 
            // mLblInputPath
            // 
            this.mLblInputPath.AutoSize = true;
            this.mLblInputPath.Location = new System.Drawing.Point(12, 17);
            this.mLblInputPath.Name = "mLblInputPath";
            this.mLblInputPath.Size = new System.Drawing.Size(34, 13);
            this.mLblInputPath.TabIndex = 3;
            this.mLblInputPath.Text = "Zdroj:";
            // 
            // mTbInputPath
            // 
            this.mTbInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbInputPath.Location = new System.Drawing.Point(52, 14);
            this.mTbInputPath.Name = "mTbInputPath";
            this.mTbInputPath.Size = new System.Drawing.Size(312, 20);
            this.mTbInputPath.TabIndex = 5;
            this.mTbInputPath.TextChanged += new System.EventHandler(this.mTbInputOutput_TextChanged);
            // 
            // mBtnInputPath
            // 
            this.mBtnInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnInputPath.Location = new System.Drawing.Point(370, 12);
            this.mBtnInputPath.Name = "mBtnInputPath";
            this.mBtnInputPath.Size = new System.Drawing.Size(75, 23);
            this.mBtnInputPath.TabIndex = 6;
            this.mBtnInputPath.Text = "...";
            this.mBtnInputPath.UseVisualStyleBackColor = true;
            this.mBtnInputPath.Click += new System.EventHandler(this.mBtnInputPath_Click);
            // 
            // mLblOutputPath
            // 
            this.mLblOutputPath.AutoSize = true;
            this.mLblOutputPath.Location = new System.Drawing.Point(23, 43);
            this.mLblOutputPath.Name = "mLblOutputPath";
            this.mLblOutputPath.Size = new System.Drawing.Size(23, 13);
            this.mLblOutputPath.TabIndex = 3;
            this.mLblOutputPath.Text = "Cíl:";
            // 
            // mTbOutputPath
            // 
            this.mTbOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbOutputPath.Location = new System.Drawing.Point(52, 40);
            this.mTbOutputPath.Name = "mTbOutputPath";
            this.mTbOutputPath.Size = new System.Drawing.Size(312, 20);
            this.mTbOutputPath.TabIndex = 5;
            this.mTbOutputPath.TextChanged += new System.EventHandler(this.mTbInputOutput_TextChanged);
            // 
            // mBtnOutputPath
            // 
            this.mBtnOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnOutputPath.Location = new System.Drawing.Point(370, 38);
            this.mBtnOutputPath.Name = "mBtnOutputPath";
            this.mBtnOutputPath.Size = new System.Drawing.Size(75, 23);
            this.mBtnOutputPath.TabIndex = 6;
            this.mBtnOutputPath.Text = "...";
            this.mBtnOutputPath.UseVisualStyleBackColor = true;
            this.mBtnOutputPath.Click += new System.EventHandler(this.mBtnOutputPath_Click);
            // 
            // mOpenFileDialogInput
            // 
            this.mOpenFileDialogInput.FileName = "vstupenka.jpg";
            this.mOpenFileDialogInput.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files" +
    "|*.*";
            this.mOpenFileDialogInput.FilterIndex = 2;
            // 
            // mSaveFileDialogOutput
            // 
            this.mSaveFileDialogOutput.FileName = "Output.pdf";
            this.mSaveFileDialogOutput.Filter = "PDF file |*.pdf|All files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.mBtnOutputPath);
            this.Controls.Add(this.mBtnInputPath);
            this.Controls.Add(this.mTbOutputPath);
            this.Controls.Add(this.mTbInputPath);
            this.Controls.Add(this.mProgressBarCreated);
            this.Controls.Add(this.mLblOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mLblInputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mNumUDTo);
            this.Controls.Add(this.mNumUDFrom);
            this.Controls.Add(this.mBtnCreate);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "TicketMaker - Turbo©";
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mBtnCreate;
        private System.Windows.Forms.NumericUpDown mNumUDFrom;
        private System.Windows.Forms.NumericUpDown mNumUDTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar mProgressBarCreated;
        private System.Windows.Forms.TextBox mTbInputPath;
        private System.Windows.Forms.Label mLblInputPath;
        private System.Windows.Forms.Button mBtnInputPath;
        private System.Windows.Forms.Label mLblOutputPath;
        private System.Windows.Forms.TextBox mTbOutputPath;
        private System.Windows.Forms.Button mBtnOutputPath;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialogInput;
        private System.Windows.Forms.SaveFileDialog mSaveFileDialogOutput;
    }
}

