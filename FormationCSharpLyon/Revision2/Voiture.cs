using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    public class Voiture : IRoulant, IKlaxonner
    {
        public string marque;
        public string couleur;
        protected int vitesse;
        private bool estDemarree;

        public Voiture(string marque, string couleur)
        {
            this.marque = marque;
            this.couleur = couleur;
        }

        public Voiture(string marque, string couleur, bool estDemarree) : this(marque, couleur)
        {
            this.estDemarree = estDemarree;
        }

        public virtual void demarrer()
        {
            if(this.estDemarree)
            {
                throw new Exception("Voiture déjà démarrée.");
            }
            this.estDemarree = true;
        }

        public void accelerer()
        {
            if(this.estDemarree)
                this.vitesse += 5;
        }

        public void arreter()
        {
            this.estDemarree = false;
            this.vitesse = 0;
        }

        public override string ToString()
        {
            return String.Format("Youpi je suis une Voiture de la marque {0}", this.marque);
        }

        public void rouler()
        {
            Console.WriteLine("Le voiture roule");
        }

        public void klaxonner()
        {
            Console.WriteLine("Pouet Pouet");
        }
    }
}
