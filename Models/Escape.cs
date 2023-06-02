using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP05_Yukelson_Steimberg.Models
{
    public static class Escape{
        private static string[] incognitasSalas { get; set; }
        private static int estadoJuego { get; set; } = 1;
        public static List<Habitaciones> ListaHabitaciones = new List<Habitaciones>{};

        private static void InicializarJuego(){
            // Generales
            incognitasSalas.Append("motosierras"); // Jack Baker y su obsesion con las 
            incognitasSalas.Append("muñeca"); // Objeto que de cierta forma representa a Eveline
            incognitasSalas.Append("no se lo come"); // En la comida familiar luego de la primera pelea con mia, la madre se estresa por que ethan...

            incognitasSalas.Append("1408"); // Codigo minijuego cumpleaños
            incognitasSalas.Append("loser"); // Contraseña para la valvula --> Minijuego cumpleaños
            incognitasSalas.Append("10:15"); // Hora para poner el reloj para conseguir la llave roja.
            incognitasSalas.Append("everywhere"); // Donde estan los coleccionables cabezones?
            incognitasSalas.Append("albert-01R"); // Pistola que se desbloquea al terminar el juego.
            incognitasSalas.Append("mia/zoe"); // A quien salvas? Dos finales distintos

            ListaHabitaciones.Add(new Habitaciones("Titulo", "Descripcion", new List<string>{"fondo.webp"}, "Acertijo", "Pista"));
            ListaHabitaciones.Add(new Habitaciones("Titulo", "Descripcion", new List<string>{"fondo.webp"}, "Acertijo", "Pista"));
            ListaHabitaciones.Add(new Habitaciones("Titulo", "Descripcion", new List<string>{"fondo.webp"}, "Acertijo", "Pista"));
        }

        public static int GetEstadoJuego(){
            return estadoJuego;
        }
        
        public static List<Habitaciones> GetHabitaciones(){
            return ListaHabitaciones;
        }

        public static bool ResolverSala(int Sala, string Incognita){
            return true;
        }
    }
}