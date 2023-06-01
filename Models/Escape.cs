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
            return incognitasSalas;
        }

        public static int GetEstadoJuego(){
            return estadoJuego;
        }

        public static bool ResolverSala(int Sala, string Incognita){
            return null;
        }
    }
}