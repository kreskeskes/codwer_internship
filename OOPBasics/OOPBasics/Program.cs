using ClassLibrary1;

namespace OOPBasics
{
    internal class Program
    {
        static void Main()
        {
            Carnivor carnivor1 = new Carnivor("Lup", 70, 15, 1.5m, 0.5m, 0.75m);
            Erbivor oaie1 = new Erbivor("Oaie", 35, 7, 1m, 0.3m, 0.45m);
            Omnivor urs1 = new Omnivor("Lup", 70, 15, 1.5m, 0.5m, 0.75m);

            Planta salata = new Planta();
            Carne sunca = new Carne();
        }
    }
}
