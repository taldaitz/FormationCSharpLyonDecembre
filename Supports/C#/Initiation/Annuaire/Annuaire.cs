using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    public class AnnuaireContact
    {

        public List<Contact> contacts;

        public void Commencer()
        {
            contacts = new List<Contact>();
            LoadContacts();

            while(true)
            {
                AskOptions();
                Console.Clear();
            }

        }

        public void InitForWinForm()
        {
            contacts = new List<Contact>();
            LoadContacts();
        }

        public void AskOptions()
        {
            Console.WriteLine("Tapez 1 - Pour Créer un Contact");
            Console.WriteLine("Tapez 2 - Afficher la liste des contacts");
            Console.WriteLine("Tapez 3 - Pour Sauvegarder");
            string option = Console.ReadLine();

            if (option == "1")
                AddContact();
            if (option == "2")
                ShowContact();
            if (option == "3")
                SaveContacts();
        }

        public void AddContact()
        {
            Contact personne = new Contact();

            Console.WriteLine("Saisissez le nom :");
            personne.nom = Console.ReadLine();

            Console.WriteLine("Saisissez le prenom :");
            personne.prenom = Console.ReadLine();

            contacts.Add(personne);
        }

        public void ShowContact()
        {
            foreach(Contact contact in contacts)
            {
                Console.WriteLine("Nom : {0}", contact.nom);
                Console.WriteLine("Penom : {0}", contact.prenom);
                Console.WriteLine("-----------------------");
            }
            Console.ReadKey();
        }

        public void SaveContacts()
        {
            using (StreamWriter writer = new StreamWriter("contacts.csv", false))
            {
                foreach(Contact contact in contacts)
                {
                    writer.WriteLine("{0};{1}", contact.nom, contact.prenom);
                }
            }
        }

        public void LoadContacts()
        {
            try
            {
                using (StreamReader reader = new StreamReader("contacts.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] contactTab = reader.ReadLine().Split(';');
                        contacts.Add(new Contact() { nom = contactTab[0], prenom = contactTab[1] });
                    }
                }
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Le fichier n'existe pas encore.");
            }
        }
    }
}
