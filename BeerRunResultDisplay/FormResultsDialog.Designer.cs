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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultsDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTableMain = new System.Windows.Forms.DataGridView();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mPanelOtaHead = new System.Windows.Forms.Panel();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableModelViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mTableMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableModelViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mTableMain
            // 
            this.mTableMain.AllowUserToAddRows = false;
            this.mTableMain.AllowUserToDeleteRows = false;
            this.mTableMain.AllowUserToOrderColumns = true;
            this.mTableMain.AllowUserToResizeRows = false;
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
            this.PenaltyMinutes,
            this.TotalTime});
            this.mTableMain.DataSource = this.teamsBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mTableMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.mTableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTableMain.Location = new System.Drawing.Point(0, 0);
            this.mTableMain.Name = "mTableMain";
            this.mTableMain.Size = new System.Drawing.Size(814, 442);
            this.mTableMain.TabIndex = 0;
            this.mTableMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mTableMain_CellContentDoubleClick);
            this.mTableMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mTableMain_CellEndEdit);
            this.mTableMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mTableMain_CellFormatting);
            this.mTableMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.mTableMain_RowPostPaint);
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.tableModelViewBindingSource;
            // 
            // mPanelOtaHead
            // 
            this.mPanelOtaHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelOtaHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mPanelOtaHead.BackgroundImage")));
            this.mPanelOtaHead.Location = new System.Drawing.Point(713, 346);
            this.mPanelOtaHead.Name = "mPanelOtaHead";
            this.mPanelOtaHead.Size = new System.Drawing.Size(101, 96);
            this.mPanelOtaHead.TabIndex = 1;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.tableModelViewBindingSource;
            // 
            // tableModelViewBindingSource
            // 
            this.tableModelViewBindingSource.DataSource = typeof(BeerRunResultDisplay.TableModelView);
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Název týmu";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            this.teamNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MembersName
            // 
            this.MembersName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MembersName.DataPropertyName = "TeamMembersName";
            this.MembersName.HeaderText = "Členové";
            this.MembersName.Name = "MembersName";
            this.MembersName.ReadOnly = true;
            this.MembersName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.endTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Cíl";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // PenaltyMinutes
            // 
            this.PenaltyMinutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PenaltyMinutes.DataPropertyName = "PenaltyMinutes";
            this.PenaltyMinutes.HeaderText = "Trestné body";
            this.PenaltyMinutes.Name = "PenaltyMinutes";
            this.PenaltyMinutes.ReadOnly = true;
            this.PenaltyMinutes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PenaltyMinutes.Width = 139;
            // 
            // TotalTime
            // 
            this.TotalTime.DataPropertyName = "TotalTime";
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = null;
            this.TotalTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalTime.HeaderText = "Celkový čas";
            this.TotalTime.MinimumWidth = 150;
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Width = 150;
            // 
            // FormResultsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 442);
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
        private System.Windows.Forms.Panel mPanelOtaHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
    }
}