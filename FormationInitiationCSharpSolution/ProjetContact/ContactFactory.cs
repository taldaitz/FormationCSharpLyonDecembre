using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    public class ContactFactory
    {
        public static Contact getInstance(string ligneSerialise)
        {
            string[] contactTab = ligneSerialise.Split(';');

            if (contactTab[0] == "Ami")
                return new Ami(contactTab[1],
                    contactTab[2],
                    bool.Parse(contactTab[5]),
                    contactTab[3],
                    contactTab[4],
                    DateTime.Parse(contactTab[6]),
                    contactTab[7]
                    );

            return null;
        }
    }
}
