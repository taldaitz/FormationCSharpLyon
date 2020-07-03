using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Renseigner votre nom : ");
            string nom = Console.ReadLine();

            //Console.WriteLine("Bonjour " + nom); -> à ne pas utiliser
            Console.WriteLine("Bonjour {0}", nom); // Meilleure solution !*/

            Console.WriteLine("Renseigner deux chiffres : ");

            string chiffreUn = Console.ReadLine();
            string chiffreDeux = Console.ReadLine();

            int a = Convert.ToInt32(chiffreUn);
            int b = Convert.ToInt32(chiffreDeux);

            Console.WriteLine("La somme de {1} + {0} est {2}", 
                                                            a, 
                                                            b, 
                                                            a + b);

            Console.ReadLine();
        }
    }
}
