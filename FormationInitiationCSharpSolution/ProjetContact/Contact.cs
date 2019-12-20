using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    public abstract class Contact
    {
        public string nom { get; set; }
        public string prenom;
        public string email;
        public string telephone;

        public bool isTelPrefered;

        private Contact(string nom, string prenom) {

            this.nom = nom;
            this.prenom = prenom;
        }

        public Contact(string nom, string prenom, bool isTelPrefered, string email = null, string telephone = null) : 
            this(nom, prenom)
        {
            this.email = email;
            this.telephone = telephone;
            this.isTelPrefered = isTelPrefered;
        }

        public void save()
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt", true))
            {
                writer.WriteLine(this.serialize());
            }
        }

        public abstract string sePresenter();

        public abstract string serialize();

    }
}
