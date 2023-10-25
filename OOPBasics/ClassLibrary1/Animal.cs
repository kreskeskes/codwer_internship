using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        //fileds
        private string _name;
        private decimal _greutate;
        private decimal _viteza;
        private decimal _latime;
        private decimal _lungime;
        private decimal _inaltime;



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

        private protected decimal Greutate
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

        private decimal Latime
        {
            get
            {
                return _latime;
            }
            set
            {
                _latime = value;
            }
        }
        private decimal Lungime
        {
            get
            {
                return _lungime;
            }
            set
            {
                _lungime = value;
            }
        }
        private decimal Inaltime
        {
            get
            {
                return _inaltime;
            }
            set
            {
                _inaltime = value;
            }
        }

        private protected decimal Viteza
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

        private protected List<Mancare> Stomac { get; set; }


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
        public void Mananca(Mancare m)
        {
            if (this.Stomac == null)
            {
                this.Stomac = new List<Mancare>();
            }
            if (this.GetType() == typeof(Carnivor))
            {
                Carnivor carnivor = (Carnivor)this;

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
            else if (this.GetType() == typeof(Omnivor))
            {
                Omnivor omnivor = (Omnivor)this;
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
            else if (this.GetType() == typeof(Erbivor))
            {
                Erbivor erbivor = (Erbivor)this;
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

        public abstract double Energie();

        public void Alearga(decimal distanta)
        {
            double timp = (double)distanta / ((double)this.Viteza / this.Energie());

            Console.WriteLine($"{timp:F2} secunde is unui {this.Name} sa alerge distanta de {distanta} metri");
        }

        public override string ToString()
        {

            return $"\nTip Animal: {this.GetType().Name}\nAnimal: {Name}, \n{Greutate} kg, \nDimensiuni: L {this.Lungime}, I {this.Inaltime}, l {this.Latime} ";
        }
    }
}
