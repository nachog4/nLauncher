using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLauncher
{
    public partial class AppEntryDetailsForm : Form
    {
        bool image_isModified = false;
        bool screenshot1_isModified = false;
        bool screenshot2_isModified = false;
        bool screenshot3_isModified = false;

        public AppEntryDetailsForm()
        {
            InitializeComponent();
        }

        public void InitializeValuesFromShortcut(ShortcutInfo sInfo)
        {
            txt_name.Text = sInfo.Name;
            txt_path.Text = sInfo.Path;
        }

        public void InitializeValuesFromEntry(AppEntry entry)
        {
            txt_id.Text = entry.Id.ToString();
            txt_name.Text = entry.Name;
            txt_path.Text = entry.Path;
            txt_category.Text = entry.Category;

            if (entry.Image2 != null) { pic_image.Image = Tools.GetImageFromByte(entry.Image2); }

            if (entry.Screenshot1 != null) { pic_screenshot1.Image = Tools.GetImageFromByte(entry.Screenshot1); }
            if (entry.Screenshot2 != null) { pic_screenshot2.Image = Tools.GetImageFromByte(entry.Screenshot2); }
            if (entry.Screenshot3 != null) { pic_screenshot3.Image = Tools.GetImageFromByte(entry.Screenshot3);  }
        }

        private void btn_searchImage_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.Show();
            search.Search(txt_name.Text);
        }

        public void setImage1(Image image)
        {
            pic_image.Image = image;
            image_isModified = true;
        }

        public void setScreenshot1(Image image)
        {
            pic_screenshot1.Image = image;
            screenshot1_isModified = true;
        }

        public void setScreenshot2(Image image)
        {
            pic_screenshot2.Image = image;
            screenshot2_isModified = true;
        }

        public void setScreenshot3(Image image)
        {
            pic_screenshot3.Image = image;
            screenshot3_isModified = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {

                AppEntry newApp = new AppEntry();
                newApp.Name = txt_name.Text;
                newApp.Path = txt_path.Text;
                newApp.Category = txt_category.Text;

                if (pic_image.Image != null) { newApp.Image2 = Tools.GetByteFromImage(pic_image.Image); }
                if (pic_screenshot1.Image != null) { newApp.Screenshot1 = Tools.GetByteFromImage(pic_screenshot1.Image); }
                if (pic_screenshot2.Image != null) { newApp.Screenshot2 = Tools.GetByteFromImage(pic_screenshot2.Image); }
                if (pic_screenshot3.Image != null) { newApp.Screenshot3 = Tools.GetByteFromImage(pic_screenshot3.Image); }

                DbController.AddEntry(newApp);

                (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Close();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
            }
            else
            {
                AppEntry modifyApp = DbController.GetEntry(Convert.ToInt32(txt_id.Text));
                modifyApp.Name = txt_name.Text;
                modifyApp.Path = txt_path.Text;
                modifyApp.Category = txt_category.Text;

                if (pic_image.Image != null & image_isModified) { modifyApp.Image2 = Tools.GetByteFromImage(pic_image.Image); }
                if (pic_screenshot1.Image != null && screenshot1_isModified) { modifyApp.Screenshot1 = Tools.GetByteFromImage(pic_screenshot1.Image); }
                if (pic_screenshot2.Image != null && screenshot2_isModified) { modifyApp.Screenshot2 = Tools.GetByteFromImage(pic_screenshot2.Image); }
                if (pic_screenshot3.Image != null && screenshot3_isModified) { modifyApp.Screenshot3 = Tools.GetByteFromImage(pic_screenshot3.Image); }

                DbController.ModifyEntry(modifyApp);
                (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Close();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
            }
        }

        private void AppEntryDetailsForm_Load(object sender, EventArgs e)
        {
            pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_screenshot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_screenshot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_screenshot3.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                AppEntry modifyApp = DbController.GetEntry(Convert.ToInt32(txt_id.Text));
                DbController.DeleteEntry(modifyApp);

                (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Close();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
            }
        }

        private void pic_screenshot1_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.setSaveTo("screenshot1");
            search.Show();
            search.Search(txt_name.Text + " screenshot");
        }

        private void pic_screenshot2_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.setSaveTo("screenshot2");
            search.Show();
            search.Search(txt_name.Text + " screenshot");
        }

        private void pic_screenshot3_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.setSaveTo("screenshot3");
            search.Show();
            search.Search(txt_name.Text + " screenshot");
        }

        private void pic_image_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.setSaveTo("image");
            search.Show();
            search.Search(txt_name.Text + " cover");
        }
    }
}
