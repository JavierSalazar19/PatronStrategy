using PatronStrategy.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Estrategias
{
    public class Contragolpe : IEstrategiaDeJuego
    {
        public void Jugar()
        {
            Console.WriteLine("Defender y jugar a contra");
        }
    }
}
