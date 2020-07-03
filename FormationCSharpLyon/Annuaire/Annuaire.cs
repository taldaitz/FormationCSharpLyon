using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    public class Annuaire
    {
        public void lancer()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans le super Annuaire !!");
                Console.WriteLine("1 - Ajouter un contact");
                Console.WriteLine("2 - Lister tous les contacts");
                Console.WriteLine("0 - Quitter");

                string choix = Console.ReadLine();

                if (choix == "0") break;

                switch(choix)
                {
                    case "1":
                        ajouterContact();
                        break;

                    case "2":
                        listerContacts();
                        break;
                }
            }
        }

        void ajouterContact()
        {
            Console.Clear();
            Console.WriteLine("Saisir un Nom pour le nouveau contact :");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir un Prénom pour le nouveau contact :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Saisir un Téléphone pour le nouveau contact :");
            string telephone = Console.ReadLine();
            Console.WriteLine("Saisir un Email pour le nouveau contact :");
            string email = Console.ReadLine();

            sauvegarderContact(nom, prenom, telephone, email);

            Console.WriteLine("\n\nContact Sauvegardé");
        }

        public void sauvegarderContact(string nom, string prenom, string telephone, string email)
        {
            using (StreamWriter writer = new StreamWriter("annuaire.txt", true))
            {
                writer.WriteLine("{0};{1};{2};{3}", nom, prenom, telephone, email);
            }
        }

        void listerContacts()
        {
            Console.Clear();
            List<string[]> contacts = lireContacts();

            foreach(string[] contact in contacts)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Nom : {0}", contact[0]);
                Console.WriteLine("Prénom : {0}", contact[1]);
                Console.WriteLine("Téléphone : {0}", contact[2]);
                Console.WriteLine("Email : {0}", contact[3]);
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
        }

        public List<string[]> lireContacts()
        {
            List<string[]> contacts = new List<string[]>();

            using (StreamReader reader = new StreamReader("annuaire.txt"))
            {
                while(!reader.EndOfStream)
                {
                    string contact = reader.ReadLine();
                    contacts.Add(contact.Split(';'));
                }
            }

            return contacts;
        }
    }
}
