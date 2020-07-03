using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Joueur : Personne
    {
        public int numero;
        public string poste;
        public bool estValide;
        public int nbButMarque;

        public static string club = "MFC";
        public static int nbDeJoueurs;

        public Joueur(string nom, string prenom, string email) : base(nom, prenom, email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.estValide = true;

            Joueur.nbDeJoueurs++;
        }

        public Joueur(string nom, string prenom, int numero, DateTime dateNaissance, string poste, string email) : this(nom, prenom, email)
        {
            this.numero = numero;
            this.dateNaissance = dateNaissance;
            this.poste = poste;
        }

        public void participer(string match)
        {

        }

        public void marquer()
        {
            nbButMarque++;
        }

        public void seBlesser()
        {
            estValide = false;
        }

        public override string sePresenter()
        {

            return String.Format("Je m'appelle {0} {1}, " +
                                   "je joue au poste de {2} " +
                                   "avec le numéro {3}. {4}",
                                                        this.prenom,
                                                        this.nom,
                                                        this.poste,
                                                        this.numero,
                                                        this.presentationSpecifique()
                                                        );
        }

        public virtual string presentationSpecifique()
        {
            return String.Format("Et j'ai marqué {0} buts.", this.nbButMarque);
        }
    }
}
