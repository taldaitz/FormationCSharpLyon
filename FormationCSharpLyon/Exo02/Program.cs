using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Renseigner votre civilité : ");

            string civilite = Console.ReadLine();

            switch(civilite)
            {
                case "Mr":
                    Console.WriteLine("Vous avez une jolie moustache");
                    break;

                case "Mme":
                    Console.WriteLine("Vous avez un joli chapeau");
                    break;

                case "Mlle":
                    Console.WriteLine("Il fait beau aujourd'hui");
                    break;
            }*/

            /* Console.WriteLine("Renseigner un chiffre : ");

             string chiffreStr = Console.ReadLine();
             int chiffre = Convert.ToInt32(chiffreStr);

             if(chiffre % 2 == 0)
             {
                 Console.WriteLine("Pair");
             } else
             {
                 Console.WriteLine("Impair");
             }*/

            Console.WriteLine("Renseigner un mot");
            string mot = Console.ReadLine();

            mot = mot.Trim();

            if (mot.Length < 15) {
                Console.WriteLine("{0} lettres", mot.Length);
            } else
            {
                Console.WriteLine("Mot trop long");
            }

            Console.ReadLine();
        }
    }
}
