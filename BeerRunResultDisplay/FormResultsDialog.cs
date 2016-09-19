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
                this.mTableMain.DataSource = mParentForm.TableModelView.Teams;
                         
            }
        }

        /// <summary>
        /// Změna formátování pro každý druhý řádek
        /// </summary>
        private void mTableMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex %2 == 1)
            {
                e.CellStyle.BackColor = Color.LightGoldenrodYellow;
            }
        }

        /// <summary>
        /// Při změně buňky v tabulce
        /// </summary>
        private void mTableMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.mTableMain.Refresh();
        }

        /// <summary>
        /// Zobrazení headeru pro pořadí
        /// </summary>
        private void mTableMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var lGrid = sender as DataGridView;
            var lRowNum = (e.RowIndex + 1).ToString();

            var lCenterFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var lHeaderBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, lGrid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(lRowNum, this.Font, SystemBrushes.ControlText, lHeaderBounds, lCenterFormat);
        }
    }
}
