using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace OOPBasics
{
    internal class Program
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            Carnivor lup1 = new Carnivor("Lup", 70, 15, 1.89m, 0.5m, 0.75m);
            animals.Add(lup1);
            Erbivor oaie1 = new Erbivor("Oaie", 35, 7, 0.3m, 0.3m, 0.45m);
            animals.Add(oaie1);
            Omnivor urs1 = new Omnivor("Urs", 170, 17, 1.5m, 0.5m, 0.75m);
            animals.Add(urs1);

            Animal.AnimalCount = animals.Count;// numar total de animale

            Planta salata = new Planta() { Greutate = 0.10m, Energie = 0.025m };
            Carne sunca = new Carne() { Greutate = 0.25m, Energie = 0.05m };

            lup1.Stomac = new List<Mancare>();
            oaie1.Stomac = new List<Mancare>();
            urs1.Stomac = new List<Mancare>();

            //mancare
            lup1.Mananca(sunca, lup1);
            lup1.Mananca(sunca, lup1);

            oaie1.Mananca(salata, oaie1);
            oaie1.Mananca(salata, oaie1);
            oaie1.Mananca(salata, oaie1);

            urs1.Mananca(sunca, urs1);
            urs1.Mananca(salata, urs1);
            urs1.Mananca(salata, urs1);
            urs1.Mananca(salata, urs1);

            //alergare
            decimal distanta = 200;
            lup1.Alearga(distanta, lup1);
            oaie1.Alearga(distanta, oaie1);
            urs1.Alearga(distanta, urs1);


            Console.ReadKey();

        }
    }
}
