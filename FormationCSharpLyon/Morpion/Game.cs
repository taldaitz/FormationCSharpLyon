using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Game
    {
        public void start()
        {
            string[,] plateau = new string[3, 3];
            string gagnant = "";


            for (int i = 0; i < 9; i++) {
                string joueur = i % 2 == 0 ? "X" : "O";

                afficherPlateau(plateau);

                jouerCoup(ref plateau, joueur);

                gagnant = verifierGagnant(plateau);

                if (!String.IsNullOrEmpty(gagnant))
                {
                    afficherPlateau(plateau);
                    Console.WriteLine("Youpi ! {0} a gagné", gagnant);
                    break;
                }
            }

            if(String.IsNullOrEmpty(gagnant))
            {
                afficherPlateau(plateau);
                Console.WriteLine("Match Nul !");
            }



        }

        void afficherPlateau(string[,] plateau)
        {

            Console.Clear();
            for(int i =0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (String.IsNullOrEmpty(plateau[i, j]))
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write("[{0}]", plateau[i, j]);
                    }
                }
                Console.Write("\n");
            }
        }

        void jouerCoup(ref string[,] plateau, string joueur)
        {

            Console.WriteLine("Vous êtes le joueur {0}, saisissez votre coup :", joueur);

            int ligne = readInt() -1;
            int colonne = readInt() -1;

            plateau[ligne, colonne] = joueur;

        }

        string verifierGagnant(string[,] plateau)
        {

            for (int i = 0; i < 3; i++) {
                if (!String.IsNullOrEmpty(plateau[i, 0]) &&
                    plateau[i, 0] == plateau[i, 1] &&
                    plateau[i, 0] == plateau[i, 2]
                    )
                    return plateau[i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrEmpty(plateau[0, i]) &&
                    plateau[0, i] == plateau[1, i] &&
                    plateau[0, i] == plateau[2, i]
                    )
                    return plateau[0, i];
            }

            if (!String.IsNullOrEmpty(plateau[0, 0]) &&
                    plateau[0, 0] == plateau[1, 1] &&
                    plateau[0, 0] == plateau[2, 2]
                    )
                return plateau[0, 0];

            if (!String.IsNullOrEmpty(plateau[0, 2]) &&
                    plateau[0, 2] == plateau[1, 1] &&
                    plateau[0, 2] == plateau[2, 0]
                    )
                return plateau[0, 2];

            return null;
        }

        string readStr()
        {
            return Console.ReadLine().Trim();
        }

        int readInt()
        {
            string saisie = readStr();
            return Convert.ToInt32(saisie);
        }
    }
}
