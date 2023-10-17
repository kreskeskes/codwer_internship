namespace ClassLibrary1
{
    public class Carnivor : Animal
    {
        public Carnivor(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime) : base(name, greutate, viteza, lungime, latime, inaltime)
        {

        }

        public string Name { get; set; }
        public decimal Greutate { get; set; }
        public decimal Viteza { get; set; }
    }
}
