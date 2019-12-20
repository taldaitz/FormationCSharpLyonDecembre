using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Annuaire
    {
        public void lancerMenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenu dans l'annuaire :");
                Console.WriteLine("1 - Renseigner un nouveau contact");
                Console.WriteLine("2 - Voir tous les contacts");
                Console.WriteLine("0 - Sortir");

                string option = Console.ReadLine();

                if (option == "0")
                    break;

                switch (option)
                {
                    case "1":
                        saveContact();
                        break;

                    case "2":
                        listContacts();
                        break;
                }
            }
        }

        void saveContact()
        {
            Console.Clear();

            Console.WriteLine("Nom ?");
            string nom = Console.ReadLine();

            Console.WriteLine("Prenom ?");
            string prenom = Console.ReadLine();

            Console.WriteLine("Email ?");
            string email = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("contacts.txt", true))
            {
                writer.WriteLine("{0};{1};{2}", nom, prenom, email);
            }

            Console.WriteLine("Contact est sauvegardé !");
            Console.ReadLine();
        }

        void listContacts()
        {
            Console.Clear();
            using (StreamReader reader = new StreamReader("contacts.txt"))
            {
                while(!reader.EndOfStream)
                {
                    string contactValues = reader.ReadLine();

                    string[] contactTab = contactValues.Split(';');

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Nom : {0}", contactTab[0]);
                    Console.WriteLine("Prenom : {0}", contactTab[1]);
                    Console.WriteLine("Email : {0}", contactTab[2]);
                    Console.WriteLine("---------------------------------");
                }

                Console.ReadLine();
            }
        }
    }
}
