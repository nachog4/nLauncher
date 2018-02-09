using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLauncher
{
    public partial class SearchWindow : Form
    {
        int picturesHeight = 150;

        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {

        }

        public void Search(string query)
        {
            var results = ImagesProvider.googleSearch(query);
            foreach (var item in results)
            {
                //AddSearchWindowEntry(item.Link);
                ShowImageResultEntry(item);
            }
        }

        public void AddSearchWindowEntry(string file)
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = file;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = 200;
            pic.Height = 200;

            pic.Click += Pic_Click;

            flowLayoutPanel1.Controls.Add(pic);
        }

        public void ShowImageResultEntry(Google.Apis.Customsearch.v1.Data.Result result)
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = result.Link;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Height = picturesHeight;

            double ar = (double)result.Image.Width / (double)result.Image.Height;
            pic.Width = (int)Math.Round(pic.Height * ar);

            pic.Cursor = Cursors.Hand;

            pic.Click += Pic_Click;
            flowLayoutPanel1.Controls.Add(pic);
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).setImage1(pb.ImageLocation);
            (System.Windows.Forms.Application.OpenForms["SearchWindow"] as SearchWindow).Close();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
