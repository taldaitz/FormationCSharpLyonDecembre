using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo04
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] chiffres = new int[] { 47, -6, 1, 123, 418, -73, 0, 58, 12, -20, 42};

            Console.WriteLine("Valeur Max : {0} {1}{2}{3}{4}{5}{6}{7}", 
                chiffres.Max(),1,2,3,4,5,6,7
                );
            Console.WriteLine("Valeur Min : {0}", chiffres.Min());
            Console.WriteLine("Valeur Moyenne : {0}", chiffres.Average());


            int max = int.MinValue;
            int min = int.MaxValue;
            int somme = 0;

            foreach(int val in chiffres)
            {
                if (val > max)
                    max = val;

                if (val < min)
                    min = val;

                somme += val;
            }


            Console.WriteLine("\n\nValeur Max : {0}", max);
            Console.WriteLine("Valeur Min : {0}", min);
            Console.WriteLine("Valeur Moyenne : {0}", (double)somme / chiffres.Length);


            Console.ReadLine();

        }
    }
}
