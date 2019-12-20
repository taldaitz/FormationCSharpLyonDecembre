using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    public class ContactPro : Contact
    {
        public string societe;
        public string poste;
        public ContactPro(string prenom, string nom, string societe, string email, string telephone, bool isTelPrefered = true, string poste = null) 
            : base(nom, prenom, isTelPrefered, email, telephone)
        {
            this.societe = societe;
            this.poste = poste;
        }

        public override string sePresenter()
        {
            return String.Format( "Bonjour je suis un Contact Pro : {0} {1} de chez {2} au poste de {3}", this.prenom, this.nom,
                this.societe, this.poste);
        }

        public override string serialize()
        {
            return String.Format("ContactPro;{0};{1};{2};{3};{4};{5};{6}",
                this.nom, this.prenom, this.email, this.telephone, this.isTelPrefered, this.societe, this.poste);
        }
    }
}
