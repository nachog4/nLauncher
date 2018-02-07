using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLauncher
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {

        }

        public void AddSearchWindowEntry(string file)
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = file;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = 200;
            pic.Height = 200;

            flowLayoutPanel1.Controls.Add(pic);
        }
    }
}
