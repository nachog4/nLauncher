using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLauncher
{
    public partial class Form1 : Form
    {
        int picturesHeight = 350;
        int picturesMinHeight = 50;
        int picturesMaxHeight = 500;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DbController.DeleteEntries();

            ShowAppEntries();

            //OptionsForm options = new OptionsForm();
            //options.Show();

            //SearchWindow search = new SearchWindow();
            //search.Show();

        }

        public void ShowAppEntries()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in DbController.GetEntries()) { ShowEntry_v2(item); }
        }

        public void ShowEntry(AppEntry appEntry)
        {
            var request = WebRequest.Create(appEntry.Image1);
            Image tmpImg;

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                tmpImg = Bitmap.FromStream(stream);
            }

            PictureBox pic = new PictureBox();
            //pic.ImageLocation = file;
            pic.Image = tmpImg;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Height = picturesHeight;

            double ar = (double)pic.Image.Width / (double)pic.Image.Height;
            pic.Width = (int)Math.Round(pic.Height * ar);

            pic.Cursor = Cursors.Hand;

            flowLayoutPanel1.Controls.Add(pic);
        }

        public void ShowEntry_v2(AppEntry appEntry)
        {
            PictureBox pic = new PictureBox();
            pic.Name = "pb_" + appEntry.Id.ToString();

            if (appEntry.Image2 == null) { return; }

            using (var ms = new MemoryStream(appEntry.Image2))
            {
                pic.Image = Image.FromStream(ms);
            }

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Height = picturesHeight;

            double ar = (double)pic.Image.Width / (double)pic.Image.Height;
            pic.Width = (int)Math.Round(pic.Height * ar);

            pic.Cursor = Cursors.Hand;

            pic.Click += Pic_Click;

            flowLayoutPanel1.Controls.Add(pic);
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            if (chk_editMode.Checked)
            {
                PictureBox tmpPictureBox = (PictureBox)sender;
                int entryId = Convert.ToInt32(tmpPictureBox.Name.Replace("pb_", ""));
                AppEntry entry = DbController.GetEntry(entryId);
                AppEntryDetailsForm entryDetailsForm = new AppEntryDetailsForm();
                entryDetailsForm.Show();
                entryDetailsForm.InitializeValuesFromEntry(entry);

            } else
            {

            }
        }

        public void ResizeEntries(int newHeight)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                PictureBox tmpPic = (PictureBox)item;
                tmpPic.Height = newHeight;
                double ar = (double)tmpPic.Image.Width / (double)tmpPic.Image.Height;
                tmpPic.Width = (int)Math.Round(tmpPic.Height * ar);

            }
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string files = (string)e.Data.GetData(DataFormats.Text);

            if (!String.IsNullOrEmpty(files))
            {
                //AddEntry(files);
            }

            //Bitmap files2 = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            string[] files3 = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files3 != null)
            {
                ShortcutInfo sInfo = new ShortcutInfo();
                sInfo = ShortcutsController.GetShortcutInfo(files3[0]);

                if (!sInfo.isError)
                {
                    AppEntryDetailsForm entryDetailsForm = new AppEntryDetailsForm();
                    entryDetailsForm.Show();
                    entryDetailsForm.InitializeValuesFromShortcut(sInfo);

                }
            }
        }

                private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int currentValue = trackBar1.Value;
            ResizeEntries(currentValue * picturesMaxHeight / 50);
        }
    }
}
