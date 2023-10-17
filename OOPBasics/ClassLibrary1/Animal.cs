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

        private List<Mancare> Stomac { get; set; }


        Animal(string name, decimal greutate, decimal viteza, decimal lungime, decimal latime, decimal inaltime)
        {
            _name = name;
            _greutate = greutate;
            _viteza = viteza;
            _lungime = lungime;
            _latime = latime;
            _inaltime = inaltime;
        }
    }
}
