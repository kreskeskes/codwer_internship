using ClassLibrary1;
using System;
using System.Collections.Generic;
using static ClassLibrary1.Animal;
namespace OOPBasics
{
    public class Program
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();
            Carnivor lup1 = new Carnivor("Lup", 70, 15, 1.89m, 0.5m, 0.75m);
            animals.Add(lup1);
            Erbivor oaie1 = new Erbivor("Oaie", 35, 7, 0.3m, 0.3m, 0.45m);
            animals.Add(oaie1);
            Omnivor urs1 = new Omnivor("Urs", 170, 17, 1.5m, 0.5m, 0.75m);
            animals.Add(urs1);


            Planta salata = new Planta() { Greutate = 0.1m, Energie = 0.025m };
            Carne sunca = new Carne() { Greutate = 0.5m, Energie = 0.05m };


            //mancare
            lup1.Mananca(sunca);
            lup1.Mananca(sunca);

            oaie1.Mananca(salata);
            oaie1.Mananca(salata);
            oaie1.Mananca(salata);

            urs1.Mananca(sunca);
            urs1.Mananca(salata);
            urs1.Mananca(salata);
            urs1.Mananca(salata);

            //nivel de energie
            Console.WriteLine($"{lup1.Name} are {lup1.Energie()}% de energie");
            Console.WriteLine($"{urs1.Name} are {urs1.Energie()}% de energie");
            Console.WriteLine($"{oaie1.Name} are {oaie1.Energie()}% de energie");


            //alergare
            decimal distanta = 200;
            lup1.Alearga(distanta);
            oaie1.Alearga(distanta);
            urs1.Alearga(distanta);

            string nume;
            decimal greutate;
            int switchChoice;
            Dimensiune dimensiune = new Dimensiune();
            //second animal list
            List<Animal> secondAnimalList = new List<Animal>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                nume = "Animal";

                greutate = random.Next(5, 300);

                dimensiune.Inaltime = random.Next(5, 300);
                dimensiune.Latime = random.Next(5, 300);
                dimensiune.Lungime = random.Next(5, 300);

                switchChoice = random.Next(0, 5);
                TipAnimal tipAnimal = (TipAnimal)switchChoice;
                decimal viteza = random.Next(5, 300);
                secondAnimalList.Add(Program.CreazaAnimal(tipAnimal, nume, greutate, dimensiune, viteza));
            }

            int countOfCarnivorsEating = 0;
            int countOfErbivorsEating = 0;
            //Afișează următoarele statistici
            List<Animal> finalAnimalList = new List<Animal>();
            finalAnimalList.AddRange(animals);
            finalAnimalList.AddRange(secondAnimalList);
            int countOfAnimalsEating = finalAnimalList.Count;

            //feeding in regards with type.
            foreach (Animal animal in finalAnimalList)
            {
                if (animal.GetType() == typeof(Carnivor))
                {
                    animal.Mananca(sunca);
                    countOfCarnivorsEating++;

                }
                else if (animal.GetType() == typeof(Erbivor))
                {
                    countOfErbivorsEating++;
                    animal.Mananca(salata);
                }
                else if (animal.GetType() == typeof(Omnivor))
                {

                    int randomFood = random.Next(1, 2);
                    if (randomFood == 1)
                    {
                        countOfErbivorsEating++;
                        animal.Mananca(salata);
                    }
                    else if (randomFood == 2)
                    {
                        countOfCarnivorsEating++;
                        animal.Mananca(sunca);
                    }

                }

            }



            Console.WriteLine($"{countOfAnimalsEating} animale mancanca mancare");
            Console.WriteLine($"{countOfCarnivorsEating} animale mancanca carne");
            Console.WriteLine($"{countOfErbivorsEating} animale mancanca plante");

            Animal.AnimalCount = finalAnimalList.Count;// numar total de animale

            foreach (Animal animal in finalAnimalList)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.ReadKey();

        }

        public static Animal CreazaAnimal(TipAnimal tipAnimal, string nume, decimal greutate,
Dimensiune dimensiune, decimal viteza)
        {
            Animal createdAnimal = null;

            switch (tipAnimal)
            {
                case TipAnimal.Lup:
                    return new Carnivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

                case TipAnimal.Urs:
                    return new Omnivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

                case TipAnimal.Oaie:
                    return new Erbivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

                case TipAnimal.Veverita:
                    return new Erbivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

                case TipAnimal.Pisica:
                    return new Omnivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

                case TipAnimal.Vaca:
                    return new Erbivor(nume, greutate, viteza, dimensiune.Lungime, dimensiune.Latime, dimensiune.Inaltime);

            }
            return createdAnimal;
        }
    }
    public enum TipAnimal
    {
        Lup, Urs, Oaie, Veverita, Pisica, Vaca
    }
}
