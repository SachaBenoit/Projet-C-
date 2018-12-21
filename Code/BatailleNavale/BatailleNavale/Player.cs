using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatailleNavale
{
    public class Player
    {
        private string name;
        private string ipAddress;
        private bool ready = false;
        private List<Ship> ships;

        public bool Ready
        {
            get
            {
                return ready;
            }
        }

        public List<Ship> Ships
        {
            get
            {
                return ships;
            }
        }
        public Player(string name, string ipAddress)
        {
            this.name = name;
            this.ipAddress = ipAddress;
            this.ships = new List<Ship>();
        }

        public string GetName()
        {
            return name;
        }

        public bool Shoot(Player targetPlayer, string targetPosition)
        {
            foreach(Ship ship in targetPlayer.ships)
            {
                foreach(string position in ship.Positions.Keys)
                {
                    if(position == targetPosition)
                    {
                        ship.Positions[position] = false;
                        if (!ship.Alive())
                        {
                            Console.WriteLine("----- TOUCHÉ COULÉ ! -----");
                            MessageBox.Show("Touché coulé !");
                        }
                        else
                        {
                            Console.WriteLine("----- TOUCHÉ ! -----");
                        }

                        return true;
                    }

                }
            }
            Console.WriteLine("---- PLOUF ! -----");
            return false;
        }

        public void AddShip(Ship ship)
        {
            ships.Add(ship);
        }


    }
}
