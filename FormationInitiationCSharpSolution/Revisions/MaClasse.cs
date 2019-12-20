using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class MaClasse
    {
        private DateTime dateDuJour;
        private string sujet;

        private MaClasse()
        {
            this.dateDuJour = DateTime.Today;
        }

        public MaClasse(string sujet) : this()
        {
            this.sujet = sujet;
        }
    }
}
