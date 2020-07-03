using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture car = new Voiture("Audi", "Jaune", true);
            try
            {
                car.demarrer();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erreur : {0}", e.Message);
            }
           
            car.accelerer();

            car.arreter();

            Console.WriteLine(car);

            Batmobile batmobile = new Batmobile();
            batmobile.demarrer();
            batmobile.accelerer();


            Voiture auto = new Voiture("Peugeot", "Bleu");
            Voiture automobile = new Voiture("Fiat", "Rouge");

            Velo bike = new Velo();


            List<Voiture> parking = new List<Voiture>();
            parking.Add(car);
            parking.Add(auto);
            parking.Add(automobile);
            parking.Add(batmobile);

            foreach(Voiture voiture in parking)
            {
                voiture.arreter();
            }


            faireAvancer(car);
            faireAvancer(bike);
            faireAvancer(batmobile);


            Console.ReadLine();
        }


        static void faireAvancer(IRoulant mobile)
        {
            mobile.rouler();
        }

        static void faireDuBruit(IKlaxonner vehicule)
        {
            vehicule.klaxonner();
        }
    }
}
