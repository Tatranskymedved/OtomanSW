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
    public partial class FormDeleteTeam : Form
    {
        private FormMain mFormMain;

        public FormDeleteTeam(FormMain aMainForm)
        {
            InitializeComponent();

            if (aMainForm != null)
                this.mFormMain = aMainForm;

            RefreshCombo();
        }

        private void mBtnDeleteTeam_Click(object sender, EventArgs e)
        {
            if(this.mFormMain != null && this.mComboBoxTeamName.SelectedItem != null)
            {
                this.mFormMain.TableModelView.Remove(this.mComboBoxTeamName.SelectedItem as Team);
            }
            RefreshCombo();
        }

        public void RefreshCombo()
        {
            if (this.mFormMain != null)
            {
                this.mComboBoxTeamName.DataSource = null;
                this.mComboBoxTeamName.DataSource = mFormMain.TableModelView.Teams;
            }
        }
    }
}
