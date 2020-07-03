using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public abstract class Personne
    {
        public string nom;
        public string prenom;
        public DateTime dateNaissance;
        public string email;

        protected Personne(string nom, string prenom, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
        }

        public abstract string sePresenter();

        public string commencerEmail()
        {
            return String.Format("Cher {0} {1}", this.prenom, this.nom);
        }

    }
}
