using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    public class Ami : Contact, IInvitable
    {
        public DateTime dateNaissance;
        public string ville;

        public Ami(string nom, string prenom, bool isTelPrefered, string email, string telephone, DateTime dateNaissance, string ville) : base(nom, prenom, isTelPrefered, email, telephone)
        {
            this.dateNaissance = dateNaissance;
            this.ville = ville;
        }

        public string genererMessageInvitation()
        {
            return String.Format("Salut {0}, tu es cordialement invité à mon anniversaire !", this.prenom);
        }

        public override string sePresenter()
        {
            return String.Format("Bonjour je suis un Ami : {0} {1} né le {2} et je vis à {3}", this.prenom, this.nom,
                this.dateNaissance, this.ville);
        }

        public override string serialize()
        {
            return String.Format("Ami;{0};{1};{2};{3};{4};{5};{6}",
                this.nom, this.prenom, this.email, this.telephone, this.isTelPrefered, this.dateNaissance, this.ville);
        }
    }
}
