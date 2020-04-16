using Google.Apis.YouTube.v3.Data;
using Microsoft.Win32;
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
        int picturesMaxHeight = 500;
        bool quickMode = true;
        bool isGroupingEnabled = true;
        string GroupingType = "DRIVE";
        string selectedItem = "";

        DbModel model = new DbModel();
        Settings userSettings;

        public Form1()
        {
            InitializeComponent();

            SetWebBrowserFeatures();
        }

        public void setVideo(SearchResult searchResult)
        {
            //System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=chancho");
            webBrowser1.Navigate("https://www.youtube.com/embed/" + searchResult.Id.VideoId + "?autoplay=1&mute=1&iv_load_policy=3&fs=0&modestbranding=1&controls=0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ShortcutsController.RefreshFolders();

            //DbController.DeleteEntries();
            //refreshFolder();

            //foreach (var item in DbController.GetEntries())
            //{
            //    if (item.Category == null) { item.Category = ""; DbController.ModifyEntry(item); }
            //}

            if (model.Settings.Count() < 1)
            {
                model.Settings.Add(new Settings() { Id = 1, OrderType = 1, ImagesSize = 50 });
                model.SaveChanges();
            }

            userSettings = model.Settings.Single(x => x.Id == 1);
            trackBar1.Value = userSettings.ImagesSize;
            trackBar1_Scroll(null, null);

            ShowAppEntries();

            pic_rightpanel_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_rightpanel_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_rightpanel_3.SizeMode = PictureBoxSizeMode.StretchImage;

            webBrowser1.DocumentText = "<html><body style='background-color:black;'></body></html>";
        }

        public void ShowAppEntries()
        {
            flowLayoutPanel1.Controls.Clear();
            List<AppEntry> appList = DbController.GetEntries();

            string lastGroup = "";

            //ORDER
            if (isGroupingEnabled)
            {
                switch (GroupingType)
                {
                    case "CATEGORY":
                        appList = appList.OrderBy(x => x.Category).ThenBy(x => x.Name).ToList();
                        break;
                    case "DRIVE":
                        appList = appList.OrderBy(x => x.Path.Substring(0, 1)).ThenBy(x => x.Name).ToList();
                        break;
                }
            }
            else
            {
                appList = appList.OrderBy(x => x.Name).ToList();
            }

            foreach (var item in appList)
            {
                if (!isGroupingEnabled)
                {
                    ShowEntry_v2(item);
                }

                if (isGroupingEnabled && GroupingType == "CATEGORY")
                {
                    if (item.Category != lastGroup) { setFlowBreak(item.Category); }
                    ShowEntry_v2(item);

                    lastGroup = item.Category;
                }

                if (isGroupingEnabled && GroupingType == "DRIVE")
                {
                    string currentDrive = item.Path.Substring(0, 1);

                    if (currentDrive != lastGroup) { setFlowBreak(currentDrive); }
                    ShowEntry_v2(item);

                    lastGroup = currentDrive;
                }
            }
        }

        private void setFlowBreak(string newCategory)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.SetFlowBreak(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1], true);
                flowLayoutPanel1.SetFlowBreak(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1], true);
            }

            if (!String.IsNullOrEmpty(newCategory))
            {
                Label lbl = new Label();
                lbl.Name = "lbl_cat_" + newCategory;
                lbl.Text = newCategory;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font(FontFamily.GenericSansSerif, 25, FontStyle.Bold);
                lbl.Height = 40;

                flowLayoutPanel1.Controls.Add(lbl);
            }

        }

        public void ShowEntry_v2(AppEntry appEntry)
        {
            PictureBox pic = new PictureBox();
            pic.Name = "pb_" + appEntry.Id.ToString();

            pic.Image = Tools.GetImageFromByte(appEntry.Image2);

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Height = picturesHeight;

            double ar = (double)pic.Image.Width / (double)pic.Image.Height;
            pic.Width = (int)Math.Round(pic.Height * ar);

            pic.Cursor = Cursors.Hand;
            pic.Click += Pic_Click;

            //check files are ok
            bool filesOk = File.Exists(appEntry.Path);
            if (!filesOk) { pic.BackColor = Color.Red; }

            flowLayoutPanel1.Controls.Add(pic);

            pic.MouseEnter += Pic_MouseHover;
        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            foreach (var item in (sender as PictureBox).Parent.Controls.OfType<PictureBox>().Where(x => x.BorderStyle != BorderStyle.None && x.Name != selectedItem))
            {
                item.BorderStyle = BorderStyle.None;
            }

            (sender as PictureBox).BorderStyle = BorderStyle.FixedSingle;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (selectedItem == (sender as PictureBox).Name && me.Button == MouseButtons.Left) { return; }

            PictureBox tmpPictureBox = (PictureBox)sender;
            int entryId = Convert.ToInt32(tmpPictureBox.Name.Replace("pb_", ""));
            AppEntry entry = DbController.GetEntry(entryId);

            selectedItem = tmpPictureBox.Name;
            cmd_play.Visible = true;
            (sender as PictureBox).BorderStyle = BorderStyle.Fixed3D;

            foreach (var item in (sender as PictureBox).Parent.Controls.OfType<PictureBox>().Where(x => x.BorderStyle != BorderStyle.None && x.Name != selectedItem))
            {
                item.BorderStyle = BorderStyle.None;
            }

            lbl_status.Text = entry.Path;

            if (me.Button == MouseButtons.Right)
            {
                Form[] formsList = Application.OpenForms.OfType<AppEntryDetailsForm>().Cast<Form>().ToArray();
                foreach (Form openForm in formsList)
                {
                    openForm.Close();
                }

                AppEntryDetailsForm entryDetailsForm = new AppEntryDetailsForm();
                entryDetailsForm.Show();
                entryDetailsForm.InitializeValuesFromEntry(entry);
            }
            else
            {
                fill_RightPanel(entry);
            }
        }

        public void ResizeEntries(int newHeight)
        {
            foreach (var item in flowLayoutPanel1.Controls.OfType<PictureBox>())
            {
                PictureBox tmpPic = (PictureBox)item;
                tmpPic.Height = newHeight;
                double ar = (double)tmpPic.Image.Width / (double)tmpPic.Image.Height;
                tmpPic.Width = (int)Math.Round(tmpPic.Height * ar);
            }
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files3 = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (quickMode && files3 != null)
            {
                foreach (var item in files3)
                {
                    ShortcutInfo sInfo = new ShortcutInfo();
                    sInfo = ShortcutsController.GetShortcutInfo(item);

                    if (!sInfo.isError)
                    {
                        if (model.AppEntries.Count(x => x.Path == sInfo.Path) > 0) { continue; }
                        var results = ImagesProvider.googleSearch(sInfo.Name + " cover");

                        AppEntry newEntry = new AppEntry();
                        newEntry.Name = sInfo.Name;
                        newEntry.Path = sInfo.Path;
                        newEntry.Image2 = Tools.GetByteFromUrl(results[0].Link);

                        DbController.AddEntry(newEntry);
                    }
                }

                ShowAppEntries();
            }

            if (!quickMode && files3 != null)
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
            picturesHeight = (int)currentValue * picturesMaxHeight / 50;

            model.Settings.Single(x => x.Id == 1).ImagesSize = currentValue;
            model.SaveChanges();
        }

        private void fill_RightPanel(AppEntry entry)
        {
            lbl_rightpanel_title.Text = entry.Name;

            webBrowser1.DocumentText = "<html><body style='background-color:black;'></body></html>";
            new YoutubeProvider().Run(entry.Name + " review");

            if (entry.Screenshot1 == null && entry.Screenshot2 == null & entry.Screenshot3 == null)
            {
                var results = ImagesProvider.googleSearch(entry.Name + " screenshot");

                entry.Screenshot1 = Tools.GetByteFromUrl(results[0].Link);
                entry.Screenshot2 = Tools.GetByteFromUrl(results[1].Link);
                entry.Screenshot3 = Tools.GetByteFromUrl(results[2].Link);

                DbController.ModifyEntry(entry);
            }

            if (entry.Screenshot1 != null) { pic_rightpanel_1.Image = Tools.GetImageFromByte(entry.Screenshot1); }
            if (entry.Screenshot2 != null) { pic_rightpanel_2.Image = Tools.GetImageFromByte(entry.Screenshot2); }
            if (entry.Screenshot3 != null) { pic_rightpanel_3.Image = Tools.GetImageFromByte(entry.Screenshot3); }

        }

        private void pic_rightpanel_1_Click(object sender, EventArgs e)
        {
            Form[] formsList = Application.OpenForms.OfType<ImagePreviewWindow>().Cast<Form>().ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }

            ImagePreviewWindow ipw = new ImagePreviewWindow();
            ipw.Show();
            PictureBox pb = (PictureBox)sender;
            ipw.setPreviewPicture(pb.Image);
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            int width = panel2.Width;

            if (width == 500) { panel2.Width = 10; }
            if (width == 10) { panel2.Width = 500; }
        }

        public void refreshFolder()
        {
            foreach (var item in DbController.GetEntries())
            {
                bool stillExist = File.Exists(item.Path);
                if (!stillExist) { DbController.DeleteEntry(item); }
            }
        }

        private void leftPanel_DoubleClick(object sender, EventArgs e)
        {
            int width = leftPanel.Width;

            if (width == 150) { leftPanel.Width = 10; }
            if (width == 10) { leftPanel.Width = 150; }
        }

        private void rd_group_categories_CheckedChanged(object sender, EventArgs e)
        {
            isGroupingEnabled = true;
            GroupingType = "CATEGORY";

            ShowAppEntries();
        }

        private void rd_group_drives_CheckedChanged(object sender, EventArgs e)
        {
            isGroupingEnabled = true;
            GroupingType = "DRIVE";

            ShowAppEntries();
        }

        private void rd_group_none_CheckedChanged(object sender, EventArgs e)
        {
            isGroupingEnabled = false;

            ShowAppEntries();
        }

        private void leftPanel_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Dock == DockStyle.Fill)
            {
                webBrowser1.Parent = panel2;
                webBrowser1.Dock = DockStyle.None;
            } else
            {
                webBrowser1.Parent = webBrowser1.TopLevelControl;
                webBrowser1.BringToFront();
                webBrowser1.Dock = DockStyle.Fill;
            }

        }

        static void SetWebBrowserFeatures()
        {
            // don't change the registry if running in-proc inside Visual Studio
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime) { return; }

            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var featureControlRegKey = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\";

            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION", appName, GetBrowserEmulationMode(), RegistryValueKind.DWord);

            // enable the features which are "On" for the full Internet Explorer browser
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", appName, 1, RegistryValueKind.DWord);
            Registry.SetValue(featureControlRegKey + "FEATURE_AJAX_CONNECTIONEVENTS", appName, 1, RegistryValueKind.DWord);
            Registry.SetValue(featureControlRegKey + "FEATURE_GPU_RENDERING", appName, 1, RegistryValueKind.DWord);
            Registry.SetValue(featureControlRegKey + "FEATURE_WEBOC_DOCUMENT_ZOOM", appName, 1, RegistryValueKind.DWord);
            Registry.SetValue(featureControlRegKey + "FEATURE_NINPUT_LEGACYMODE", appName, 0, RegistryValueKind.DWord);
        }

        static UInt32 GetBrowserEmulationMode()
        {
            int browserVersion = 0;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.QueryValues))
            {
                var version = ieKey.GetValue("svcVersion");
                if (null == version)
                {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }

            if (browserVersion < 7)
            {
                throw new ApplicationException("Unsupported version of Microsoft Internet Explorer!");
            }

            UInt32 mode = 11000; // Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode. 

            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. 
                    break;
                case 8:
                    mode = 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. 
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.                    
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10.
                    break;
            }

            return mode;
        }

        private void cmd_play_Click(object sender, EventArgs e)
        {
            var currentSelection = selectedItem.Replace("pb_", "");
            var entry = DbController.GetEntry(Convert.ToInt32(currentSelection));

            webBrowser1.DocumentText = "<html><body style='background-color:black;'></body></html>";

            try
            {
                System.Diagnostics.Process.Start(entry.Path);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmd_play_MouseEnter(object sender, EventArgs e)
        {
            cmd_play.Image = nLauncher.Properties.Resources.play_button_red;
        }

        private void cmd_play_MouseLeave(object sender, EventArgs e)
        {
            cmd_play.Image = nLauncher.Properties.Resources.play_button;
        }
    }
}
