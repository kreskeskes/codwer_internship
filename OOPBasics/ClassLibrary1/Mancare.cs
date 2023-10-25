using System;

namespace ClassLibrary1
{
    public abstract class Mancare
    {
        private decimal _energie;
        private decimal _greutate { get; set; }

        public decimal Energie
        {
            get
            {
                return _energie;
            }
            set
            {
                if (value >= 0m && value <= 0.05m)
                {
                    _energie = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Energie must be between 0 and 0.05.");
                }
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

    }
}
