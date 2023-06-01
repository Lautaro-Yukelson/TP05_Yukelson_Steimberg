using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP05_Yukelson_Steimberg.Models
{
    public class Habitaciones{
        public int ID {get; private set;} = 1;
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public static List<string> Multimedia { get; private set; } = new List<string> { "imagen" };
        public string Acertijo {get; private set; }
        public string Pista {get; private set; }

        public Habitaciones(string titulo, string descripcion, List<string> multimedia, string acertijo, string pista){
            ID = agregarId();
            Titulo = titulo;
            Descripcion = descripcion;
            Multimedia = multimedia;
            Acertijo = acertijo;
            Pista = pista;
        }

        public int agregarId(){
            ID++;
            return ID--;
        }
    }
}