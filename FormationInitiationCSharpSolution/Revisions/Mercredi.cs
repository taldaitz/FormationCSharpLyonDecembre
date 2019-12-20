using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Mercredi
    {

        public bool executer(string nom)
        {
            if (nom == "Thomas")
            {
                return true;
            }

            ajouterTexte(ref nom, "Aldaitz");


            int?[] trioChiffres = new int?[] { 5, 12, 28, null };

            bool[] tabool = new bool[5];


            ArrayList array = new ArrayList();
            array.Add("toto");
            array.Add(5);
            array.Add(true);

            foreach(object val in array)
            {
                val.GetType();
            }

            List<string> mots = new List<string>();
            mots.Add("Thomas");
            mots.Add("Ecran");
            mots.Add("Souris");

            foreach(string val in mots)
            {
                val.Trim();
            }

            List<int> chiffres = new List<int>();
            chiffres.Add(465);
            chiffres.Add(12);
            chiffres.Add(98);

            int total = 0;
            foreach(int val in chiffres)
            {
                total += val;
            }


            //Lecture
            using (StreamReader reader = new StreamReader("fichier.txt"))
            {
                while (!reader.EndOfStream) {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            //Ecrire
            using (StreamWriter writer = new StreamWriter("fichier.txt", true))
            {
                writer.WriteLine("Contenue du fichier !");
            }

            return false;
        }


        void ajouterTexte(ref string nom, string ajout = "123")
        {
            nom = String.Format("{0} {1}", nom, ajout);
        }
    }
}
