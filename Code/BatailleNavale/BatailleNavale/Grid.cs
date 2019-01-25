/*
 * 
 * Classe représentant une grille, héritée de la classe PictureBox
 * 25.01.2019
 * Meylan Benoit & Usan Sacha
 * 
 */
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


        /// <summary>
        /// Constructeur pour la classe Grid
        /// </summary>
        /// <param name="gridPlayer"></param>
        /// <param name="cellSize">taille d'une cellule (largeur et hauteur)</param>
        /// <param name="nbCells">nombre de cellules verticalement et horizontalement</param>
        /// <param name="position_top">position Y du coin en haut à gauche de la grille</param>
        /// <param name="position_left">Position X du coin en haut à gauche de la grille</param>
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

        /// <summary>
        /// Créer une pictureBox
        /// </summary>
        /// <returns></returns>
        private PictureBox CreatePicture()
        {
            int pictureBox_top = position_top;
            int pictureBox_left = position_left;


            this.Size = new Size(cellSize * nbCells, cellSize * nbCells);
            this.Top = pictureBox_top;
            this.Left = pictureBox_left;


            DrawShips();

            return this;   
        }


        /// <summary>
        /// Placement d'un bateau par le joueur
        /// </summary>
        /// <param name="shipToPlace"></param>
        public void PlaceShip(Ship shipToPlace)
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

                    DrawShips();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exception : " + exc);
            }
        }

        /// <summary>
        /// retourne le point en haut a gauche de la cellule
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="ship"></param>
        /// <returns></returns>
        public Point cellToPositions(string cell)
        {
            Point point = new Point();
            int hPos = System.Convert.ToChar(cell.Substring(0, 1)) - 64;
            int vPos = System.Convert.ToInt32(cell.Substring(1, cell.Length - 1));

            point.X = CellSize * hPos + 1;
            point.Y = CellSize * vPos + 1;

            return point;
        }

        /// <summary>
        /// Efface ce qu'il y a de dessiner sur la grille 
        /// </summary>
        public void CleanGrid()
        {
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.LightBlue, 0, 0, cellSize * nbCells, cellSize * nbCells);


            for (int i = 0; i <= nbCells * cellSize; i += cellSize)
            {
                flagGraphics.FillRectangle(Brushes.Black, 0, i, cellSize * nbCells, 1);
                flagGraphics.FillRectangle(Brushes.Black, i, 0, 1, cellSize * nbCells);
            }

            this.Image = flag;

        }

        /// <summary>
        /// Efface puis redessine tous les bateaux
        /// </summary>
        private void DrawShips()
        {

            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.LightBlue, 0, 0, cellSize * nbCells, cellSize * nbCells);

            //dessiner la grille
            for (int i = 0; i <= nbCells * cellSize; i += cellSize)
            {
                flagGraphics.FillRectangle(Brushes.Black, 0, i, cellSize * nbCells, 1);
                flagGraphics.FillRectangle(Brushes.Black, i, 0, 1, cellSize * nbCells);
            }

            //dessiner les navires
            foreach (Ship ship in placedShips)
            {
                Point origin = new Point(); 

                int hPos = System.Convert.ToChar(ship.Getpositions()[0].Substring(0, 1)) - 64;
                //int vPos = System.Convert.ToInt32(ship.Getpositions()[0].Substring(1, 1));
                int vPos = System.Convert.ToInt32(ship.Getpositions()[0].Substring(1, ship.Getpositions()[0].Length - 1));


                int shipWidth = 0;
                int shipHeight = 0;

                
                if (ship.Orientation == Orientation.Horizontal)
                {
                    origin.X = (hPos - 1) * cellSize + 2;
                    origin.Y = (vPos - 1) * cellSize + cellSize / 3;

                    shipHeight = cellSize / 3;
                    shipWidth = ship.Size * cellSize - 3;
                }
                else
                {
                    origin.Y = (vPos - 1) * cellSize + 2;
                    origin.X = (hPos - 1) * cellSize + cellSize / 3;

                    shipWidth = cellSize / 3;
                    shipHeight = ship.Size * cellSize - 3;
                }

              
                flagGraphics.FillRectangle(Brushes.Gray, origin.X, origin.Y, shipWidth, shipHeight);
            }

            this.Image = flag;
        }



       

       

    }
}
