using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    public class Batmobile : Voiture
    {
        private bool reacteurAllume;
        public Batmobile() : base("Batman", "Noir")
        {
        }

        public override void demarrer()
        {
            base.demarrer();
            this.reacteurAllume = true;
        }

        public new void accelerer()
        {
            this.vitesse += 20;
        }

        public void klaxonner()
        {

        }
    }
}
