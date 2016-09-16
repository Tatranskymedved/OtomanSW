namespace BeerRunResultDisplay
{
    partial class FormDeleteTeam
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
            this.mComboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableModelViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBtnDeleteTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableModelViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mComboBoxTeamName
            // 
            this.mComboBoxTeamName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamsBindingSource, "TeamName", true));
            this.mComboBoxTeamName.DataSource = this.teamsBindingSource;
            this.mComboBoxTeamName.DisplayMember = "TeamName";
            this.mComboBoxTeamName.FormattingEnabled = true;
            this.mComboBoxTeamName.Location = new System.Drawing.Point(13, 13);
            this.mComboBoxTeamName.Name = "mComboBoxTeamName";
            this.mComboBoxTeamName.Size = new System.Drawing.Size(185, 21);
            this.mComboBoxTeamName.TabIndex = 0;
            this.mComboBoxTeamName.ValueMember = "TeamName";
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
            // mBtnDeleteTeam
            // 
            this.mBtnDeleteTeam.Location = new System.Drawing.Point(204, 8);
            this.mBtnDeleteTeam.Name = "mBtnDeleteTeam";
            this.mBtnDeleteTeam.Size = new System.Drawing.Size(76, 28);
            this.mBtnDeleteTeam.TabIndex = 1;
            this.mBtnDeleteTeam.Text = "Smazat";
            this.mBtnDeleteTeam.UseVisualStyleBackColor = true;
            this.mBtnDeleteTeam.Click += new System.EventHandler(this.mBtnDeleteTeam_Click);
            // 
            // FormDeleteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 48);
            this.Controls.Add(this.mBtnDeleteTeam);
            this.Controls.Add(this.mComboBoxTeamName);
            this.Name = "FormDeleteTeam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smazáni týmu";
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableModelViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mComboBoxTeamName;
        private System.Windows.Forms.Button mBtnDeleteTeam;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.BindingSource tableModelViewBindingSource;
    }
}