/*
 * 
 * Classe représantant un joueur 
 * 25.01.2019
 * Meylan Benoit & Usan Sacha
 * 
 */

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


        /// <summary>
        /// Ce produit lorsque un joueur à cliquer sur une case de la grille, si un bateau ce trouve dessous c'est une touche sinon c'est un raté
        /// </summary>
        /// <param name="targetPlayer"></param>
        /// <param name="targetPosition"></param>
        /// <returns></returns>
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
                                MessageBox.Show("Bravo, Vous avez gagné !");

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

        /// <summary>
        /// Ajoute le bateau entré en paramêtre à la liste des bateaux du joueur
        /// </summary>
        /// <param name="ship"></param>
        public void AddShip(Ship ship)
        {
            ships.Add(ship);
            this.nbShipsAlive++;
        }

  


    }
}
