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

                }
            }
        }
    }
}
