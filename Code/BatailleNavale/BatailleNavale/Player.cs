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
        private int nbShipsAlive = 0;
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
        public Player(string name)
        {
            this.name = name;
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

                            //retire un bateau du compteur
                            this.nbShipsAlive--;

                            //si tous les bateaux ont été détruits la partie est gagnée
                            if (nbShipsAlive == 0)
                            {
                                MessageBox.Show("Bravo, Vous avez gagné");
                            }


                        }
                        else // un bateau à été touché
                        {
                            Console.WriteLine("----- TOUCHÉ ! -----");
                        }

                        return true;
                    }

                }
            }

            //Aucun bateau n'a été touché
            Console.WriteLine("---- PLOUF ! À l'eau ! -----");
            return false;
        }

        //Ajoute le bateau entré en paramêtre à la liste des bateaux du joueur
        public void AddShip(Ship ship)
        {
            ships.Add(ship);
            this.nbShipsAlive++;
        }

  


    }
}
