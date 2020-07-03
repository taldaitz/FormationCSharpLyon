using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Coach : Personne
    {
        public string niveau;
        public int nbAnneeExp;
        public Coach(string nom, string prenom, string niveau, int nbAnneeExp, string email) 
            : base(nom, prenom, email)
        {
            this.niveau = niveau;
            this.nbAnneeExp = nbAnneeExp;
        }

        public override string sePresenter()
        {
            return String.Format("Je m'appelle {0} {1}, je suis coach. J'entraine les {2} depuis {3} ans.",
                                   this.prenom,
                                   this.nom,
                                   this.niveau,
                                   this.nbAnneeExp);
        }
    }
}
