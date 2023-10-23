using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        //fileds
        public string _name;
        public decimal _greutate;
        public decimal _viteza;
        public decimal _latime;
        public decimal _lungime;
        public decimal _inaltime;


        public static int AnimalCount;


        //properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public decimal Greutate
        {
            get
            {
                return _greutate;
            }
            set
            {
                _greutate = value;
            }
        }



        public decimal Viteza
        {
            get
            {
                return _viteza;
            }
            set
            {
                _viteza = value;
            }
        }

        public struct Dimensiune
        {
            public decimal Lungime { get; set; }
            public decimal Latime { get; set; }
            public decimal Inaltime { get; set; }

        }

        public List<Mancare> Stomac { get; set; }


        //constructor
        public Animal(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime)
        {
            _name = name;
            _greutate = greutate;
            _viteza = viteza;
            _lungime = lungime;
            _latime = latime;
            _inaltime = inaltime;
        }


        //methods
        public void Mananca(Mancare m, Animal animal)
        {
            if (animal.GetType() == typeof(Carnivor))
            {
                Carnivor carnivor = (Carnivor)animal;

                if (m.GetType() == typeof(Carne))
                {
                    Carne carne = (Carne)m;
                    if (carne.Greutate < (carnivor.Greutate / 8))
                    {
                        carnivor.Stomac.Add(carne);
                        Console.WriteLine($"{carnivor.Name} mananca");
                    }
                }
            }
            else if (animal.GetType() == typeof(Omnivor))
            {
                Omnivor omnivor = (Omnivor)animal;
                if (m.GetType() == typeof(Planta))
                {
                    Planta planta = (Planta)m;
                    if (planta.Greutate < (omnivor.Greutate / 8))
                    {
                        omnivor.Stomac.Add(planta);
                        Console.WriteLine($"{omnivor.Name} mananca");
                    }
                }
                else if (m.GetType() == typeof(Carne))
                {
                    Carne carne = (Carne)m;
                    if (carne.Greutate < (omnivor.Greutate / 8))
                    {
                        omnivor.Stomac.Add(carne);
                        Console.WriteLine($"{omnivor.Name} mananca");
                    }
                }
            }
            else if (animal.GetType() == typeof(Erbivor))
            {
                Erbivor erbivor = (Erbivor)animal;
                if (m.GetType() == typeof(Planta))
                {
                    Planta planta = (Planta)m;
                    if (planta.Greutate < (erbivor.Greutate / 8))
                    {
                        erbivor.Stomac.Add(planta);
                        Console.WriteLine($"{erbivor.Name} mananca");
                    }
                }

            }




        }
        public abstract double Energie<T>(T obj) where T : Animal;

        public void Alearga(decimal distanta, Animal animal)
        {
            double timp = (double)distanta / ((double)animal.Viteza / animal.Energie(animal));

            Console.WriteLine($"{timp:F2} secunde is unui {animal.Name} sa alerge distanta de {distanta} metri");
        }
    }
}
