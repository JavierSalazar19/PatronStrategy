using PatronStrategy.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Estrategias
{
    public class PresionarAlta : IEstrategiaDeJuego
    {
        public void Jugar()
        {
            Console.WriteLine("Presion Alta");
        }
    }
}
