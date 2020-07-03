using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Gardien : Joueur
    {
        public int tailleGant;
        public int nbArret;

        public Gardien(string nom, string prenom, int numero, DateTime dateNaissance, 
            int tailleGant, int nbArret, string email) : 
            base(nom, prenom, numero, dateNaissance, "gardien de but", email)
        {
            this.tailleGant = tailleGant;
            this.nbArret = nbArret;
        }

        /*public override string sePresenter()
        {
            return String.Format("{0}. Et j'ai arrété {1} de ballon.", 
                                    base.sePresenter(),
                                    this.nbArret);
        }*/

        public override string presentationSpecifique()
        {
            return String.Format("Et j'ai arrété {0} ballons.", this.nbArret);
        }
    }
}
