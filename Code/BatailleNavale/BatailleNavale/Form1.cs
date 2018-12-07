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
<<<<<<< HEAD
        Grid grid1 = new Grid(50, 6, 50, 100);
        Player player = new Player("benoit", "192.168.0.1");
=======
        private FormMenu menuFrom;
>>>>>>> sacha

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======

            menuFrom = new FormMenu();
            menuFrom.Show();
            
            /*
            Grid grid1 = new Grid(50, 6, 50, 100);
            this.Controls.Add(grid1);
            grid1.Click += grid1.ClickOnPictureBox;
>>>>>>> sacha
            
            this.Controls.Add(grid1);

           

            Ship ship = new Ship("porte-avion", 2, Orientation.Horizontal);
            Ship ship2 = new Ship("porte-avion", 3, Orientation.Horizontal);

            player.AddShip(ship);
            player.AddShip(ship2);

            foreach(Ship playerShip in player.Ships)
            {
                lstPlayerShip.Items.Add(playerShip.Name + " " + playerShip.Size + " cases");
            }
<<<<<<< HEAD

            Timer timer = new Timer();
            timer.Interval = (1); // every 1 millesecond
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
=======
            */


>>>>>>> sacha
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void lstPlayerShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid1.SelectedShip = player.Ships[lstPlayerShip.SelectedIndex];
            Console.WriteLine(lstPlayerShip.SelectedIndex);
        }
    }
}
