using PatronStrategy.Estrategias;
using PatronStrategy.Implementacion;

namespace PatronStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mexico");
            Equiposdefutbol mexico = new Equiposdefutbol();
            mexico.SetEstrategiaDeJuego(new PresionarAlta());
            mexico.MostrarEstrategia();

            Console.WriteLine("Argentina");
            Equiposdefutbol argentina = new Equiposdefutbol();
            argentina.SetEstrategiaDeJuego(new PosesionDePelota());
            argentina.MostrarEstrategia();

            Console.WriteLine("Brasil");
            Equiposdefutbol brasil = new Equiposdefutbol();
            brasil.SetEstrategiaDeJuego(new Contragolpe());
            brasil.MostrarEstrategia();
        }
    }
}