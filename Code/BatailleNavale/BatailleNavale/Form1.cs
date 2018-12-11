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
        Grid grid1 = new Grid(50, 6, 50, 100);
        Player player = new Player("benoit", "192.168.0.1");
        private FormMenu menuFrom;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            menuFrom = new FormMenu();
            menuFrom.Show();
           
            /*
            this.Controls.Add(grid1);

           

            Ship ship = new Ship("porte-avion", 2, Orientation.Horizontal);
            Ship ship2 = new Ship("porte-avion", 3, Orientation.Horizontal);

            player.AddShip(ship);
            player.AddShip(ship2);

            foreach(Ship playerShip in player.Ships)
            {
                lstPlayerShip.Items.Add(playerShip.Name + " " + playerShip.Size + " cases");
            }

            Timer timer = new Timer();
            timer.Interval = (1); // every 1 millesecond
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            */

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void lstPlayerShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid1.SelectedShip = player.Ships[lstPlayerShip.SelectedIndex];
            Console.WriteLine(lstPlayerShip.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuFrom = new FormMenu();
            menuFrom.Show();
        }
    }
}
