using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ce mot fait {0} lettres", MyCountLetter("sandwich"));
            Console.ReadKey();
        }

        static int MyCountLetter(string word) {
            int i = 0;
            foreach(char letter in word)
            {
                i++;
            }

            return i;
        }
    }
}
