using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Veterinaire
    {
        string nom;
        string prenom;

        public Veterinaire (string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public void SoignerChat(Chat chat)
        {
            Console.WriteLine("Dr {0} soigne {1} ", this.nom, chat.nom );
        }
    }
}
