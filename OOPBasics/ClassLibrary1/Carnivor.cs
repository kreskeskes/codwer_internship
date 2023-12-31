﻿namespace ClassLibrary1
{
    public class Carnivor : Animal
    {
        public Carnivor(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime) : base(name, greutate, viteza, lungime, latime, inaltime)
        {

        }

        public override double Energie()
        {
            if (this.GetType() == typeof(Carnivor))
            {
                Carnivor temp = this as Carnivor;
                double mediaGreutateMancare = 0;
                double sumaEnergiaMancare = 0;

                foreach (Mancare food in temp.Stomac)
                {
                    if (food.GetType() == typeof(Carne))
                    {
                        mediaGreutateMancare += (double)food.Greutate;
                        sumaEnergiaMancare += (double)food.Energie;
                    }

                }
                mediaGreutateMancare /= temp.Stomac.Count;
                double nivelulDeEnergie = 0.2 - 1 / 5 * mediaGreutateMancare + sumaEnergiaMancare;
                return nivelulDeEnergie;
            }
            else
            {
                return 0;
            }
        }
    }
}
