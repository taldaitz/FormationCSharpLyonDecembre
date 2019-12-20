using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Initiation;

namespace Annuaire
{
    public partial class Chat
    {
        public string nom { get; }
        public string Race { get => race; set => race = value; }
        string race;
        int age;

        public Chat(string nom, string race, int age)
        {
            this.nom = nom;
            this.race = race;
            this.age = age;
        }

        public void Presenter()
        {
            Console.WriteLine(nom);
        }

        public static List<Chat> Peupler()
        {
            List<Chat> nouveauxChats = new List<Chat>();

            nouveauxChats.Add(new Chat("Minou", "Persan", 3));
            nouveauxChats.Add(new Chat("Minet", "Siamoi", 5));
            nouveauxChats.Add(new Chat("Batman", "indeterminé", 8));

            return nouveauxChats;
        }
    }


}