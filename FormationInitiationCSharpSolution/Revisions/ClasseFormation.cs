using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class ClasseFormation : MaClasse
    {
        public int nbParticipants;

        public ClasseFormation(int nbParticipants, string sujet) : base(sujet)
        {
            this.nbParticipants = nbParticipants;
        }
    }
}
