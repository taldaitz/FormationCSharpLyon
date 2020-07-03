using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelunFootballClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur attaquant = new Joueur("Henry", "Thierry",12, new DateTime(1977, 08, 17), "attaquant", "taldaitz@dawan.fr");
            attaquant.nbButMarque = 8;

            Gardien goal = new Gardien("Barthez", "Fabien", 1, new DateTime(1971, 06, 28), 15, 2, "taldaitz@dawan.fr");

            Joueur player1 = new Joueur("Zidane", "Zinedine", 10, new DateTime(1970, 04, 14), "milieu", "taldaitz@dawan.fr");
            Joueur player2 = new Joueur("Deschamps", "Didier", 8, new DateTime(1970, 04, 14), "défenseur", "taldaitz@dawan.fr");

            Arbitre referee = new Arbitre("Durant", "Robert", new DateTime(2001, 01, 01), "taldaitz@dawan.fr");

            Coach entraineur = new Coach("Dupont", "Emile", "senior", 15, "taldaitz@dawan.fr");

            /*Console.WriteLine("-{0}\n", attaquant.sePresenter());
            Console.WriteLine("-{0}\n", player1.sePresenter());
            Console.WriteLine("-{0}\n", player2.sePresenter());
            Console.WriteLine("-{0}\n", referee.sePresenter());
            Console.WriteLine("-{0}\n", entraineur.sePresenter());*/

            List<Personne> people = new List<Personne>();
            people.Add(attaquant);
            people.Add(player1);
            people.Add(player2);
            people.Add(referee);
            people.Add(entraineur);

            foreach(Personne personne in people)
            {
                Console.WriteLine("-{0}\n", personne.sePresenter());
            }

            Newsletter nl = new Newsletter();
            nl.message = "Salut !";
            nl.inscrire(attaquant);
            nl.inscrire(entraineur);
            nl.inscrire(goal);

            nl.envoyer();

            Equipe team = new Equipe();
            team.nom = "MFC";
            team.entraineur = entraineur;

            //team.joueurs = new List<Joueur>(); <-- aggrégation passive
            team.joueurs.Add(player1);
            team.joueurs.Add(player2);
            team.joueurs.Add(goal);

            Console.WriteLine("L'équipe {0} est entrainée par {1} {2}, et a {3} joueurs",
                                team.nom, 
                                team.entraineur.prenom, 
                                team.entraineur.nom, 
                                team.joueurs.Count
                );


            Console.ReadLine();
        }
    }
}
