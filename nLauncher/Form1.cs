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
    public partial class Form1 : Form
    {
        Model1 model = new Model1();
        int picturesHeight = 350;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in model.MyEntities)
            {
                ShowEntry(item.Name);
            }

            OptionsForm options = new OptionsForm();
            options.Show();

        }

        public void DeleteEntries ()
        {
            foreach (var item in model.MyEntities)
            {
                model.MyEntities.Remove(item);
            }

            model.SaveChanges();
        }

        private void googleSearch (string query)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();

            const string apiKey = "AIzaSyALPsRIcFB8dc9SbsaaA-f1gRNG3gZtxV4";
            const string searchEngineId = "015210785414118161171:eaqkejpiflg";
            var customSearchService = new Google.Apis.Customsearch.v1.CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = searchEngineId;
            listRequest.ImgSize = Google.Apis.Customsearch.v1.CseResource.ListRequest.ImgSizeEnum.Large;
            listRequest.SearchType = Google.Apis.Customsearch.v1.CseResource.ListRequest.SearchTypeEnum.Image;
            listRequest.Safe = Google.Apis.Customsearch.v1.CseResource.ListRequest.SafeEnum.Off;

            IList<Google.Apis.Customsearch.v1.Data.Result> paging = new List<Google.Apis.Customsearch.v1.Data.Result>();
            var count = 0;
            while (paging != null)
            {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items;
                if (paging != null)
                    foreach (var item in paging)
                    {
                        searchWindow.AddSearchWindowEntry(item.Link);
                    }
                count++;
                if (count >= 2) { break; }
            }
        }

        private void AddEntry(string file)
        {
            MyEntity ent = new MyEntity();
            ent.Id = 1;
            ent.Name = file;
            model.MyEntities.Add(ent);
            model.SaveChanges();

            ShowEntry(file);

            //pic.Update();
            //pic.Show();
        }

        public void ShowEntry(string file)
        {
            var request = WebRequest.Create(file);
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
                AddEntry(files);
            }

            //Bitmap files2 = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            //string[] files3 = (string[])e.Data.GetData(DataFormats.FileDrop);
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        
    }
}
