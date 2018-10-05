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
        public TableModelView TableModelView
        {
            get { return this.mTableModelView; }
            private set { this.mTableModelView = value; }
        }

        public FormMain()
        {
            InitializeComponent();

            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        //private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    MessageBox.Show((e.ExceptionObject as Exception).ToString());
        //}

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
            if (mTBoxFilePathXMLResult.Text != "" && System.IO.Directory.Exists(path))
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

        /// <summary>
        /// Otevření dalších oken pro úpravu/ukázání výsledků
        /// </summary>
        private void mBtnEditShowResults_Click(object sender, EventArgs e)
        {
            //BindingSource BindSrc = new BindingSource(mTableModelView, "TableModelView");
            FormResultsDialog lFormResults = new FormResultsDialog(this);
            lFormResults.Show();
        }

        /// <summary>
        /// Zobrazí dialogové okno pro přidání týmu
        /// </summary>
        private void mBtnAddNewTeam_Click(object sender, EventArgs e)
        {
            var lNewTeamForm = new FormNewEditTeam();
            DialogResult lDialogResult = lNewTeamForm.ShowDialog();
            if(lDialogResult.Equals(DialogResult.OK))
            {
                this.TableModelView.Add(lNewTeamForm.Team);
            }
        }

        /// <summary>
        /// Uložení týmů při zavření
        /// </summary>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mTableModelView.SaveState(System.IO.Path.GetTempPath()+"otomanPivniBeh-temp"+DateTime.Now.ToString("hh-MM-ss") + ".xml");
        }

        /// <summary>
        /// Formulář pro odebrání týmů
        /// </summary>
        private void mBtnDeleteTeam_Click(object sender, EventArgs e)
        {
            new FormDeleteTeam(this).Show();
        }

        /// <summary>
        /// Pravidelné ukládání co 5 minut pokud je možno XML soubor uložit (je známa cesta)
        /// </summary>        
        private void mTimerSave5mins_Tick(object sender, EventArgs e)
        {
            try
            {
                mTableModelView.SaveState(System.IO.Path.GetTempPath() + "otomanPivniBeh-temp" +
                                          DateTime.Now.ToString("hh-MM-ss") + ".xml");
            }
            catch (Exception lEx)
            {
                MessageBox.Show("Nastala vyjímka při pravidelném 5min. ukládání: " + Environment.NewLine + lEx.Message);
            }
        }
    }
}
