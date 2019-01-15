using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public class Ship
    {
        private string name = "";
        private int size = 0;
        private IDictionary<string, bool> positions; //représente les positions d'un bateau (A1, A2) ainsi que leur état (touché ou pas)
        private Orientation orientation;
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

        public Orientation Orientation
        {
            get
            {
                return orientation;
            }
        }

        public IDictionary<string,bool> Positions
        {
            get
            {
                return positions;
            }
        }

        public bool Placed
        {
            get
            {
                return placed;
            }
        }
        

        public Ship(string name, int size, Orientation orientation = Orientation.Vertical)
        {
            this.name = name;
            this.size = size;
            this.orientation = orientation;
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
                if (part.Value) // si une au moins une cellule du bateau n'a pas été touchée, le bateau est en vie
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
        /// Assigne des positions pour le bateau
        /// </summary>
        /// <param name="origin"></param>
        public void SetPosition(string origin, int maxCells)
        {
            char vOrigin = 'A';
            int hOrigin = 1;
            string position = vOrigin.ToString() + hOrigin;

            positions.Clear(); // met ou remet à zero les positions du bateau

            positions.Add(origin, true); //ajoute la position d'origine

            try
            {
                vOrigin = System.Convert.ToChar(origin.Substring(0, 1));


                hOrigin = System.Convert.ToInt32(origin.Substring(1, origin.Length - 1));
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
                if(orientation == Orientation.Vertical)
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

            //si le bateau est placé en dehors des limites : remet à zero sa position
            if(vOrigin > maxCells+64 || hOrigin > maxCells)
            {
                positions.Clear();
                Console.WriteLine("Position du bateau non valide");
                placed = false;
            }
            else
            {
                placed = true;
                Console.WriteLine("le bateau a correctement été placé");
            }

        }

        /// <summary>
        /// Inverse l'orientation actuel du bateau
        /// </summary>
        /// <param name="orientation"></param>
        public void SetOrientation()
        {
            this.orientation = (Orientation)(((int)this.orientation + 1) % 2);
        }



        

    }
}
