using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo05
{
    class Lanceur
    {

        /// <summary>
        /// Méthode lancement du menu des programmes
        /// </summary>
        public void lancer()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Choisir l'application à lancer :");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Pair ou Impair");
                Console.WriteLine("3 - Compte lettre");
                Console.WriteLine("0 - Quitter");

                try
                {
                    int choix = readInt();


                    if (choix == 0)
                        break;

                    if (choix > 3)
                        throw new OverflowException();

                    Console.Clear();
                    switch (choix)
                    {
                        case 1:
                            addition();
                            break;
                        case 2:
                            pairImpair();
                            break;
                        case 3:
                            compteurLettre();
                            break;
                        default:
                            Console.WriteLine("Choix non compris");
                            break;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Attention le chiffre saisie est trop grand");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Attention il faut saisir des chiffres : {0}", e.Message);
                }

                Console.ReadLine();
            }
        }

        void pairImpair()
        {
            Console.WriteLine("Renseigner un chiffre : ");

            int chiffre = readInt();

            if (chiffre % 2 == 0)
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");
            }
        }

        void addition ()
        {
            Console.WriteLine("Renseigner deux chiffres : ");

            int a = readInt();
            int b = readInt();

            Console.WriteLine("La somme de {1} + {0} est {2}",
                                                            a,
                                                            b,
                                                            a + b);
        }

        void compteurLettre()
        {
            Console.WriteLine("Saisir des mots (tapez /exit pour quitter):");
            string result = "";

            while (true)
            {
                string mot = readStr();

                if (mot == "/exit")
                    break;

                result = String.Format("{0}\n{1} - {2} lettres", result, mot, mot.Length);
            }

            Console.WriteLine(result);
        }


        string readStr()
        {
            return Console.ReadLine().Trim();
        }

        int readInt()
        {
            string saisie = readStr();

            return int.Parse(saisie);
        }
    }
}
