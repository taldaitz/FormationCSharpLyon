using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    public class Newsletter
    {
        public string message;
        private List<Personne> destinataires;

        public Newsletter()
        {
            this.destinataires = new List<Personne>();
        }

        public void inscrire(Personne personne)
        {
            this.destinataires.Add(personne);
        }

        public void envoyer()
        {
            foreach(Personne destinataire in destinataires)
            {
                Console.WriteLine("{0}\n {1}", destinataire.commencerEmail(), this.message);
            }
        }
    }
}
