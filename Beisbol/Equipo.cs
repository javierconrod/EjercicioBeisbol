using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CdOrigen { get; set; }
        public string Entrenador { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public Estadio estadio { get; set; }


        public Equipo()
        {
            Nombre = "Equipo Nuevo";
            CdOrigen = "Ciudad";
            Entrenador = "Entrenador";
            Jugadores = new List<Jugador>();
        }

        
        

    }
}
