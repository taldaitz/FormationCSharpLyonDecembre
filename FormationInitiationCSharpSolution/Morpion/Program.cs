using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            Morpion jeu = new Morpion();
            Morpion secondJeu = new Morpion();


            jeu.commencer();

            secondJeu.commencer();

            Console.ReadLine();
        }
    }
}
