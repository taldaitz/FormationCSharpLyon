using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class GestionFichier
    {
        public void demarrer()
        {
            try
            {
                int res = multiplication(-2, 6);

                for (int i = 0; i <= res; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch(Exception e)
            {
                loggerErreur(e.Message);

            }
        }


        /// <summary>
        /// Méthode qui multiplie deux chiffres.
        /// </summary>
        /// <param name="a">1er chiffre</param>
        /// <param name="b">2eme chiffre</param>
        /// <returns>Resultat de la multiplication</returns>
        int multiplication(int a, int b)
        {
            int res = a * b;

            if (res < 0)
                throw new Exception("Attention, le resulat est négatif !");

            return res;
        }

        void loggerErreur(string message)
        {

            using (StreamWriter writer = new StreamWriter("erreurs.log", true))
            {
                writer.WriteLine("{0} - Erreur : {1}", DateTime.Now , message);
            }

        }
    }
}
