using System;

namespace FormationInitiationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu à la formation C#");
            Console.WriteLine("Comment ca va ?");

            string valeurSaisie = Console.ReadLine();

            Console.WriteLine("Réponse : " + valeurSaisie );

            Console.ReadLine();
        }
    }
}
