using System;

namespace ClassLibrary1
{
    public class Omnivor : Animal
    {
        public Omnivor(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime) : base(name, greutate, viteza, lungime, latime, inaltime)
        {
        }

        public override double Energie()
        {
            throw new NotImplementedException();
        }
    }
}
