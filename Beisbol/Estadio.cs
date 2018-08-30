using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Estadio
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }

        public Estadio (string nombre, string direccion, int capacidad)
        {
            Nombre = nombre;
            Direccion = direccion;
            Capacidad = capacidad;
        }
        public Estadio()
        {

        }

    }
}
