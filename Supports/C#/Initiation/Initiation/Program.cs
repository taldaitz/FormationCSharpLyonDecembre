using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Morpion jeu = new Morpion();
            jeu.Commencer();

                                          
        }

        static void SortArray( ref int[] intArray, int number)
        {
                int i = 0;
                for(i = 0; i < intArray.Length; i++)
                {
                    if(intArray[i] == 0 || intArray[i] > number)
                    {
                        break;
                    }
                }

                for (int j = intArray.Length - 1; j > i; j--)
                {
                    intArray[j] = intArray[j - 1];
                }

                intArray[i] = number;
        }

        static void DrawGrid(int nbColumns, int nbLines)
        {
            Console.WriteLine("{0} X {1}", nbColumns, nbLines);
            for (int i = 0; i < nbLines; i++)
            {
                for (int j = 0; j < nbColumns; j++)
                {
                    Console.Write("[ ]");
                }
                Console.Write("\n");
            }
        }
    }
}
