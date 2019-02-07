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
    public partial class ImagePreviewWindow : Form
    {
        public ImagePreviewWindow()
        {
            InitializeComponent();
        }

        public void setPreviewPicture(string pic)
        {
            pictureBox1.ImageLocation = pic;
            pictureBox1.Load();
        }

    }
}
