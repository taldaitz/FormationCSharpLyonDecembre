using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Voiture : IVehicul
    {
        public string marque;
        public string plaque;
        public string couleur;
        public int vitesse;
        public bool isStarted;

        public Voiture(string plaque, string couleur)
        {
            this.plaque = plaque;
            this.couleur = couleur;
        }

        public void demarrer()
        {
            this.isStarted = true;
        }

        public virtual void accelerer()
        {
            this.vitesse += 5;
        }

        public void rouler()
        {
            this.demarrer();
            this.accelerer();
        }

        public void freiner()
        {
            this.vitesse -= 5;
        }
    }
}
