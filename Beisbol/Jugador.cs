using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Nuevo Jugador";
            Numero = "0";
        }
        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

    }
}
