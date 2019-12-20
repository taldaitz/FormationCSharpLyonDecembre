using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1/ Civilité
            //Console.WriteLine("Saisir votre civilité : ");
            //string civilite = Console.ReadLine();

            //switch(civilite)
            //{
            //    case "Mr":
            //    case "mr":
            //        Console.WriteLine("Bonjour il fait beau aujourd'hui");
            //        break;

            //    case "Mme":
            //    case "mme":
            //        Console.WriteLine("Bonjour Vous avez un joli chapeau");
            //        break;

            //    case "Mlle":
            //    case "mlle":
            //        Console.WriteLine("Bonjour comment allez vous ?");
            //        break;

            //    default:
            //        Console.WriteLine("Civilité inconnue");
            //        break;
            //}

            //2/ Pair ou Impair

            //Console.WriteLine("Saisir un nombre : ");
            //string nombreSaisie = Console.ReadLine();

            //int nombre = Convert.ToInt32(nombreSaisie);

            //if (nombre % 2 == 0)
            //{
            //    Console.WriteLine("Le chiffre {0} est pair", nombre);
            //}
            //else
            //{
            //    Console.WriteLine("Le chiffre {0} est impair", nombre);
            //}

            //3 / Compteur de lettres

            Console.WriteLine("Saisir un mot : ");
            string mot = Console.ReadLine();

            if (mot.Length < 15)
            {
                Console.WriteLine(mot.Length);
            } else {
                Console.WriteLine("Ce mot est trop long.");
            }

            Console.ReadLine();
        }
    }
}
