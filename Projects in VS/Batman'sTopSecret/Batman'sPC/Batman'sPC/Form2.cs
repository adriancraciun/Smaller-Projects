using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batman_sPC
{
    public partial class Batman : Form
    {
        public Batman()
        {
            InitializeComponent();

            BatmanGifPictureBox.Bounds = Screen.PrimaryScreen.Bounds;
            BatmanGifPictureBox.Image = Properties.Resources.BatmanGif;
        }
    }
}
