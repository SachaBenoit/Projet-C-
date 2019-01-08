using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace BatailleNavale
{
    public partial class FormPart : Form
    {
        private bool gameStarted = false;

        List<Player> players = new List<Player>();

        Player player = new Player(FormNewPart.NamePlayer, FormNewPart.LocalIP);
        Player player2 = new Player("robot", "192.168.0.2");

        Grid grid;

        public FormPart()
        {
            InitializeComponent();
        }

        private void FormPart_Load(object sender, EventArgs e)
        {
            players.Add(player);
            players.Add(player2);

            grid = new Grid(player, 50, FormNewPart.NbCells, 50, 50);

            grid.MouseClick += new MouseEventHandler(ClickOnPictureBox);



            this.Controls.Add(grid);

            /*
            Ship ship = new Ship("Fregate", 2, Orientation.Horizontal);
            Ship ship2 = new Ship("porte-avion", 3, Orientation.Horizontal);
            Ship ship3 = new Ship("Fregate", 2, Orientation.Horizontal);
            */

            player.AddShip(new Ship("Porte-avion", 5 , Orientation.Horizontal));
            player.AddShip(new Ship("Croiseur", 4 , Orientation.Horizontal));
            player.AddShip(new Ship("Contre-torpilleur", 3 , Orientation.Horizontal));
            player.AddShip(new Ship("Sous-marin", 3 , Orientation.Horizontal));
            player.AddShip(new Ship("Torpilleur", 2 , Orientation.Horizontal));

            /*
            player.AddShip(ship);
            player.AddShip(ship2);
            player.AddShip(ship3);
            */

            foreach (Ship playerShip in player.Ships)
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

            int nbCells_x = pictureBox_width / grid.CellSize;
            int nbCells_y = pictureBox_height / grid.CellSize;


            //décompose la grille pour la mettre sous forme de cellule (A1, D4)
            for (int i = 0, ii = 0; i < pictureBox_width; i += grid.CellSize, ii++)
            {
                if (mouse_position.X >= i && mouse_position.X <= i + grid.CellSize)
                {
                    grid.HorizontalPosition = (char)(ii + 65);

                    for (int j = 0, jj = 1; j < pictureBox_height; j += grid.CellSize, jj++)
                    {
                        if (mouse_position.Y >= j && mouse_position.Y <= j + grid.CellSize)
                        {
                            grid.VerticalPosition = jj;
                            break;
                        }
                    }
                }
                else continue;

                break;
            }

            //position du joueur
            grid.LastPosition = grid.HorizontalPosition.ToString() + grid.VerticalPosition;

            if (gameStarted)
            {
                Point point = new Point();
                point = grid.cellToPositions(grid.LastPosition);
                if (player2.Shoot(player, grid.LastPosition))
                {
                    Target target = new Target(point.X, point.Y, grid.CellSize, grid.CellSize, true);
                    this.Controls.Add(target);
                    target.BringToFront();

                }
                else
                {
                    Target target = new Target(point.X, point.Y, grid.CellSize, grid.CellSize, false);
                    this.Controls.Add(target);
                    target.BringToFront();
                }
            }
            else
            {
                grid.PlaceShip(player.Ships[lstPlayerShip.SelectedIndex]);
            }





        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }


        private void lstPlayerShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblOrientation.Text = "Orientation du bateau : " + player.Ships[lstPlayerShip.SelectedIndex].Orientation;
                Console.WriteLine(lstPlayerShip.SelectedIndex);
            }
            catch (Exception exc)
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
            gameStarted = true;

            grid.CleanGrid();

            Controls.Remove(cmdReady);

            CreateButtonSave();
        }

        private void CreateButtonSave()
        {
            Button button = new Button();

            button.Name = "cmdSavePart";
            button.Text = "Sauvegarder";
            button.Location = new Point(613, 415);

            button.Click += new EventHandler(cmdSavePart_Click);

            this.Controls.Add(button);
        }

        private void cmdSavePart_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();

                writer.WritePropertyName("Partname");
                writer.WriteValue(FormNewPart.NamePart);

                writer.WritePropertyName("Playername");
                writer.WriteValue(FormNewPart.NamePlayer);

                writer.WritePropertyName("Ships");
                writer.WriteStartArray();
                writer.WriteValue("1");
                writer.WriteValue("3");
                writer.WriteValue("A2");
                writer.WriteEnd();
                writer.WriteEndObject();
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"" + FormNewPart.NamePart + ".json");
            file.WriteLine(sb.ToString()); // "sb" is the StringBuilder
            file.Close();
        }
    }
}
