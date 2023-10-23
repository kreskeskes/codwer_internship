namespace ClassLibrary1
{
    public class Omnivor : Animal
    {
        public Omnivor(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime) : base(name, greutate, viteza, lungime, latime, inaltime)
        {
        }

        public override double Energie<T>(T obj)
        {
            if (obj.GetType() == typeof(Omnivor))
            {
                Omnivor temp = obj as Omnivor;
                double mediaGreutateMancare = 0;
                double sumaEnergiaMancare = 0;
                double coef = 0;

                foreach (Mancare food in temp.Stomac)
                {
                    mediaGreutateMancare += (double)food.Greutate;
                    sumaEnergiaMancare += (double)food.Energie;
                    if (food.GetType() == typeof(Planta))
                    {
                        coef -= 0.5;
                    }
                    else if (food.GetType() == typeof(Carne))
                    {
                        coef += 0.5;
                    }
                }
                mediaGreutateMancare /= temp.Stomac.Count;
                double nivelulDeEnergie = 0.35 + coef * mediaGreutateMancare + sumaEnergiaMancare;
                return nivelulDeEnergie;
            }
            else
            {
                return 0;
            }
        }
    }
}
