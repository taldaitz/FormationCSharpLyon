using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Créer un tableau 4, 89, 34, -23, 0, 18, -120, 456, 12, 28

            int[] tab = new int[] { 4, 89, 34, -23, 0, 18, -120, 456, 12, 28 };

            Console.WriteLine("Valeur maximale : {0}", tab.Max());
            Console.WriteLine("Valeur minimale : {0}", tab.Min());
            Console.WriteLine("Valeur moyenne : {0}", tab.Average());

            string[,] plateau = new string[3, 3];

            int max = int.MinValue;
            int min = int.MaxValue;
            int somme = 0;

            foreach(int valeur in tab)
            {
                if (valeur > max)
                    max = valeur;

                if (valeur < min)
                    min = valeur;

                somme += valeur;
            }

            Console.WriteLine("\n\nValeur maximale : {0}", max);
            Console.WriteLine("Valeur minimale : {0}", min);
            Console.WriteLine("Valeur moyenne : {0}", (double)somme / tab.Length);

            Array.Sort(tab);

            foreach(int valeur in tab)
            {
                Console.WriteLine(valeur);
            }


            Console.ReadLine();
        }
    }
}
