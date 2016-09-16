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
    public partial class FormResultsDialog : Form
    {
        private FormMain mParentForm;
        public FormResultsDialog(FormMain aParentForm)
        {            
            InitializeComponent();

            if (aParentForm != null)
            {
                mParentForm = aParentForm;
                mParentForm.TableModelView.PropertyChanged += TableModelView_PropertyChanged;
                //this.mTableMain. = aParentForm.TableModelView;
                RefreshTable();
            }
        }

        private void TableModelView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Teams")
            {
                RefreshTable();
            }
        }

        /// <summary>
        /// Znovu načtení tabulky
        /// </summary>
        public void RefreshTable()
        {
            if (mParentForm != null)
            {
                try
                {
                    this.mTableMain.DataSource = null;
                    this.mTableMain.DataSource = mParentForm.TableModelView.Teams;
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Změna formátování pro každý druhý řádek
        /// </summary>
        private void mTableMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex %2 == 1)
            {
                e.CellStyle.BackColor = Color.YellowGreen;
            }
        }

        /// <summary>
        /// Při změně buňky v tabulce
        /// </summary>
        private void mTableMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            this.mParentForm.TableModelView.UpdateTeams();
        }

        private void mTimerTableRefresh_Tick(object sender, EventArgs e)
        {
            if(!this.mTableMain.IsCurrentCellInEditMode)
                RefreshTable();
        }
    }
}
