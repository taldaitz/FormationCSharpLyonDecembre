using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Jeudi
    {

        void reviser()
        {
            try
            {
                int chiffre = int.Parse("");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Attention on ne peut pas convertir rien.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Attention B n'est pas un chiffre");
            }


            List<string> noms = new List<string>() { "Thomas", "TOTO" };
            noms.Add("Thomas");
            noms.Add("Toto");
            noms.Add("Titi");


            using (StreamWriter writer = new StreamWriter("revision.sql"))
            {
                foreach(string zozo in noms)
                {
                    writer.Write("{0} - ", zozo);
                    //Thomas - Toto - Titi -
                }

                //Thomas - Toto - Titi
                string ligne = String.Join(" - ", noms);
                writer.WriteLine(ligne);
            }

        }
    }
}
