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
    public partial class FormMain : Form
    {
        private TableModelView mTableModelView = new TableModelView();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Načtení výsledků ze souboru
        /// </summary>
        private void mBtnLoadResults_Click(object sender, EventArgs e)
        {
            mTableModelView.LoadState(mTBoxFilePathXMLResult.Text);
        }

        /// <summary>
        /// Uložení aktuálních výsledků
        /// </summary>
        private void mBtnSaveResults_Click(object sender, EventArgs e)
        {
            mTableModelView.SaveState(mTBoxFilePathXMLResult.Text);
        }

        /// <summary>
        /// Vybrání souboru pro čtení/zápis
        /// </summary>
        private void mBtnFileDialogXMLResult_Click(object sender, EventArgs e)
        {
            var lResult = mSaveFileDialogXMLResult.ShowDialog();
            if(lResult.Equals(DialogResult.OK))
            {
                mTBoxFilePathXMLResult.Text = mSaveFileDialogXMLResult.FileName;
                mTBoxFilePathXMLResult.Focus();
                int lIndexOfFileName = mTBoxFilePathXMLResult.Text.LastIndexOf('\\') + 1;
                mTBoxFilePathXMLResult.Select(lIndexOfFileName,mTBoxFilePathXMLResult.Text.Length - lIndexOfFileName - ".xml".Length);
            }
        }

        /// <summary>
        /// Povolení/zakázání použití tlačítek pro load/save
        /// </summary>
        private void mTBoxFilePathXMLResult_TextChanged(object sender, EventArgs e)
        {
            string path = mTBoxFilePathXMLResult.Text.Substring(0, mTBoxFilePathXMLResult.Text.LastIndexOf('\\'));
            if (mTBoxFilePathXMLResult.Text != "" && System.IO.Directory.Exists(path) && mTBoxFilePathXMLResult.Text.ToLower().Contains(".xml"))
            {
                mBtnLoadResults.Enabled = true;
                mBtnSaveResults.Enabled = true;
            }
            else
            {
                mBtnLoadResults.Enabled = false;
                mBtnSaveResults.Enabled = false;
            }
        }
    }
}
