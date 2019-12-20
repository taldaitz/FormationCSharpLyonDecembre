using ProjetContact;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireObjet
{
    class AnnuaireManager
    {
        public static List<Contact> getAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            using (StreamReader reader = new StreamReader("contacts.txt"))
            {
                while(!reader.EndOfStream)
                {
                    string ligne = reader.ReadLine();
                    contacts.Add(ContactFactory.getInstance(ligne));
                }

            }

            return contacts;
        }
    }
}
