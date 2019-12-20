using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation
{
    public class Morpion
    {
        string[,] plateau;
        string joueur;
        internal string gagnant;

        public Morpion()
        {
            plateau = new string[3, 3];
        }

        public void Commencer()
        {
            for(int i = 0; i < 9; i++)
            {
                joueur = i % 2 == 0 ? "X" : "O";
                int[] coordonnees = null;

                while(coordonnees ==null)
                {
                    coordonnees = GetCoup();
                }

                JouerCoup(coordonnees);

                PrintPlateau();

                gagnant = checkWinner();
                if(gagnant != null)
                    break;
            }

            if (gagnant != null)
                Console.WriteLine("Le gagnant est : {0}", gagnant);
            else
                Console.WriteLine("Pas de gagnant");

            Console.ReadKey();
        }

        public int[] GetCoup()
        {
            int x, y;
            Console.WriteLine("Joueur {0} rentrez votre coup (nbLigne, nbColonne) : ", joueur);
            string coup = GetUserInput();
            string[] points = coup.Split(',');

            if (points.Length != 2)
                return null;
            if (!int.TryParse(points[0].Trim(), out x))
                return null;
            if (!int.TryParse(points[1].Trim(), out y))
                return null;

            return new int[] { x, y };
        }

        public virtual string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void JouerCoup(int[] points)
        {
            plateau[points[0] -1, points[1] -1] = joueur;
        }

        public void PrintPlateau()
        {
            Console.Clear();
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write("[{0}]", plateau[i, j]);
                }
                Console.Write("\n");
            }
        }

        public string checkWinner()
        {
            for(int i = 0; i < 3; i++)
            {
                if(plateau[i, 0].Equals(plateau[i, 1]) && 
                    plateau[i, 0].Equals(plateau[i, 2]) && 
                    plateau[i, 0] != null) return plateau[i, 0];

                if(plateau[0, i].Equals(plateau[1, i]) && 
                    plateau[0, i].Equals(plateau[2, i]) && 
                    plateau[0, i] != null) return plateau[0, i]; 
            }
            return null;
        }
    }
}
