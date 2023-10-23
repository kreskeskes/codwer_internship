using System;

namespace ClassLibrary1
{
    public abstract class Mancare
    {
        public decimal energie_field;
        public decimal Greutate { get; set; }

        public decimal Energie
        {
            get
            {
                return energie_field;
            }
            set
            {
                if (value >= 0m && value <= 0.05m)
                {
                    energie_field = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Energie must be between 0 and 0.05.");
                }
            }
        }
    }
}
