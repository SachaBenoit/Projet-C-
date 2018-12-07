using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Player
    {
        private string name;
        private string ipAddress;
        private List<Ship> ships;

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

        public string Shoot(char hPos, int vPos)
        {
            return "touché";
        }

        public void AddShip(Ship ship)
        {
            ships.Add(ship);
        }


    }
}
