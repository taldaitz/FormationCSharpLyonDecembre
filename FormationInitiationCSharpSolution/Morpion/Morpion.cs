using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Morpion
    {

        public void commencer()
        {
            
            string[,] plateau = new string[3, 3];

            for (int tour = 0; tour < 9; tour++) {

                string joueur = (tour % 2 == 0) ? "X" : "O";

                Console.Clear();
                afficherPlateau(plateau);

                jouerCoup(ref plateau, joueur);

                string resultat = trouverGagnant(plateau);

                if (!String.IsNullOrEmpty(resultat))
                {
                    Console.Clear();
                    afficherPlateau(plateau);
                    Console.WriteLine("Félicitations, le joueur {0} a gagné !", resultat);
                    Console.WriteLine("toto");
                    break;
                }
            }
        }

        /// <summary>
        ///  Affichage du plateau d'un Morpion
        /// </summary>
        /// <param name="plateau">plateau de jeu</param>
        void afficherPlateau(string[,] plateau)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(String.IsNullOrEmpty(plateau[i, j]))
                        Console.Write("[ ]");
                    else
                        Console.Write("[{0}]", plateau[i, j]);
                }

                Console.Write("\n");
            }
        }

        void jouerCoup(ref string[,] plateau, string joueur)
        {
            Console.WriteLine("\n\nVous êtes le joueur {0}, saisir un coup : ", joueur);

            while (true)
            {
                try
                {
                    int ligne = lireChiffre() - 1;
                    int colonne = lireChiffre() - 1;


                    if (String.IsNullOrEmpty(plateau[ligne, colonne]))
                    {
                        plateau[ligne, colonne] = joueur;
                        break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Le coup saisie est en dehors du tableau, vous avez perdu votre tour.");
                    Console.ReadLine();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Le coup saisie doit etre un chiffre, veuillez rejouer : ");
                    continue;
                }
                Console.WriteLine("Coup déjà joué, veuillez en saisir un autre : ");
            }
        }

        string trouverGagnant(string[,] plateau)
        {
            for (int i = 0; i < 3; i++) {
                if (!String.IsNullOrEmpty(plateau[i, 0]) &&
                    plateau[i, 0] == plateau[i, 1] &&
                    plateau[i, 0] == plateau[i, 2])
                {
                    return plateau[i, 0];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrEmpty(plateau[0, i]) &&
                    plateau[0, i] == plateau[1, i] &&
                    plateau[0, i] == plateau[2, i])
                {
                    return plateau[0, i];
                }
            }

            if (!String.IsNullOrEmpty(plateau[0, 0]) &&
                    plateau[0, 0] == plateau[1, 1] &&
                    plateau[0, 0] == plateau[2, 2])
            {
                return plateau[0, 0];
            }

            if (!String.IsNullOrEmpty(plateau[0, 2]) &&
                    plateau[0, 2] == plateau[1, 1] &&
                    plateau[0, 2] == plateau[2, 0])
            {
                return plateau[0, 2];
            }

            return null;
        }


        int lireChiffre()
        {
            string saisie = Console.ReadLine();
            return Convert.ToInt32(saisie);
        }

    }
}
