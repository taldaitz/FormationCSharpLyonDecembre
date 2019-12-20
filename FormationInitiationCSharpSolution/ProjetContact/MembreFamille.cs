using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    public class MembreFamille : Contact, IInvitable
    {
        public DateTime dateNaissance;
        public string parente;
        public bool estInviteNoel;
        public bool estInviteAnniversaire;

        public MembreFamille(string nom, string prenom, bool isTelPrefered, string email, string telephone, DateTime dateNaissance, string parente, bool estInviteNoel, bool estInviteAnniversaire) 
            : base(nom, prenom, isTelPrefered, email, telephone)
        {
            this.dateNaissance = dateNaissance;
            this.parente = parente;
            this.estInviteNoel = estInviteNoel;
            this.estInviteAnniversaire = estInviteAnniversaire;
        }

        public string genererMessageInvitation()
        {
            if(this.estInviteAnniversaire)
               return String.Format("Salut {0} cher {1}, tu es cordialement invité à mon anniversaire !", 
                   this.prenom, this.parente);

            return "Tu n'es pas invité !!!";
        }

        public override string sePresenter()
        {
            return String.Format("Bonjour je suis un membre de la famille : {0} {1} né le {2} et je suis {3}", 
                this.prenom, this.nom,
                this.dateNaissance, this.parente);
        }

        public override string serialize()
        {
            return String.Format("Famille;{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                this.nom, this.prenom, this.email, this.telephone, this.isTelPrefered, this.dateNaissance, 
                this.parente, this.estInviteNoel, this.estInviteAnniversaire) ;
        }
    }
}
