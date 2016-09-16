namespace BeerRunResultDisplay
{
    partial class FormResultsDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultsDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTableMain = new System.Windows.Forms.DataGridView();
            this.mTimerTableRefresh = new System.Windows.Forms.Timer(this.components);
            this.mPanelOtaHead = new System.Windows.Forms.Panel();
            this.MembersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyMinutesAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableModelViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mTableMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableModelViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mTableMain
            // 
            this.mTableMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTableMain.AutoGenerateColumns = false;
            this.mTableMain.BackgroundColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mTableMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mTableMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mTableMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamNameDataGridViewTextBoxColumn,
            this.MembersName,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.PenaltyMinutesAsString,
            this.TotalTime,
            this.GetTotalTime});
            this.mTableMain.DataSource = this.teamsBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mTableMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.mTableMain.Location = new System.Drawing.Point(0, 0);
            this.mTableMain.Name = "mTableMain";
            this.mTableMain.Size = new System.Drawing.Size(1479, 443);
            this.mTableMain.TabIndex = 0;
            this.mTableMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mTableMain_CellEndEdit);
            this.mTableMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mTableMain_CellFormatting);
            // 
            // mTimerTableRefresh
            // 
            this.mTimerTableRefresh.Enabled = true;
            this.mTimerTableRefresh.Interval = 5000;
            this.mTimerTableRefresh.Tick += new System.EventHandler(this.mTimerTableRefresh_Tick);
            // 
            // mPanelOtaHead
            // 
            this.mPanelOtaHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelOtaHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mPanelOtaHead.BackgroundImage")));
            this.mPanelOtaHead.Location = new System.Drawing.Point(1371, 347);
            this.mPanelOtaHead.Name = "mPanelOtaHead";
            this.mPanelOtaHead.Size = new System.Drawing.Size(101, 96);
            this.mPanelOtaHead.TabIndex = 1;
            // 
            // MembersName
            // 
            this.MembersName.DataPropertyName = "TeamMembersName";
            this.MembersName.HeaderText = "Členové";
            this.MembersName.Name = "MembersName";
            this.MembersName.Width = 350;
            // 
            // PenaltyMinutesAsString
            // 
            this.PenaltyMinutesAsString.DataPropertyName = "PenaltyMinutes";
            this.PenaltyMinutesAsString.HeaderText = "Trestné body";
            this.PenaltyMinutesAsString.Name = "PenaltyMinutesAsString";
            this.PenaltyMinutesAsString.Width = 180;
            // 
            // TotalTime
            // 
            this.TotalTime.DataPropertyName = "TotalTime";
            this.TotalTime.HeaderText = "Celkový čas";
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Width = 180;
            // 
            // GetTotalTime
            // 
            this.GetTotalTime.DataPropertyName = "GetTotalTime";
            this.GetTotalTime.HeaderText = "GetTotalTime";
            this.GetTotalTime.Name = "GetTotalTime";
            this.GetTotalTime.ReadOnly = true;
            this.GetTotalTime.Visible = false;
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.tableModelViewBindingSource;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.tableModelViewBindingSource;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Název týmu";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            this.teamNameDataGridViewTextBoxColumn.Width = 350;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 180;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.endTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Cíl";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 180;
            // 
            // tableModelViewBindingSource
            // 
            this.tableModelViewBindingSource.DataSource = typeof(BeerRunResultDisplay.TableModelView);
            // 
            // FormResultsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 442);
            this.Controls.Add(this.mPanelOtaHead);
            this.Controls.Add(this.mTableMain);
            this.Name = "FormResultsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pivní běh - výsledky";
            ((System.ComponentModel.ISupportInitialize)(this.mTableMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableModelViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mTableMain;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.BindingSource tableModelViewBindingSource;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private System.Windows.Forms.Timer mTimerTableRefresh;
        private System.Windows.Forms.Panel mPanelOtaHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyMinutesAsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetTotalTime;
    }
}