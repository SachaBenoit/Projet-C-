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
        private FormMenu menuFrom;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            menuFrom = new FormMenu();
            menuFrom.Show();
            
            /*
            Grid grid1 = new Grid(50, 6, 50, 100);
            this.Controls.Add(grid1);
            grid1.Click += grid1.ClickOnPictureBox;
            

            Timer timer = new Timer();
            timer.Interval = (1); // every 1 millesecond
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


            Ship ship1 = new Ship("Batavia", 5, Orientation.Vertical);
            ship1.SetPosition("C2");
            List<string> l1 = new List<string>(); 
                
            l1 = ship1.Getpositions();

            foreach(string pos in l1)
            {
                Console.WriteLine(pos);
            }
            */


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        
    }
}
