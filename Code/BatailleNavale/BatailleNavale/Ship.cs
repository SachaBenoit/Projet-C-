using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Ship
    {
        private string name = "";
        private int size = 0;
        private IDictionary<string, bool> positions; //représente les positions d'un bateau (A1, A2) ainsi que leur état (touché ou pas)
        private Orientation _orientation;
        private bool placed = false; //un bateau a-t-il été placé ?

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public Orientation orientation
        {
            get
            {
                return _orientation;
            }
        }
            

        public Ship(string name, int size, Orientation orientation = Orientation.Vertical)
        {
            this.name = name;
            this.size = size;
            this._orientation = orientation;
          

            positions = new Dictionary<string, bool>();
        }

        /// <summary>
        /// Check if the ship is available
        /// </summary>
        /// <returns></returns>
        public bool Alive()
        {
            foreach (KeyValuePair<string, bool> part in positions)
            {
                if (part.Value) // si une partie du bateau n'a pas encore été touché il est encore en vie
                {
                    return true;
                }
            }

            return false; //toutes les parties du bateau ont été touché
        }

        /// <summary>
        /// Get the positions of a ship, only available parts are return
        /// </summary>
        /// <returns></returns>
        public List<string> Getpositions()
        {
            List<string> positions = new List<string>();

            foreach (KeyValuePair<string, bool> part in this.positions)
            {
                if (part.Value) // si une partie du bateau n'a pas encore été touché il est encore en vie
                {
                    positions.Add(part.Key);
                }
            }

            return positions;
        }

        /// <summary>
        /// Set the position of a ship
        /// </summary>
        /// <param name="origin"></param>
        public void SetPosition(string origin)
        {
            char vOrigin = 'A';
            int hOrigin = 1;
            string position = vOrigin.ToString() + hOrigin;

            positions.Clear();

            positions.Add(origin, true); //ajoute la position d'origine

            try
            {
                vOrigin = System.Convert.ToChar(origin.Substring(0, 1));
                hOrigin = System.Convert.ToInt32(origin.Substring(1, 1));
            }
            catch (Exception e)
            {
                Console.WriteLine("Attention cette exception est apparue : " + e);
                vOrigin = 'A';
                hOrigin = 1;
            }
            
            //ajoutes les autres positioons du bateau
            for(int i = 1; i < size; i++)
            {
                if(_orientation == Orientation.Vertical)
                {
                    hOrigin++;  
                }
                else
                {
                    vOrigin++;
                }
                position = vOrigin.ToString() + hOrigin.ToString();
                positions.Add(position, true);
            }

            placed = true;

        }

        /// <summary>
        /// Set the orientation of the ship
        /// </summary>
        /// <param name="orientation"></param>
        public void SetOrientation(Orientation orientation)
        {
            this._orientation = orientation;
        }



        

    }
}
