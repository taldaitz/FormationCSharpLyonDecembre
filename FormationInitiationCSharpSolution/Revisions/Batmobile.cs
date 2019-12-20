using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Batmobile : Voiture
    {

        public string reacteur;

        public Batmobile(string plaque, string reacteur) : base(plaque, "noir")
        {
            this.reacteur = reacteur;
        }

        public override void accelerer()
        {
            this.vitesse += 50;
        }
    }
}
