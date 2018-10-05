using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerRunResultDisplay
{
    public partial class FormNewEditTeam : Form
    {
        private bool IsEdit { get; set; } = false;
        public Team Team { get; set; }
        public FormNewEditTeam()
        {
            InitializeComponent();

            mTbStart.Text = new TimeSpan(18,0,0).ToString();
            mTbEnd.Text = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).ToString();
        }

        public FormNewEditTeam(Team aEditedTeam) : this()
        {
            this.Team = aEditedTeam;
            this.IsEdit = true;
            this.mBtnAddEdit.Text = @"Upravit";
            this.Text = @"Upravit tým";

            this.mTbTeamName.Text = this.Team.TeamName;
            this.mTbTeamMembers.Text = this.Team.TeamMembersName;
            this.mTbStart.Text = this.Team.StartTime.ToString();
            this.mTbEnd.Text = this.Team.EndTime.ToString();
            this.mNumUDPenaltyMinutes.Value = this.Team.PenaltyMinutes;
        }

        private void mBtnAddEdit_Click(object aSender, EventArgs e)
        {
            TimeSpan lStart = TimeSpan.Parse(this.mTbStart.Text);
            TimeSpan lEnd = TimeSpan.Parse(this.mTbEnd.Text);

            if(lStart>lEnd)
            {
                MessageBox.Show("Čas začátku musí být menší než čas v cíli.");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (IsEdit)
            {
                this.Team.TeamName = this.mTbTeamName.Text;
                this.Team.TeamMembersName = this.mTbTeamMembers.Text;
                this.Team.StartTime = TimeSpan.Parse(this.mTbStart.Text);
                this.Team.EndTime = TimeSpan.Parse(this.mTbEnd.Text);
                this.Team.PenaltyMinutes = Convert.ToInt32(mNumUDPenaltyMinutes.Value);
            }
            else
            {
                this.Team = new Team()
                {
                    TeamName = this.mTbTeamName.Text,
                    TeamMembersName = this.mTbTeamMembers.Text,
                    StartTime = TimeSpan.Parse(this.mTbStart.Text),
                    EndTime = TimeSpan.Parse(this.mTbEnd.Text),
                    PenaltyMinutes = Convert.ToInt32(mNumUDPenaltyMinutes.Value)
                };
            }
        }


        private void mTbStart_Validating(object sender, CancelEventArgs e)
        {
            DateTime lDt;
            if(!DateTime.TryParse(this.mTbStart.Text, out lDt))
            {
                e.Cancel = true;                                
            }
        }

        private void mTbEnd_Validating(object sender, CancelEventArgs e)
        {
            DateTime lDt;
            if (!DateTime.TryParse(this.mTbEnd.Text, out lDt))
            {
                e.Cancel = true;
            }
        }

        private void linkLabelSetTimeNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mTbEnd.Text = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).ToString();
        }
    }
}
