using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            //equipo0
            equipos.Add(new Equipo());
            equipos[0].Nombre = "Antolinos";
            equipos[0].CdOrigen = "Obregon";
            equipos[0].Entrenador = "Ernesto";

            equipos[0].Jugadores.Add(new Jugador("Eduardo Lalin", "7"));
            equipos[0].Jugadores.Add(new Jugador("Eduardin", "1"));
            equipos[0].Jugadores.Add(new Jugador("Robert", "3"));
            equipos[0].Jugadores.Add(new Jugador("Lalin", "5"));
            equipos[0].Jugadores.Add(new Jugador("Lalolanda", "99"));
            equipos[0].Jugadores.Add(new Jugador("Arnulfo", "8"));
            equipos[0].Jugadores.Add(new Jugador("Tibe", "4"));
            equipos[0].Jugadores.Add(new Jugador("Sanchez", "15"));
            equipos[0].Jugadores.Add(new Jugador("Saka", "64"));

            equipos.Add(new Equipo());
            equipos[1].Nombre = "Ivanzukis";
            equipos[1].CdOrigen = "La Salle";
            equipos[1].Entrenador = "Ivan D. Paso";

            equipos[1].Jugadores.Add(new Jugador("Gustavo", "1"));
            equipos[1].Jugadores.Add(new Jugador("Almada", "11"));
            equipos[1].Jugadores.Add(new Jugador("Resa", "16"));
            equipos[1].Jugadores.Add(new Jugador("Edualdo", "14"));
            equipos[1].Jugadores.Add(new Jugador("Chino", "15"));
            equipos[1].Jugadores.Add(new Jugador("Pierre", "12"));
            equipos[1].Jugadores.Add(new Jugador("Prof", "17"));
            equipos[1].Jugadores.Add(new Jugador("Eks Di", "18"));
            equipos[1].Jugadores.Add(new Jugador("C. Va Ser", "9"));

            foreach(Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre);
                Console.WriteLine("Ciudad: " + equipo.CdOrigen);
                Console.WriteLine("Entrenador: " + equipo.Entrenador);
                foreach(Jugador jugadores in equipo.Jugadores)
                {
                    Console.WriteLine("Jugador: " + jugadores.Nombre);
                    Console.WriteLine("Numero: " + jugadores.Numero);
                }
            }

            Console.ReadLine();



        }
    }
}
