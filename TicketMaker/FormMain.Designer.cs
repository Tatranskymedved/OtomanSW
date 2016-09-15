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
            this.mBtnEnterTicketCreate = new System.Windows.Forms.Button();
            this.mNumUDEnterTicketFrom = new System.Windows.Forms.NumericUpDown();
            this.mNumUDEnterTicketTo = new System.Windows.Forms.NumericUpDown();
            this.mLblEnterTicketFrom = new System.Windows.Forms.Label();
            this.mLblEnterTicketTo = new System.Windows.Forms.Label();
            this.mProgressBarEnterTicketCreated = new System.Windows.Forms.ProgressBar();
            this.mOpenFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.mSaveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.mNumUDEnterTicketXMove = new System.Windows.Forms.NumericUpDown();
            this.mLblEnterTicketXMove = new System.Windows.Forms.Label();
            this.mLblEnterTicketYMove = new System.Windows.Forms.Label();
            this.mNumUDEnterTicketYMove = new System.Windows.Forms.NumericUpDown();
            this.mGrpBoxEnterTicketNumbering = new System.Windows.Forms.GroupBox();
            this.mTabControlTicketType = new System.Windows.Forms.TabControl();
            this.mTabPageEatDrinkTicket = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mNumUDEatDrinkTicketXMove = new System.Windows.Forms.NumericUpDown();
            this.mNumUDEatDrinkTicketFrom = new System.Windows.Forms.NumericUpDown();
            this.mNumUDEatDrinkTicketYMove = new System.Windows.Forms.NumericUpDown();
            this.mNumUDEatDrinkTicketTo = new System.Windows.Forms.NumericUpDown();
            this.mLblEatDrinkTicketFrom = new System.Windows.Forms.Label();
            this.mLblEatDrinkTicketXMove = new System.Windows.Forms.Label();
            this.mLblEatDrinkTicketYMove = new System.Windows.Forms.Label();
            this.mLblEatDrinkTicketTo = new System.Windows.Forms.Label();
            this.mBtnEatDrinkTicketCreate = new System.Windows.Forms.Button();
            this.mProgressBarEatDrinkTicketCreated = new System.Windows.Forms.ProgressBar();
            this.mTabPageEntryTicket = new System.Windows.Forms.TabPage();
            this.mGrpBoxEnterTicketPage = new System.Windows.Forms.GroupBox();
            this.mCheckLandscape = new System.Windows.Forms.CheckBox();
            this.mBtnOutputPath = new System.Windows.Forms.Button();
            this.mLblInputPath = new System.Windows.Forms.Label();
            this.mBtnInputPath = new System.Windows.Forms.Button();
            this.mLblOutputPath = new System.Windows.Forms.Label();
            this.mTbOutputPath = new System.Windows.Forms.TextBox();
            this.mTbInputPath = new System.Windows.Forms.TextBox();
            this.mNumUDEatDrinkFontSize = new System.Windows.Forms.NumericUpDown();
            this.mLblEatDrinkTicketFontSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketXMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketYMove)).BeginInit();
            this.mGrpBoxEnterTicketNumbering.SuspendLayout();
            this.mTabControlTicketType.SuspendLayout();
            this.mTabPageEatDrinkTicket.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketXMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketYMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketTo)).BeginInit();
            this.mTabPageEntryTicket.SuspendLayout();
            this.mGrpBoxEnterTicketPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnEnterTicketCreate
            // 
            this.mBtnEnterTicketCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnEnterTicketCreate.Enabled = false;
            this.mBtnEnterTicketCreate.Location = new System.Drawing.Point(414, 92);
            this.mBtnEnterTicketCreate.Name = "mBtnEnterTicketCreate";
            this.mBtnEnterTicketCreate.Size = new System.Drawing.Size(126, 46);
            this.mBtnEnterTicketCreate.TabIndex = 0;
            this.mBtnEnterTicketCreate.Text = "Vytvořit vstupenku";
            this.mBtnEnterTicketCreate.UseVisualStyleBackColor = true;
            this.mBtnEnterTicketCreate.Click += new System.EventHandler(this.mBtnEnterTicketCreate_Click);
            // 
            // mNumUDEnterTicketFrom
            // 
            this.mNumUDEnterTicketFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEnterTicketFrom.Location = new System.Drawing.Point(63, 71);
            this.mNumUDEnterTicketFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDEnterTicketFrom.Name = "mNumUDEnterTicketFrom";
            this.mNumUDEnterTicketFrom.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEnterTicketFrom.TabIndex = 1;
            this.mNumUDEnterTicketFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDEnterTicketFrom.ValueChanged += new System.EventHandler(this.mNumUDEnterTicketFrom_ValueChanged);
            // 
            // mNumUDEnterTicketTo
            // 
            this.mNumUDEnterTicketTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEnterTicketTo.Location = new System.Drawing.Point(63, 97);
            this.mNumUDEnterTicketTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDEnterTicketTo.Name = "mNumUDEnterTicketTo";
            this.mNumUDEnterTicketTo.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEnterTicketTo.TabIndex = 2;
            this.mNumUDEnterTicketTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDEnterTicketTo.ValueChanged += new System.EventHandler(this.mNumUDEnterTicketTo_ValueChanged);
            // 
            // mLblEnterTicketFrom
            // 
            this.mLblEnterTicketFrom.AutoSize = true;
            this.mLblEnterTicketFrom.Location = new System.Drawing.Point(25, 73);
            this.mLblEnterTicketFrom.Name = "mLblEnterTicketFrom";
            this.mLblEnterTicketFrom.Size = new System.Drawing.Size(32, 13);
            this.mLblEnterTicketFrom.TabIndex = 3;
            this.mLblEnterTicketFrom.Text = "Start:";
            // 
            // mLblEnterTicketTo
            // 
            this.mLblEnterTicketTo.AutoSize = true;
            this.mLblEnterTicketTo.Location = new System.Drawing.Point(16, 99);
            this.mLblEnterTicketTo.Name = "mLblEnterTicketTo";
            this.mLblEnterTicketTo.Size = new System.Drawing.Size(41, 13);
            this.mLblEnterTicketTo.TabIndex = 3;
            this.mLblEnterTicketTo.Text = "Konec:";
            // 
            // mProgressBarEnterTicketCreated
            // 
            this.mProgressBarEnterTicketCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mProgressBarEnterTicketCreated.Location = new System.Drawing.Point(7, 144);
            this.mProgressBarEnterTicketCreated.Name = "mProgressBarEnterTicketCreated";
            this.mProgressBarEnterTicketCreated.Size = new System.Drawing.Size(533, 23);
            this.mProgressBarEnterTicketCreated.TabIndex = 4;
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
            // mNumUDEnterTicketXMove
            // 
            this.mNumUDEnterTicketXMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEnterTicketXMove.Location = new System.Drawing.Point(63, 20);
            this.mNumUDEnterTicketXMove.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mNumUDEnterTicketXMove.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.mNumUDEnterTicketXMove.Name = "mNumUDEnterTicketXMove";
            this.mNumUDEnterTicketXMove.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEnterTicketXMove.TabIndex = 7;
            this.mNumUDEnterTicketXMove.Value = new decimal(new int[] {
            1502,
            0,
            0,
            0});
            // 
            // mLblEnterTicketXMove
            // 
            this.mLblEnterTicketXMove.AutoSize = true;
            this.mLblEnterTicketXMove.Location = new System.Drawing.Point(8, 22);
            this.mLblEnterTicketXMove.Name = "mLblEnterTicketXMove";
            this.mLblEnterTicketXMove.Size = new System.Drawing.Size(49, 13);
            this.mLblEnterTicketXMove.TabIndex = 3;
            this.mLblEnterTicketXMove.Text = "X posun:";
            // 
            // mLblEnterTicketYMove
            // 
            this.mLblEnterTicketYMove.AutoSize = true;
            this.mLblEnterTicketYMove.Location = new System.Drawing.Point(8, 47);
            this.mLblEnterTicketYMove.Name = "mLblEnterTicketYMove";
            this.mLblEnterTicketYMove.Size = new System.Drawing.Size(49, 13);
            this.mLblEnterTicketYMove.TabIndex = 3;
            this.mLblEnterTicketYMove.Text = "Y posun:";
            // 
            // mNumUDEnterTicketYMove
            // 
            this.mNumUDEnterTicketYMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEnterTicketYMove.Location = new System.Drawing.Point(63, 45);
            this.mNumUDEnterTicketYMove.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mNumUDEnterTicketYMove.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.mNumUDEnterTicketYMove.Name = "mNumUDEnterTicketYMove";
            this.mNumUDEnterTicketYMove.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEnterTicketYMove.TabIndex = 7;
            this.mNumUDEnterTicketYMove.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // mGrpBoxEnterTicketNumbering
            // 
            this.mGrpBoxEnterTicketNumbering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mNumUDEnterTicketXMove);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mNumUDEnterTicketFrom);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mNumUDEnterTicketYMove);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mNumUDEnterTicketTo);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mLblEnterTicketFrom);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mLblEnterTicketXMove);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mLblEnterTicketYMove);
            this.mGrpBoxEnterTicketNumbering.Controls.Add(this.mLblEnterTicketTo);
            this.mGrpBoxEnterTicketNumbering.Location = new System.Drawing.Point(7, 8);
            this.mGrpBoxEnterTicketNumbering.Name = "mGrpBoxEnterTicketNumbering";
            this.mGrpBoxEnterTicketNumbering.Size = new System.Drawing.Size(237, 125);
            this.mGrpBoxEnterTicketNumbering.TabIndex = 9;
            this.mGrpBoxEnterTicketNumbering.TabStop = false;
            this.mGrpBoxEnterTicketNumbering.Text = "Číslování";
            // 
            // mTabControlTicketType
            // 
            this.mTabControlTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTabControlTicketType.Controls.Add(this.mTabPageEatDrinkTicket);
            this.mTabControlTicketType.Controls.Add(this.mTabPageEntryTicket);
            this.mTabControlTicketType.Location = new System.Drawing.Point(1, 59);
            this.mTabControlTicketType.Name = "mTabControlTicketType";
            this.mTabControlTicketType.SelectedIndex = 0;
            this.mTabControlTicketType.Size = new System.Drawing.Size(557, 201);
            this.mTabControlTicketType.TabIndex = 11;
            // 
            // mTabPageEatDrinkTicket
            // 
            this.mTabPageEatDrinkTicket.Controls.Add(this.mNumUDEatDrinkFontSize);
            this.mTabPageEatDrinkTicket.Controls.Add(this.mLblEatDrinkTicketFontSize);
            this.mTabPageEatDrinkTicket.Controls.Add(this.groupBox2);
            this.mTabPageEatDrinkTicket.Controls.Add(this.mBtnEatDrinkTicketCreate);
            this.mTabPageEatDrinkTicket.Controls.Add(this.mProgressBarEatDrinkTicketCreated);
            this.mTabPageEatDrinkTicket.Location = new System.Drawing.Point(4, 22);
            this.mTabPageEatDrinkTicket.Name = "mTabPageEatDrinkTicket";
            this.mTabPageEatDrinkTicket.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageEatDrinkTicket.Size = new System.Drawing.Size(549, 175);
            this.mTabPageEatDrinkTicket.TabIndex = 1;
            this.mTabPageEatDrinkTicket.Text = "Chlastenky/Stravenky";
            this.mTabPageEatDrinkTicket.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.mNumUDEatDrinkTicketXMove);
            this.groupBox2.Controls.Add(this.mNumUDEatDrinkTicketFrom);
            this.groupBox2.Controls.Add(this.mNumUDEatDrinkTicketYMove);
            this.groupBox2.Controls.Add(this.mNumUDEatDrinkTicketTo);
            this.groupBox2.Controls.Add(this.mLblEatDrinkTicketFrom);
            this.groupBox2.Controls.Add(this.mLblEatDrinkTicketXMove);
            this.groupBox2.Controls.Add(this.mLblEatDrinkTicketYMove);
            this.groupBox2.Controls.Add(this.mLblEatDrinkTicketTo);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Číslování";
            // 
            // mNumUDEatDrinkTicketXMove
            // 
            this.mNumUDEatDrinkTicketXMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEatDrinkTicketXMove.Location = new System.Drawing.Point(63, 20);
            this.mNumUDEatDrinkTicketXMove.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketXMove.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.mNumUDEatDrinkTicketXMove.Name = "mNumUDEatDrinkTicketXMove";
            this.mNumUDEatDrinkTicketXMove.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEatDrinkTicketXMove.TabIndex = 7;
            this.mNumUDEatDrinkTicketXMove.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // mNumUDEatDrinkTicketFrom
            // 
            this.mNumUDEatDrinkTicketFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEatDrinkTicketFrom.Location = new System.Drawing.Point(63, 71);
            this.mNumUDEatDrinkTicketFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketFrom.Name = "mNumUDEatDrinkTicketFrom";
            this.mNumUDEatDrinkTicketFrom.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEatDrinkTicketFrom.TabIndex = 1;
            this.mNumUDEatDrinkTicketFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketFrom.ValueChanged += new System.EventHandler(this.mNumUDEatDrinkTicketFrom_ValueChanged);
            // 
            // mNumUDEatDrinkTicketYMove
            // 
            this.mNumUDEatDrinkTicketYMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEatDrinkTicketYMove.Location = new System.Drawing.Point(63, 45);
            this.mNumUDEatDrinkTicketYMove.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketYMove.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.mNumUDEatDrinkTicketYMove.Name = "mNumUDEatDrinkTicketYMove";
            this.mNumUDEatDrinkTicketYMove.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEatDrinkTicketYMove.TabIndex = 7;
            this.mNumUDEatDrinkTicketYMove.Value = new decimal(new int[] {
            305,
            0,
            0,
            0});
            // 
            // mNumUDEatDrinkTicketTo
            // 
            this.mNumUDEatDrinkTicketTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEatDrinkTicketTo.Location = new System.Drawing.Point(63, 97);
            this.mNumUDEatDrinkTicketTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketTo.Name = "mNumUDEatDrinkTicketTo";
            this.mNumUDEatDrinkTicketTo.Size = new System.Drawing.Size(157, 20);
            this.mNumUDEatDrinkTicketTo.TabIndex = 2;
            this.mNumUDEatDrinkTicketTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDEatDrinkTicketTo.ValueChanged += new System.EventHandler(this.mNumUDEatDrinkTicketTo_ValueChanged);
            // 
            // mLblEatDrinkTicketFrom
            // 
            this.mLblEatDrinkTicketFrom.AutoSize = true;
            this.mLblEatDrinkTicketFrom.Location = new System.Drawing.Point(25, 73);
            this.mLblEatDrinkTicketFrom.Name = "mLblEatDrinkTicketFrom";
            this.mLblEatDrinkTicketFrom.Size = new System.Drawing.Size(32, 13);
            this.mLblEatDrinkTicketFrom.TabIndex = 3;
            this.mLblEatDrinkTicketFrom.Text = "Start:";
            // 
            // mLblEatDrinkTicketXMove
            // 
            this.mLblEatDrinkTicketXMove.AutoSize = true;
            this.mLblEatDrinkTicketXMove.Location = new System.Drawing.Point(8, 22);
            this.mLblEatDrinkTicketXMove.Name = "mLblEatDrinkTicketXMove";
            this.mLblEatDrinkTicketXMove.Size = new System.Drawing.Size(49, 13);
            this.mLblEatDrinkTicketXMove.TabIndex = 3;
            this.mLblEatDrinkTicketXMove.Text = "X posun:";
            // 
            // mLblEatDrinkTicketYMove
            // 
            this.mLblEatDrinkTicketYMove.AutoSize = true;
            this.mLblEatDrinkTicketYMove.Location = new System.Drawing.Point(8, 47);
            this.mLblEatDrinkTicketYMove.Name = "mLblEatDrinkTicketYMove";
            this.mLblEatDrinkTicketYMove.Size = new System.Drawing.Size(49, 13);
            this.mLblEatDrinkTicketYMove.TabIndex = 3;
            this.mLblEatDrinkTicketYMove.Text = "Y posun:";
            // 
            // mLblEatDrinkTicketTo
            // 
            this.mLblEatDrinkTicketTo.AutoSize = true;
            this.mLblEatDrinkTicketTo.Location = new System.Drawing.Point(16, 99);
            this.mLblEatDrinkTicketTo.Name = "mLblEatDrinkTicketTo";
            this.mLblEatDrinkTicketTo.Size = new System.Drawing.Size(41, 13);
            this.mLblEatDrinkTicketTo.TabIndex = 3;
            this.mLblEatDrinkTicketTo.Text = "Konec:";
            // 
            // mBtnEatDrinkTicketCreate
            // 
            this.mBtnEatDrinkTicketCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnEatDrinkTicketCreate.Enabled = false;
            this.mBtnEatDrinkTicketCreate.Location = new System.Drawing.Point(414, 92);
            this.mBtnEatDrinkTicketCreate.Name = "mBtnEatDrinkTicketCreate";
            this.mBtnEatDrinkTicketCreate.Size = new System.Drawing.Size(126, 46);
            this.mBtnEatDrinkTicketCreate.TabIndex = 11;
            this.mBtnEatDrinkTicketCreate.Text = "Vytvořit chlastenku/stravenku";
            this.mBtnEatDrinkTicketCreate.UseVisualStyleBackColor = true;
            this.mBtnEatDrinkTicketCreate.Click += new System.EventHandler(this.mBtnEatDrinkTicketCreate_Click);
            // 
            // mProgressBarEatDrinkTicketCreated
            // 
            this.mProgressBarEatDrinkTicketCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mProgressBarEatDrinkTicketCreated.Location = new System.Drawing.Point(7, 144);
            this.mProgressBarEatDrinkTicketCreated.Name = "mProgressBarEatDrinkTicketCreated";
            this.mProgressBarEatDrinkTicketCreated.Size = new System.Drawing.Size(533, 23);
            this.mProgressBarEatDrinkTicketCreated.TabIndex = 14;
            // 
            // mTabPageEntryTicket
            // 
            this.mTabPageEntryTicket.Controls.Add(this.mGrpBoxEnterTicketPage);
            this.mTabPageEntryTicket.Controls.Add(this.mGrpBoxEnterTicketNumbering);
            this.mTabPageEntryTicket.Controls.Add(this.mBtnEnterTicketCreate);
            this.mTabPageEntryTicket.Controls.Add(this.mProgressBarEnterTicketCreated);
            this.mTabPageEntryTicket.Location = new System.Drawing.Point(4, 22);
            this.mTabPageEntryTicket.Name = "mTabPageEntryTicket";
            this.mTabPageEntryTicket.Padding = new System.Windows.Forms.Padding(3);
            this.mTabPageEntryTicket.Size = new System.Drawing.Size(549, 175);
            this.mTabPageEntryTicket.TabIndex = 0;
            this.mTabPageEntryTicket.Text = "Vstupenky";
            this.mTabPageEntryTicket.UseVisualStyleBackColor = true;
            // 
            // mGrpBoxEnterTicketPage
            // 
            this.mGrpBoxEnterTicketPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mGrpBoxEnterTicketPage.Controls.Add(this.mCheckLandscape);
            this.mGrpBoxEnterTicketPage.Location = new System.Drawing.Point(250, 8);
            this.mGrpBoxEnterTicketPage.Name = "mGrpBoxEnterTicketPage";
            this.mGrpBoxEnterTicketPage.Size = new System.Drawing.Size(85, 51);
            this.mGrpBoxEnterTicketPage.TabIndex = 10;
            this.mGrpBoxEnterTicketPage.TabStop = false;
            this.mGrpBoxEnterTicketPage.Text = "Stránka";
            // 
            // mCheckLandscape
            // 
            this.mCheckLandscape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mCheckLandscape.AutoSize = true;
            this.mCheckLandscape.Checked = true;
            this.mCheckLandscape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mCheckLandscape.Location = new System.Drawing.Point(11, 21);
            this.mCheckLandscape.Name = "mCheckLandscape";
            this.mCheckLandscape.Size = new System.Drawing.Size(68, 17);
            this.mCheckLandscape.TabIndex = 8;
            this.mCheckLandscape.Text = "Na šířku";
            this.mCheckLandscape.UseVisualStyleBackColor = true;
            // 
            // mBtnOutputPath
            // 
            this.mBtnOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnOutputPath.Location = new System.Drawing.Point(470, 29);
            this.mBtnOutputPath.Name = "mBtnOutputPath";
            this.mBtnOutputPath.Size = new System.Drawing.Size(75, 23);
            this.mBtnOutputPath.TabIndex = 16;
            this.mBtnOutputPath.Text = "...";
            this.mBtnOutputPath.UseVisualStyleBackColor = true;
            this.mBtnOutputPath.Click += new System.EventHandler(this.mBtnOutputPath_Click);
            // 
            // mLblInputPath
            // 
            this.mLblInputPath.AutoSize = true;
            this.mLblInputPath.Location = new System.Drawing.Point(12, 8);
            this.mLblInputPath.Name = "mLblInputPath";
            this.mLblInputPath.Size = new System.Drawing.Size(34, 13);
            this.mLblInputPath.TabIndex = 12;
            this.mLblInputPath.Text = "Zdroj:";
            // 
            // mBtnInputPath
            // 
            this.mBtnInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnInputPath.Location = new System.Drawing.Point(470, 3);
            this.mBtnInputPath.Name = "mBtnInputPath";
            this.mBtnInputPath.Size = new System.Drawing.Size(75, 23);
            this.mBtnInputPath.TabIndex = 17;
            this.mBtnInputPath.Text = "...";
            this.mBtnInputPath.UseVisualStyleBackColor = true;
            this.mBtnInputPath.Click += new System.EventHandler(this.mBtnInputPath_Click);
            // 
            // mLblOutputPath
            // 
            this.mLblOutputPath.AutoSize = true;
            this.mLblOutputPath.Location = new System.Drawing.Point(23, 34);
            this.mLblOutputPath.Name = "mLblOutputPath";
            this.mLblOutputPath.Size = new System.Drawing.Size(23, 13);
            this.mLblOutputPath.TabIndex = 13;
            this.mLblOutputPath.Text = "Cíl:";
            // 
            // mTbOutputPath
            // 
            this.mTbOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbOutputPath.Location = new System.Drawing.Point(52, 31);
            this.mTbOutputPath.Name = "mTbOutputPath";
            this.mTbOutputPath.Size = new System.Drawing.Size(412, 20);
            this.mTbOutputPath.TabIndex = 14;
            this.mTbOutputPath.TextChanged += new System.EventHandler(this.mTbInputOutput_TextChanged);
            // 
            // mTbInputPath
            // 
            this.mTbInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbInputPath.Location = new System.Drawing.Point(52, 5);
            this.mTbInputPath.Name = "mTbInputPath";
            this.mTbInputPath.Size = new System.Drawing.Size(412, 20);
            this.mTbInputPath.TabIndex = 15;
            this.mTbInputPath.TextChanged += new System.EventHandler(this.mTbInputOutput_TextChanged);
            // 
            // mNumUDEatDrinkFontSize
            // 
            this.mNumUDEatDrinkFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mNumUDEatDrinkFontSize.Location = new System.Drawing.Point(344, 28);
            this.mNumUDEatDrinkFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumUDEatDrinkFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumUDEatDrinkFontSize.Name = "mNumUDEatDrinkFontSize";
            this.mNumUDEatDrinkFontSize.Size = new System.Drawing.Size(83, 20);
            this.mNumUDEatDrinkFontSize.TabIndex = 21;
            this.mNumUDEatDrinkFontSize.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // mLblEatDrinkTicketFontSize
            // 
            this.mLblEatDrinkTicketFontSize.AutoSize = true;
            this.mLblEatDrinkTicketFontSize.Location = new System.Drawing.Point(259, 30);
            this.mLblEatDrinkTicketFontSize.Name = "mLblEatDrinkTicketFontSize";
            this.mLblEatDrinkTicketFontSize.Size = new System.Drawing.Size(79, 13);
            this.mLblEatDrinkTicketFontSize.TabIndex = 20;
            this.mLblEatDrinkTicketFontSize.Text = "Velikost písma:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 258);
            this.Controls.Add(this.mBtnOutputPath);
            this.Controls.Add(this.mLblInputPath);
            this.Controls.Add(this.mBtnInputPath);
            this.Controls.Add(this.mLblOutputPath);
            this.Controls.Add(this.mTbOutputPath);
            this.Controls.Add(this.mTbInputPath);
            this.Controls.Add(this.mTabControlTicketType);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "TicketMaker - Turbo©";
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketXMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEnterTicketYMove)).EndInit();
            this.mGrpBoxEnterTicketNumbering.ResumeLayout(false);
            this.mGrpBoxEnterTicketNumbering.PerformLayout();
            this.mTabControlTicketType.ResumeLayout(false);
            this.mTabPageEatDrinkTicket.ResumeLayout(false);
            this.mTabPageEatDrinkTicket.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketXMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketYMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkTicketTo)).EndInit();
            this.mTabPageEntryTicket.ResumeLayout(false);
            this.mGrpBoxEnterTicketPage.ResumeLayout(false);
            this.mGrpBoxEnterTicketPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumUDEatDrinkFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mBtnEnterTicketCreate;
        private System.Windows.Forms.NumericUpDown mNumUDEnterTicketFrom;
        private System.Windows.Forms.NumericUpDown mNumUDEnterTicketTo;
        private System.Windows.Forms.Label mLblEnterTicketFrom;
        private System.Windows.Forms.Label mLblEnterTicketTo;
        private System.Windows.Forms.ProgressBar mProgressBarEnterTicketCreated;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialogInput;
        private System.Windows.Forms.SaveFileDialog mSaveFileDialogOutput;
        private System.Windows.Forms.NumericUpDown mNumUDEnterTicketXMove;
        private System.Windows.Forms.Label mLblEnterTicketXMove;
        private System.Windows.Forms.Label mLblEnterTicketYMove;
        private System.Windows.Forms.NumericUpDown mNumUDEnterTicketYMove;
        private System.Windows.Forms.GroupBox mGrpBoxEnterTicketNumbering;
        private System.Windows.Forms.TabControl mTabControlTicketType;
        private System.Windows.Forms.TabPage mTabPageEntryTicket;
        private System.Windows.Forms.TabPage mTabPageEatDrinkTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown mNumUDEatDrinkTicketXMove;
        private System.Windows.Forms.NumericUpDown mNumUDEatDrinkTicketFrom;
        private System.Windows.Forms.NumericUpDown mNumUDEatDrinkTicketYMove;
        private System.Windows.Forms.NumericUpDown mNumUDEatDrinkTicketTo;
        private System.Windows.Forms.Label mLblEatDrinkTicketFrom;
        private System.Windows.Forms.Label mLblEatDrinkTicketXMove;
        private System.Windows.Forms.Label mLblEatDrinkTicketYMove;
        private System.Windows.Forms.Label mLblEatDrinkTicketTo;
        private System.Windows.Forms.Button mBtnEatDrinkTicketCreate;
        private System.Windows.Forms.ProgressBar mProgressBarEatDrinkTicketCreated;
        private System.Windows.Forms.GroupBox mGrpBoxEnterTicketPage;
        private System.Windows.Forms.CheckBox mCheckLandscape;
        private System.Windows.Forms.Button mBtnOutputPath;
        private System.Windows.Forms.Label mLblInputPath;
        private System.Windows.Forms.Button mBtnInputPath;
        private System.Windows.Forms.Label mLblOutputPath;
        private System.Windows.Forms.TextBox mTbOutputPath;
        private System.Windows.Forms.TextBox mTbInputPath;
        private System.Windows.Forms.NumericUpDown mNumUDEatDrinkFontSize;
        private System.Windows.Forms.Label mLblEatDrinkTicketFontSize;
    }
}

