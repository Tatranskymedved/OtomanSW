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
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDTo)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnCreate
            // 
            this.mBtnCreate.Location = new System.Drawing.Point(319, 126);
            this.mBtnCreate.Name = "mBtnCreate";
            this.mBtnCreate.Size = new System.Drawing.Size(126, 62);
            this.mBtnCreate.TabIndex = 0;
            this.mBtnCreate.Text = "Create";
            this.mBtnCreate.UseVisualStyleBackColor = true;
            this.mBtnCreate.Click += new System.EventHandler(this.mBtnCreate_Click);
            // 
            // mNumUDFrom
            // 
            this.mNumUDFrom.Location = new System.Drawing.Point(179, 135);
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
            this.mNumUDTo.Location = new System.Drawing.Point(179, 161);
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
            this.label1.Location = new System.Drawing.Point(141, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konec:";
            // 
            // mProgressBarCreated
            // 
            this.mProgressBarCreated.Location = new System.Drawing.Point(12, 226);
            this.mProgressBarCreated.Name = "mProgressBarCreated";
            this.mProgressBarCreated.Size = new System.Drawing.Size(433, 23);
            this.mProgressBarCreated.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.mProgressBarCreated);
            this.Controls.Add(this.label2);
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
    }
}

