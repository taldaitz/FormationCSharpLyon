using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Arbitre : Personne
    {
        public DateTime dateDiplome;
        public Arbitre(string nom, string prenom, DateTime dateDiplome, string email) 
            : base(nom, prenom, email)
        {
            this.dateDiplome = dateDiplome;
        }

        public override string sePresenter()
        {
            return String.Format("Je m'appelle {0} {1}, je suis arbitre. J'ai eu mon diplome le {2}",
                                    this.prenom,
                                    this.nom,
                                    this.dateDiplome);
        }
    }
}
