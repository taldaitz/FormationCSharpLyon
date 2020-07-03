using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            Game jeu = new Game();
            jeu.start();

            Console.ReadLine();
        }
    }
}
