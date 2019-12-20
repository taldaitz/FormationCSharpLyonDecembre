using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainExercices
{
    class Exercices
    {

        public void lancer()
        {
            while (true) {

                Console.Clear();

                Console.WriteLine("Selectionner l'option à lancer : ");
                Console.WriteLine("1 - Pair/Impair");
                Console.WriteLine("2 - Compter de lettre");
                Console.WriteLine("3 - Quadrillage");
                Console.WriteLine("0 - Sortir");

                string option = lireTexte();

                if (option == "0")
                    break;

                Console.Clear();

                switch (option)
                {
                    case "1":
                        pairImpair();
                        break;

                    case "2":
                        compteurLettre();
                        break;

                    case "3":
                        quadrillage();
                        break;
                }

                Console.ReadLine();
            }
           
        } 

        int addition(int premier, int deuixieme)
        {
            return premier + deuixieme;
        }

        string lireTexte()
        {
            string saisie = Console.ReadLine();
            return saisie.Trim();
        }

        int lireChiffre()
        {
            string saisie = Console.ReadLine();
            try
            {
                return Convert.ToInt32(saisie);
            } catch (Exception e)
            {
                Console.WriteLine("Ce qui doit etre saisie, doit l'etre en chiffre.");
                return 0;
            }
        }

        void pairImpair()
        {
            Console.WriteLine("Saisir un nombre : ");

            int nombre = lireChiffre();

            if (nombre % 2 == 0)
            {
                Console.WriteLine("Le chiffre {0} est pair", nombre);
            }
            else
            {
                Console.WriteLine("Le chiffre {0} est impair", nombre);
            }
        }

        void compteurLettre()
        {
            Console.WriteLine("Saisir un mot : ");
            string mot = lireTexte();

            if (mot.Length < 15)
            {
                Console.WriteLine(mot.Length);
            }
            else
            {
                Console.WriteLine("Ce mot est trop long.");
            }
        }

        void quadrillage()
        {
            Console.WriteLine("Saisir des dimensions : ");
            int colonnes = lireChiffre();
            int lignes = lireChiffre();

            for (int j = 0; j < lignes; j++)
            {
                for (int i = 0; i < colonnes; i++)
                {
                    Console.Write("[]");
                }
                Console.Write("\n");
            }
        }

    }
}
