using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1/ Civilité


            //bool civiliteEstValide = false;
            //while (civiliteEstValide == false) {

            //    Console.WriteLine("Saisir votre civilité : ");
            //    string civilite = Console.ReadLine();

            //    switch (civilite)
            //    {
            //        case "Mr":
            //        case "mr":
            //            Console.WriteLine("Bonjour il fait beau aujourd'hui");
            //            civiliteEstValide = true;
            //            break;

            //        case "Mme":
            //        case "mme":
            //            Console.WriteLine("Bonjour Vous avez un joli chapeau");
            //            civiliteEstValide = true;
            //            break;

            //        case "Mlle":
            //        case "mlle":
            //            Console.WriteLine("Bonjour comment allez vous ?");
            //            civiliteEstValide = true;
            //            break;

            //        default:
            //            Console.WriteLine("Civilité inconnue");
            //            break;
            //    }
            //}

            //2/ Cadrillage

            //Console.WriteLine("Saisir des dimensions : ");
            //string colonnesSaisie = Console.ReadLine();
            //string lignesSaisie = Console.ReadLine();

            //int colonnes = int.Parse(colonnesSaisie);
            //int lignes = int.Parse(lignesSaisie);

            //for (int j = 0; j < lignes; j++) {
            //    for (int i = 0; i < colonnes; i++)
            //    {
            //        Console.Write("[]");
            //    }
            //    //Console.WriteLine();
            //    Console.Write("\n");
            //}


            //3/ Compteur de lettre infini

            Console.WriteLine("Saisir des mots et terminer par /exit");


            string mots = "";
            while (true) {
                string mot = Console.ReadLine();

                if (mot == "/exit")
                    break;

                mots = String.Format("{0}{1} - {2}\n", mots, mot, mot.Length);
            }

            Console.WriteLine(mots);

            Console.ReadLine();
        }
    }
}
