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
    public partial class FormNewTeam : Form
    {
        public Team Team { get; set; }
        public FormNewTeam()
        {
            InitializeComponent();

            mTbStart.Text = DateTime.Today.Add(new TimeSpan(18,0,0)).ToString();
            mTbEnd.Text = DateTime.Now.ToString();
        }

        private void mBtnAdd_Click(object sender, EventArgs e)
        {
            DateTime lStart = DateTime.Parse(this.mTbStart.Text);
            DateTime lEnd = DateTime.Parse(this.mTbEnd.Text);

            if(lStart>lEnd)
            {
                MessageBox.Show("Čas začátku musí být menší než čas v cíli.");
                this.DialogResult = DialogResult.None;
                return;
            }

            this.Team = new Team()
            {
                TeamName = this.mTbTeamName.Text,
                TeamMembersName = this.mTbTeamMembers.Text,
                StartTime = DateTime.Parse(this.mTbStart.Text),
                EndTime = DateTime.Parse(this.mTbEnd.Text),
                PenaltyMinutes = Convert.ToInt32(mNumUDPenaltyMinutes.Value)
            };
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
    }
}
