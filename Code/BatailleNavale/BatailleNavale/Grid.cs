using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BatailleNavale
{
    class Grid
    {
        private int cellSize; //size of a cell
        private int nbCells; //nb cells for each side
        private int position_top; //top position of the grid (px)
        private int position_left;//left position of the grid (px)
        PictureBox pictureBox = new PictureBox();


        public Grid(int cellSize, int nbCells , int position_top = 0, int position_left = 0)
        {
            this.cellSize = cellSize;
            this.nbCells = nbCells;
            this.position_top = position_top;
            this.position_left = position_left;
        }

        public PictureBox CreatePicture()
        {
            int pictureBox_top = 200;
            int pictureBox_left = 100;

            pictureBox.Size = new Size(cellSize * nbCells, cellSize * nbCells);
            pictureBox.Top = pictureBox_top;
            pictureBox.Left = pictureBox_left;

            Bitmap flag = new Bitmap(cellSize * nbCells, cellSize * nbCells);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.White, 0, 0, cellSize * nbCells, cellSize * nbCells);
            pictureBox.Image = flag;

            return pictureBox;   
        }


        public void ClickOnPictureBox()
        {
            PictureBox pbx = sender as PictureBox;


            int pictureBox_top = pbx.Top;
            int pictureBox_left = pbx.Left;
            int pictureBox_bottom = pbx.Bottom;
            int pictureBox_right = pbx.Right;

            int pictureBox_width = pictureBox_bottom - pictureBox_top;
            int pictureBox_height = pictureBox_right - pictureBox_left;

            int nbCells_x = pictureBox_width / cellSize;
            int nbCells_y = pictureBox_height / cellSize;

            var mouse_position = this.PointToClient(Cursor.Position);

            mouse_position.X -= pictureBox_left;
            mouse_position.Y -= pictureBox_top;

            Console.WriteLine("nb Cells x : " + nbCells_x);
            Console.WriteLine("nb Cells y : " + nbCells_y);

            Console.WriteLine("size x : " + pictureBox_width);
            Console.WriteLine("size y : " + pictureBox_height);

            Console.WriteLine("pos x : " + mouse_position.X);
            Console.WriteLine("pos y : " + mouse_position.Y);

            for (int i = 0, ii = 0; i < pictureBox_width; i += cellSize, ii++)
            {
                if (mouse_position.X >= i && mouse_position.X <= i + cellSize)
                {
                    horizontalPosition = (char)(ii + 65);

                    for (int j = 0, jj = 1; j < pictureBox_height; j += cellSize, jj++)
                    {
                        if (mouse_position.Y >= j && mouse_position.Y <= j + cellSize)
                        {
                            verticalPosition = jj;
                        }
                    }
                }
            }

            Console.WriteLine("La position de la souris est : " + horizontalPosition + verticalPosition);
        }



    }
}
