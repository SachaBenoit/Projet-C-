using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BatailleNavale
{
    public partial class Form1 : Form
    {
        private bool gameStarted = false;

        List<Player> players = new List<Player>();
   

        Player player2 = new Player("benoit", "192.168.0.1");
        Player player = new Player("robot", "192.168.0.2");
        Grid grid1;


        int gridTop = 50;
        int gridLeft = 50;

        bool ShipHit = false;



        private FormMenu menuFrom;


        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            players.Add(player);
            players.Add(player2);

            grid1 = new Grid(player2, 50, 6, gridTop, gridLeft);

            grid1.MouseClick += new MouseEventHandler(ClickOnPictureBox);


           
            this.Hide();
            menuFrom = new FormMenu();
            menuFrom.Show();

           

            this.Controls.Add(grid1);

            Ship ship = new Ship("Fregate", 2, Orientation.Horizontal);
            Ship ship2 = new Ship("porte-avion", 3, Orientation.Horizontal);
            Ship ship3 = new Ship("Fregate", 2, Orientation.Horizontal);

            player.AddShip(ship);
            player.AddShip(ship2);
            player.AddShip(ship3);

            foreach(Ship playerShip in player.Ships)
            {
                lstPlayerShip.Items.Add(playerShip.Name + " " + playerShip.Size + " cases");
            }




            Timer timer = new Timer();
            timer.Interval = (1); // every 1 millesecond
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


        }

        public void ClickOnPictureBox(object sender, MouseEventArgs e)
        {
            PictureBox pbx = sender as PictureBox;

      
            Point mouse_position = new Point(); // position de la souris par rapport à la grille
            mouse_position.X = e.X;
            mouse_position.Y = e.Y;

            int pictureBox_top = pbx.Top;
            int pictureBox_left = pbx.Left;
            int pictureBox_bottom = pbx.Bottom;
            int pictureBox_right = pbx.Right;

            int pictureBox_width = pictureBox_bottom - pictureBox_top;
            int pictureBox_height = pictureBox_right - pictureBox_left;

            int nbCells_x = pictureBox_width / grid1.CellSize;
            int nbCells_y = pictureBox_height / grid1.CellSize;


            //décompose la grille pour la mettre sous forme de cellule (A1, D4)
            for (int i = 0, ii = 0; i < pictureBox_width; i += grid1.CellSize, ii++)
            {
                if (mouse_position.X >= i && mouse_position.X <= i + grid1.CellSize)
                {
                    grid1.HorizontalPosition = (char)(ii + 65);

                    for (int j = 0, jj = 1; j < pictureBox_height; j += grid1.CellSize, jj++)
                    {
                        if (mouse_position.Y >= j && mouse_position.Y <= j + grid1.CellSize)
                        {
                            grid1.VerticalPosition = jj;
                        }
                    }
                }
            }

            //position du joueur
            grid1.LastPosition = grid1.HorizontalPosition.ToString() + grid1.VerticalPosition;

            if (gameStarted)
            {
                Point point = new Point();
                point = grid1.cellToPositions(grid1.LastPosition);
                if (player2.Shoot(player, grid1.LastPosition))
                {
                    Target target = new Target(point.X, point.Y, grid1.CellSize , grid1.CellSize, true);
                    this.Controls.Add(target);
                    target.BringToFront();

                }
                else
                {
                    Target target = new Target(point.X, point.Y, grid1.CellSize, grid1.CellSize, false);
                    this.Controls.Add(target);
                    target.BringToFront();
                }
            }
            else
            {
                grid1.PlaceShip(player.Ships[lstPlayerShip.SelectedIndex]);
            }

        
            

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// A chaque changement d'index de la listBox des bateaux, attribut ce bateau à la grille comme étant le dernier bateau sélcectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPlayerShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblOrientation.Text = "Orientation du bateau : " + player.Ships[lstPlayerShip.SelectedIndex].Orientation;
                Console.WriteLine(lstPlayerShip.SelectedIndex);
            }
            catch(Exception exc)
            {
                Console.WriteLine("erreur : " + exc);
            }
        }

        private void cmdSetOrientation_Click(object sender, EventArgs e)
        {
            try
            {
                player.Ships[lstPlayerShip.SelectedIndex].SetOrientation();
                lblOrientation.Text = "Orientation du bateau : " + player.Ships[lstPlayerShip.SelectedIndex].Orientation;
            }
            catch
            {
                MessageBox.Show("Aucun Bateau sélectionné");
            }
           
        }

        private void cmdReady_Click(object sender, EventArgs e)
        {
            grid1.CleanGrid();
            gameStarted = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuFrom = new FormMenu();
            menuFrom.Show();
        }


    }
}
