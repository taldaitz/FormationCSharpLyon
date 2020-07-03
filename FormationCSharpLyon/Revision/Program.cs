using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string prenom = "Thomas";

            Console.WriteLine("{0} - {1} lettres", prenom, prenom.Length);

            if (prenom.Trim().Length > 10)
            {
                Console.WriteLine("Le prénom est trop long");
            }

            string[] mots = new string[5];
            mots[0] = "ecran";
            mots[1] = "souris";
            mots[2] = "table";


            string[] couleurs = new string[] { "bleu", "vert", "rouge", "jaune" };

            int couleurChoisie = choisirCouleur(couleurs);
            afficherPreference(couleurChoisie, couleurs);*/

            GestionFichier gf = new GestionFichier();
            gf.demarrer();

            Console.ReadLine();
        }

        static int choisirCouleur(string[] couleurs)
        {

            Console.WriteLine("\n\nQuel est ta couleur préférée :");

            for (int i = 0; i < couleurs.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, couleurs[i]);
            }

            int couleurChoisie;
            string saisie = Console.ReadLine();
            couleurChoisie = int.Parse(saisie);

            return couleurChoisie;
        }

        static void afficherPreference(int couleurChoisie, string[] couleurs)
        {
            string couleurPrefereeDeMonUtilisateur = couleurs[couleurChoisie - 1];

            Console.WriteLine("Ta couleur préférée : {0}", couleurPrefereeDeMonUtilisateur);
        } 
    }
}
