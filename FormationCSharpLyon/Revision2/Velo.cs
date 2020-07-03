using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    public class Velo : IRoulant, IKlaxonner
    {
        public void klaxonner()
        {
            Console.WriteLine("Dring Dring");
        }

        public void rouler()
        {
            Console.WriteLine("Le vélo roule");
        }
    }
}
