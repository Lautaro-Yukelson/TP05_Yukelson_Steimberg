using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP05_Yukelson_Steimberg.Models
{
    public static class Escape{
        public static List<string> incognitasSalas { get; set; } = new List<string>{};
        private static int estadoJuego { get; set; } = 0;
    
        private static void InicializarJuego(){
            incognitasSalas.Add("motosierras"); // Jack Baker y su obsesion con las 
            incognitasSalas.Add("muñeca"); // Objeto que de cierta forma representa a Eveline
            incognitasSalas.Add("no se lo come"); // En la comida familiar luego de la primera pelea con mia, la madre se estresa por que ethan...
            incognitasSalas.Add("1408"); // Codigo minijuego cumpleaños
            incognitasSalas.Add("loser"); // Contraseña para la valvula --> Minijuego cumpleaños
            incognitasSalas.Add("10:15"); // Hora para poner el reloj para conseguir la llave roja.
            incognitasSalas.Add("everywhere"); // Donde estan los coleccionables cabezones?
            incognitasSalas.Add("albert-01R"); // Pistola que se desbloquea al terminar el juego.
            incognitasSalas.Add("mia/zoe"); // A quien salvas? Dos finales distintos
        }

        public static int GetEstadoJuego(){
            if(estadoJuego == 0){InicializarJuego(); estadoJuego++;}
            return estadoJuego;
        }

        public static bool ResolverSala(int sala, string incognita){
            if (incognita == incognitasSalas[sala-1]){
                estadoJuego++;
                return true;
            }
            return false;
        }
    }
}