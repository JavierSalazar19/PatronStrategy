using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Implementacion
{
    public class Equiposdefutbol
    {
        public int NumeroDeJugadores { get; set; }
        public string? Director { get; set; }

        private IEstrategiaDeJuego _estrategiaDeJuego;

        public void SetEstrategiaDeJuego(IEstrategiaDeJuego estrategiaDeJuego)
        {
            _estrategiaDeJuego = estrategiaDeJuego;
        }

        public void MostrarEstrategia()
        {
            _estrategiaDeJuego.Jugar();
        }
    }
}
