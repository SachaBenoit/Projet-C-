using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BatailleNavale
{
    public class Grid : PictureBox
    {
        private int cellSize; //size of a cell
        private int nbCells; //nb cells for each side
        private int position_top; //top position of the grid (px)
        private int position_left;//left position of the grid (px)
    
        private int verticalPosition = 1;
        private char horizontalPosition = 'A';
        private Player gridPlayer;

        List<Ship> placedShips = new List<Ship>();

        Bitmap flag;
       


        string lastPosition = "";

        public int CellSize
        {
            get
            {
                return cellSize;
            }
        }

        public int NbCells
        {
            get
            {
                return nbCells;
            }
        }

        public int VerticalPosition
        {
            get
            {
                return verticalPosition;
            }
            set
            {
                verticalPosition = value;
            }
        }


        public char HorizontalPosition
        {
            get
            {
                return horizontalPosition;
            }
            set
            {
                horizontalPosition = value;
            }
        }



        public Point GridPosition
        {
            get
            {
                Point p = new Point();
                p.X = position_top;
                p.Y = position_left;
                return p;
            }
        }


        public string LastPosition
        {
            get
            {
                return lastPosition;
            }
            set
            {
                lastPosition = value;
            }
        }


        public Grid(Player gridPlayer, int cellSize, int nbCells , int position_top = 0, int position_left = 0)
        {
            this.gridPlayer = gridPlayer;
            this.cellSize = cellSize;
            this.nbCells = nbCells;
            this.position_top = position_top;
            this.position_left = position_left;

            flag = new Bitmap(cellSize * nbCells, cellSize * nbCells);
            

            CreatePicture();

           
        }

        private PictureBox CreatePicture()
        {
            int pictureBox_top = position_top;
            int pictureBox_left = position_left;


            this.Size = new Size(cellSize * nbCells, cellSize * nbCells);
            this.Top = pictureBox_top;
            this.Left = pictureBox_left;

            Draw();

            return this;   
        }


        public void PlayPhase()
        {
            
        }

        public void PlacementPhase(Ship shipToPlace)
        {
            try
            {
                shipToPlace.SetPosition(lastPosition, nbCells);

                MessageBox.Show(lastPosition);
                Console.WriteLine("Coordonnées du bateau : ");
                foreach (string position in shipToPlace.Getpositions())
                {
                    Console.WriteLine(position);
                }
            }
            catch
            {
                MessageBox.Show("Aucun bateau sélectionné");
            }

            try
            {
                if (shipToPlace.Placed)
                {
                    if (!placedShips.Contains(shipToPlace))
                    {
                        placedShips.Add(shipToPlace);
                    }

                    Draw();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exception : " + exc);
            }
        }


        private void Draw()
        {

            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.LightBlue, 0, 0, cellSize * nbCells, cellSize * nbCells);


            for (int i = 0; i <= nbCells * cellSize; i += cellSize)
            {
                flagGraphics.FillRectangle(Brushes.Black, 0, i, cellSize * nbCells, 1);
                flagGraphics.FillRectangle(Brushes.Black, i, 0, 1, cellSize * nbCells);
            }


            foreach (Ship ship in placedShips)
            {
                Point origin = cellToPositions(ship.Getpositions()[0], ship);

                int shipWidth = 0;
                int shipHeight = 0;

                if (ship.Orientation == Orientation.Horizontal)
                {
                    shipHeight = cellSize / 3;
                    shipWidth = ship.Size * cellSize - 3;
                }
                else
                {
                    shipWidth = cellSize / 3;
                    shipHeight = ship.Size * cellSize - 3;
                }

              
                flagGraphics.FillRectangle(Brushes.Gray, origin.X, origin.Y, shipWidth, shipHeight);
            }

            this.Image = flag;
        }

        private Point cellToPositions(string cell, Ship ship)
        {
            Point point = new Point();
            int hPos = System.Convert.ToChar(cell.Substring(0, 1)) - 64;
            int vPos = System.Convert.ToInt32(cell.Substring(1, 1));


            if(ship.Orientation == Orientation.Horizontal)
            {
                point.X = (hPos - 1) * cellSize + 2;
                point.Y = (vPos - 1) * cellSize + cellSize / 3;
            }
            else
            {
                point.Y = (vPos - 1) * cellSize + 2;
                point.X = (hPos - 1) * cellSize +  cellSize / 3;
            }

            return point;
        }

       

       

    }
}
