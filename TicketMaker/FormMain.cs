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

        private void mBtnCreate_Click(object sender, EventArgs e)
        {
            mImages.Clear();
            try
            {
                var lPath = mTbOutputPath.Text;
                var lOriginFile = mTbInputPath.Text;

                var lImage = System.Drawing.Image.FromFile(lOriginFile);

                for (var i = mNumUDFrom.Value; i <= mNumUDTo.Value; i++)
                {
                    this.UpdateProgress(i, mNumUDTo.Value);

                    var nCopyOfImage = (System.Drawing.Image) lImage.Clone();
                    DrawNumber(i, ref nCopyOfImage);
                    mImages.Add(Image.GetInstance(nCopyOfImage, ImageFormat.Jpeg));
                    //mImages.Add(Image.GetInstance(nCopyOfImage, BaseColor.PINK));
                }

                var lFS = new FileStream(lPath, FileMode.Create);
                var lDoc = new Document();
                var lWriter = PdfWriter.GetInstance(lDoc, lFS);
                lDoc.SetPageSize(new Rectangle(3030, 3508));
                lDoc.Open();
                foreach (var item in mImages)
                {
                    lDoc.Add(item);
                }
                lDoc.Close();

                Process.Start(lPath);

                this.UpdateProgress(-1, -1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    @"Neco se nezdarilo! Pravdepodobne mate otevreny soubor, do ktereho se maji vstupenky ulozit.\nZobrazte toto prosím autorovi aplikace:\n" +
                    exc);
            }
        }


        private void DrawNumber(decimal aNumber, ref System.Drawing.Image aImage)
        {
            var lGraphics = Graphics.FromImage(aImage);

            TextRenderer.DrawText(lGraphics,
                aNumber.ToString("000"),
                new Font("Comic Sans MS", 90f, FontStyle.Regular, GraphicsUnit.Point),
                new Point(1502, 30),
                Color.Black);
        }

        private void mNumUDFrom_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDFrom.Value > mNumUDTo.Value)
            {
                mNumUDFrom.Value = 0;
            }
        }

        private void mNumUDTo_ValueChanged(object sender, EventArgs e)
        {
            if (mNumUDFrom.Value > mNumUDTo.Value)
            {
                mNumUDTo.Value = 0;
            }
        }

        private void UpdateProgress(decimal aCurrentValue, decimal aMaxValue)
        {
            if (aCurrentValue == -1)
            {
                this.mProgressBarCreated.Value = 0;
                this.Text = Title;
                return;
            }

            this.Text = Title + @" => " + aCurrentValue + @" of " + aMaxValue;

            this.mProgressBarCreated.Maximum = Convert.ToInt32(aMaxValue);
            this.mProgressBarCreated.Value = Convert.ToInt32(aCurrentValue);
        }

        private void mBtnInputPath_Click(object sender, EventArgs e)
        {
            var lDialogResult = mOpenFileDialogInput.ShowDialog();
            if(lDialogResult.Equals(DialogResult.OK))
            {
                mTbInputPath.Text = mOpenFileDialogInput.FileName;
            }
        }

        private void mBtnOutputPath_Click(object sender, EventArgs e)
        {
            var lDialogResult = mSaveFileDialogOutput.ShowDialog();
            if (lDialogResult.Equals(DialogResult.OK))
            {
                mTbOutputPath.Text = mSaveFileDialogOutput.FileName;
            }
        }

        private void mTbInputOutput_TextChanged(object sender, EventArgs e)
        {
            if (mTbInputPath.Text != "" && mTbOutputPath.Text != "" && File.Exists(mTbInputPath.Text))
                mBtnCreate.Enabled = true;
            else
                mBtnCreate.Enabled = false;
        }
    }
}