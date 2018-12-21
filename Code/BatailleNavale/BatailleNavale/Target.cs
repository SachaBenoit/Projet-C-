using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BatailleNavale
{
    class Target : PictureBox
    {

        private Bitmap path;

        public Target(int x, int y, int width, int height, bool hited)
        {
            if(hited)
            {
                path = BatailleNavale.Properties.Resources.Bombe;
            }
            else
            {
                path = BatailleNavale.Properties.Resources.Croix;
            }

            this.Left = x;
            this.Top = y;
            this.Width = width;
            this.Height = height;

            Bitmap bitmap = new Bitmap(path);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Image = (Image)bitmap;
           

        }
    }
}
