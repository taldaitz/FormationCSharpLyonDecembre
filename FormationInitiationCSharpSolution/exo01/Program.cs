using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1/Salutation
            /*Console.WriteLine("Saisir votre nom : ");
            string nom = Console.ReadLine();
            //Console.WriteLine("Bonjour " + nom);
            Console.WriteLine("Bonjour {0}!", nom); //Bonne pratique*/

            //2/ Addition

            Console.WriteLine("Saisir deux chiffres : ");

            string saisieChiffreUn = Console.ReadLine();
            string saisieChiffreDeux = Console.ReadLine();


            int chiffreUn = Convert.ToInt32(saisieChiffreUn);
            int chiffreDeux = Int32.Parse(saisieChiffreDeux);

            Console.WriteLine("Resultat : {0}", chiffreUn + chiffreDeux);

            Console.ReadLine();
        }
    }
}
