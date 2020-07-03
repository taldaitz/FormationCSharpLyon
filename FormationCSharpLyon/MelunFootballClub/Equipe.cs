using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Equipe
    {
        public string nom;
        public Coach entraineur;
        public List<Joueur> joueurs;

        public Equipe()
        {
            this.joueurs = new List<Joueur>(); //<--- aggrégation active
        }
    }
}
