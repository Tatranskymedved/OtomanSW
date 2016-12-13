using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace TicketMaker
{
    public partial class FormMain : Form
    {
        private const string Title = "TicketMaker - Turbo©";
        private readonly List<Image> mImages;

        public FormMain()
        {
            InitializeComponent();
            mImages = new List<Image>();
        }

        #region [Společné metody pro EatDrink a Enter tickety]

        /// <summary>
        /// Vykreslování čísla na podklad
        /// </summary>
        /// <param name="aNumber">Číslo, které se má na obrázek vložit</param>
        /// <param name="aImage">Obrázek (podklad) na který se vkládá</param>
        /// <param name="aXMove">Počet pixelů o které se má číslo na obrázku posunout v ose X</param>
        /// <param name="aYMove">Počet pixelů o které se má číslo na obrázku posunout v ose Y</param>
        private void DrawNumber(decimal aNumber, ref System.Drawing.Image aImage, int aXMove, int aYMove)
        {
            this.DrawNumber(aNumber, ref aImage, aXMove, aYMove, new Font("Comic Sans MS", 90f, FontStyle.Regular, GraphicsUnit.Point));
        }

        /// <summary>
        /// Vykreslování čísla na podklad
        /// </summary>
        /// <param name="aNumber">Číslo, které se má na obrázek vložit</param>
        /// <param name="aImage">Obrázek (podklad) na který se vkládá</param>
        /// <param name="aXMove">Počet pixelů o které se má číslo na obrázku posunout v ose X</param>
        /// <param name="aYMove">Počet pixelů o které se má číslo na obrázku posunout v ose Y</param>
        /// <param name="aFont">Font v jakém má číslo být napsáno</param>
        private void DrawNumber(decimal aNumber, ref System.Drawing.Image aImage, int aXMove, int aYMove, Font aFont)
        {
            var lGraphics = Graphics.FromImage(aImage);

            TextRenderer.DrawText(lGraphics,
                aNumber.ToString("000"),
                aFont,
                new Point(aXMove, aYMove), //new Point(1502, 30),
                Color.Black);
        }

        /// <summary>
        /// Metoda zobrazující aktuální progress výroby výsledku na daném ProgressBaru
        /// </summary>
        /// <param name="aCurrentValue">Současná hodnota</param>
        /// <param name="aMaxValue">Maximální hodnota</param>
        private void UpdateProgress(ProgressBar aTargetProgressBar, decimal aCurrentValue, decimal aMaxValue)
        {
            if (aCurrentValue == -1)
            {
                aTargetProgressBar.Value = 0;
                this.Text = Title;
                return;
            }

            if (aCurrentValue != aMaxValue)
                this.Text = Title + @" => " + aCurrentValue + @" of " + aMaxValue;
            else
                this.Text = Title;

            aTargetProgressBar.Maximum = Convert.ToInt32(aMaxValue);
            aTargetProgressBar.Value = Convert.ToInt32(aCurrentValue);
        }

        /// <summary>
        /// Dialogovoé okno pro obrázek vstupenky (Odkud brát)
        /// </summary>
        private void mBtnInputPath_Click(object sender, EventArgs e)
        {
            var lDialogResult = mOpenFileDialogInput.ShowDialog();
            if (lDialogResult.Equals(DialogResult.OK))
            {
                mTbInputPath.Text = mOpenFileDialogInput.FileName;
            }
        }

        /// <summary>
        /// Dialogové okno pro vytvořené PDF (kam uložit)
        /// </summary>
        private void mBtnOutputPath_Click(object sender, EventArgs e)
        {
            var lDialogResult = mSaveFileDialogOutput.ShowDialog();
            if (lDialogResult.Equals(DialogResult.OK))
            {
                mTbOutputPath.Text = mSaveFileDialogOutput.FileName;
            }
        }

        /// <summary>
        /// Metoda obsluhující změny v input/output cest (TB), kontrolující zda-li je cesta k souboru validní
        /// </summary>
        private void mTbInputOutput_TextChanged(object sender, EventArgs e)
        {
            if (mTbInputPath.Text != "" && File.Exists(mTbInputPath.Text))
            {
                if (mTbOutputPath.Text != "")
                {
                    mBtnEnterTicketCreate.Enabled = true;
                    mBtnEatDrinkTicketCreate.Enabled = true;
                }
                else
                {

                    mBtnEnterTicketCreate.Enabled = false;
                    mBtnEatDrinkTicketCreate.Enabled = false;
                }
                mBtnPreview.Enabled = true;
            }
            else
            {
                mBtnEnterTicketCreate.Enabled = false;
                mBtnEatDrinkTicketCreate.Enabled = false;
                mBtnPreview.Enabled = false;
            }
        }

        /// <summary>
        /// Vykreslení ukázky daného typu (EatDrink ticket nebo Entry ticket)
        /// </summary>
        private void mBtnPreview_Click(object sender, EventArgs e)
        {
            mPanelPreview.Refresh();
        }

        #endregion

        #region [Enter ticket]

        /// <summary>
        /// Vytvoření PDF dokumentu + nasypání obrázky v řadě s očíslováním. Enter ticket.
        /// </summary>        
        private void mBtnEnterTicketCreate_Click(object sender, EventArgs e)
        {
            mImages.Clear();
            try
            {
                var lPath = mTbOutputPath.Text;
                var lOriginFile = mTbInputPath.Text;

                var lImage = System.Drawing.Image.FromFile(lOriginFile);

                int lXMove = Convert.ToInt32(mNumUDEnterTicketXMove.Value);
                int lYMove = Convert.ToInt32(mNumUDEnterTicketYMove.Value);

                for (var i = mNumUDEnterTicketFrom.Value; i <= mNumUDEnterTicketTo.Value; i++)
                {
                    this.UpdateProgress(this.mProgressBarEnterTicketCreated, i, mNumUDEnterTicketTo.Value);

                    
                    var nCopyOfImage = (System.Drawing.Image) lImage.Clone();
                    DrawNumber(i, ref nCopyOfImage, lXMove, lYMove, new Font("Comic Sans MS", 90f, FontStyle.Regular, GraphicsUnit.Point));
                    mImages.Add(Image.GetInstance(nCopyOfImage, ImageFormat.Jpeg));
                    //mImages.Add(Image.GetInstance(nCopyOfImage, BaseColor.PINK));
                }

                var lFS = new FileStream(lPath, FileMode.Create);
                var lDoc = new Document();
                var lWriter = PdfWriter.GetInstance(lDoc, lFS);
                if (mCheckLandscape.Checked)
                {
                    //lDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                    lDoc.SetPageSize(new Rectangle(2230, 3008).Rotate());
                }
                else
                {
                    //lDoc.SetPageSize(iTextSharp.text.PageSize.A4);
                    lDoc.SetPageSize(new Rectangle(3030, 3508));
                }
                
                lDoc.Open();
                foreach (var item in mImages)
                {
                    lDoc.Add(item);
                }
                lDoc.Close();

                Process.Start(lPath);

                this.UpdateProgress(mProgressBarEnterTicketCreated, -1, -1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    @"Neco se nezdarilo! Pravdepodobne mate otevreny soubor, do ktereho se maji vstupenky ulozit.\nZobrazte toto prosím autorovi aplikace:\n" +
                    exc);
            }
        }

        /// <summary>
        /// Metoda kontrolující navzajem hodnoty NumericUpDown pro hodnoty OD a DO pro Enter Ticket
        /// </summary>
        private void mNumUDEnterTicketFrom_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDEnterTicketFrom.Value > mNumUDEnterTicketTo.Value)
            {
                mNumUDEnterTicketFrom.Value = 0;
            }
        }

        /// <summary>
        /// Metoda kontrolující navzajem hodnoty NumericUpDown pro hodnoty OD a DO pro Enter Ticket
        /// </summary>
        private void mNumUDEnterTicketTo_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDEnterTicketFrom.Value > mNumUDEnterTicketTo.Value)
            {
                mNumUDEnterTicketTo.Value = 0;
            }
        }

        #endregion

        #region [EatDrink ticket]

        /// <summary>
        /// Vytvoření PDF dokumentu + nasypání obrázky v řadě s očíslováním. EatDrink ticket.
        /// </summary>
        private void mBtnEatDrinkTicketCreate_Click(object sender, EventArgs e)
        {
            mImages.Clear();
            try
            {
                var lPath = mTbOutputPath.Text;
                var lOriginFile = mTbInputPath.Text;

                var lImage = System.Drawing.Image.FromFile(lOriginFile);

                int lXMove = Convert.ToInt32(mNumUDEatDrinkTicketXMove.Value);
                int lYMove = Convert.ToInt32(mNumUDEatDrinkTicketYMove.Value);
                float lFontSize = (float)(mNumUDEatDrinkFontSize.Value);

                for (var i = mNumUDEatDrinkTicketFrom.Value; i <= mNumUDEatDrinkTicketTo.Value; i++)
                {
                    this.UpdateProgress(this.mProgressBarEatDrinkTicketCreated, i, mNumUDEatDrinkTicketTo.Value);

                    var nCopyOfImage = (System.Drawing.Image)lImage.Clone();
                    DrawNumber(i, ref nCopyOfImage, lXMove, lYMove, new Font("Comic Sans MS", lFontSize, FontStyle.Regular, GraphicsUnit.Point));
                    mImages.Add(Image.GetInstance(nCopyOfImage, ImageFormat.Jpeg));
                    //mImages.Add(Image.GetInstance(nCopyOfImage, BaseColor.PINK));
                }

                var lFS = new FileStream(lPath, FileMode.Create);
                var lDoc = new Document();
                var lWriter = PdfWriter.GetInstance(lDoc, lFS);
                //if (mCheckLandscape.Checked)
                //{
                //    //lDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                //    lDoc.SetPageSize(new Rectangle(2230, 3008).Rotate());
                //}
                //else
                //{
                    //lDoc.SetPageSize(iTextSharp.text.PageSize.A4);
                lDoc.SetPageSize(new Rectangle(3150, 4150));
                //}

                lDoc.Open();
                foreach (var item in mImages)
                {
                    lDoc.Add(new iTextSharp.text.Chunk(item, 0, 0,true));
                }
                lDoc.Close();

                Process.Start(lPath);

                this.UpdateProgress(mProgressBarEatDrinkTicketCreated, -1, -1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    @"Neco se nezdarilo! Pravdepodobne mate otevreny soubor, do ktereho se maji vstupenky ulozit.\nZobrazte toto prosím autorovi aplikace:\n" +
                    exc);
            }
        }

        /// <summary>
        /// Metoda kontrolující navzajem hodnoty NumericUpDown pro hodnoty OD a DO pro EatDrink Ticket
        /// </summary>
        private void mNumUDEatDrinkTicketFrom_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDEatDrinkTicketFrom.Value > mNumUDEatDrinkTicketTo.Value)
            {
                mNumUDEatDrinkTicketFrom.Value = 0;
            }
        }

        /// <summary>
        /// Metoda kontrolující navzajem hodnoty NumericUpDown pro hodnoty OD a DO pro EatDrink Ticket
        /// </summary>
        private void mNumUDEatDrinkTicketTo_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDEatDrinkTicketFrom.Value > mNumUDEatDrinkTicketTo.Value)
            {
                mNumUDEatDrinkTicketTo.Value = 0;
            }
        }

        #endregion

        private void mPanelPreview_Paint(object sender, PaintEventArgs e)
        {

            try
            { 
                if (!mBtnPreview.Enabled) return;

                using (Graphics lGraphics = e.Graphics)
                {
                    if (mTabControlTicketType.SelectedIndex == 0) //Chlastenka/stravenka
                    {
                        var lOriginFile = mTbInputPath.Text;
                        var lImage = System.Drawing.Image.FromFile(lOriginFile);
                        int lXMove = Convert.ToInt32(mNumUDEatDrinkTicketXMove.Value);
                        int lYMove = Convert.ToInt32(mNumUDEatDrinkTicketYMove.Value);
                        float lFontSize = (float)(mNumUDEatDrinkFontSize.Value);

                        DrawNumber(mNumUDEatDrinkTicketFrom.Value, ref lImage, lXMove, lYMove, new Font("Comic Sans MS", lFontSize, FontStyle.Regular, GraphicsUnit.Point));

                        lGraphics.DrawImage(lImage, new Point(0, 0));
                    }
                    else //Vstupenka
                    {
                        var lOriginFile = mTbInputPath.Text;
                        var lImage = System.Drawing.Image.FromFile(lOriginFile);
                        int lXMove = Convert.ToInt32(mNumUDEnterTicketXMove.Value);
                        int lYMove = Convert.ToInt32(mNumUDEnterTicketYMove.Value);

                        DrawNumber(mNumUDEnterTicketFrom.Value, ref lImage, lXMove, lYMove, new Font("Comic Sans MS", 90f, FontStyle.Regular, GraphicsUnit.Point));

                        lGraphics.DrawImage(lImage, new Point(0, 0));
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}