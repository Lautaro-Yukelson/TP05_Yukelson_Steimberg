using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP05_Yukelson_Steimberg.Models
{
    public static class Escape{
        private static string[] incognitasSalas { get; set; }
        private static int estadoJuego { get; set; } = 1;

        private static void InicializarJuego(){
            incognitasSalas.Append("motosierra"); // Objeto favorito del padre
            incognitasSalas.Append("muñeca"); // Representación de Eveline
            incognitasSalas.Append("1408"); // Codigo minijuego cumpleaños
            incognitasSalas.Append("loser"); // Contraseña para la valvula --> Minijuego cumpleaños
            incognitasSalas.Append("10:15"); // Hora para poner el reloj para conseguir la llave roja.
            incognitasSalas.Append("no se lo come"); // La vieja se estresa porque...
            incognitasSalas.Append("everywhere"); // Donde estan los coleccionables cabezones?
            incognitasSalas.Append("albert-01R"); // Pistola que se desbloquea al terminar el juego.
            incognitasSalas.Append("mia/zoe"); // A quien salvas? Dos finales distintos
        }

        public static int GetEstadoJuego(){
            return estadoJuego;
        }

        public static bool ResolverSala(int Sala, string Incognita){
            return true;
        }
    }
}