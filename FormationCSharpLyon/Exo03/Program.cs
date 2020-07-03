using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo03
{
    class Program
    {
        static void Main(string[] args)
        {

            /* while (true)
             {
                 Console.WriteLine("Renseigner votre civilité : ");

                 string civilite = Console.ReadLine();

                 if(civilite == "Mr")
                 {
                     Console.WriteLine("Vous avez une jolie moustache");
                     break;
                 } else if (civilite == "Mme")
                 {
                     Console.WriteLine("Vous avez un joli chapeau");
                     break;
                 }
                 else if (civilite == "Mlle")
                 {
                     Console.WriteLine("Il fait beau aujourd'hui");
                     break;
                 } else
                 {
                     Console.WriteLine("Civilité non gérée");
                 }
             }*/


            /*Console.WriteLine("Saisir hauteur et largeur:");
            string hauteurSaisie = Console.ReadLine();
            string largeurSaisie = Console.ReadLine();

            int hauteur = Convert.ToInt32(hauteurSaisie);
            int largeur = int.Parse(largeurSaisie);

            Console.Write("\n");

            for (int j=0; j < hauteur; j++)
            {
                for (int i = 0; i < largeur; i++)
                {
                    Console.Write("[]");
                }

                Console.Write("\n");
            }*/


            Console.WriteLine("Saisir des mots (tapez /exit pour quitter):");
            string result = "";

            while(true)
            {
                string mot = Console.ReadLine();

                if (mot == "/exit")
                    break;

                result = String.Format("{0}\n{1} - {2} lettres", result, mot, mot.Length);
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
