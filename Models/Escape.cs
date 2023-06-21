public static class Escape
{
    public static List<string> incognitasSalas { get; set; } = new List<string> { };
    private static int estadoJuego { get; set; } = 0;
    private static int cantErrores { get; set;} = 0;
    public static TimeOnly horaInicio { get; set; } = TimeOnly.FromDateTime(DateTime.Now);


    private static void InicializarJuego()
    {
        incognitasSalas.Add("motosierra"); // A Jack Baker usa la... 
        incognitasSalas.Add("Holomorfos"); // Nombre del enemigo del juego
        incognitasSalas.Add("1408"); // Codigo minijuego cumpleaños
        incognitasSalas.Add("no se lo come"); // En la comida familiar luego de la primera pelea con mia, la madre se estresa por que ethan...
        incognitasSalas.Add("loser"); // Contraseña para la valvula --> Minijuego cumpleaños
        incognitasSalas.Add("10:15"); // Hora para poner el reloj para conseguir la llave roja.
        incognitasSalas.Add("mr-everywhere"); // Donde estan los coleccionables cabezones?
        incognitasSalas.Add("huella"); // Tres a y una huella
        incognitasSalas.Add("evelyn"); // ella solo queria una flia
    }

    public static int GetEstadoJuego()
    {
        if (estadoJuego == 0) { InicializarJuego(); estadoJuego++; }
        return estadoJuego;
    }

    public static int GetErrores(){
        return cantErrores;
    }

    public static bool ResolverSala(int sala, string incognita)
    {
        if (incognita == incognitasSalas[sala - 1])
        {
            estadoJuego++;
            return true;
        } else {
            cantErrores++;
            return false;
        }
        
    }
    public static TimeSpan TerminarJuego(){
        TimeOnly horaFin = TimeOnly.FromDateTime(DateTime.Now);
        TimeSpan tiempoTranscurrido = horaFin - horaInicio;
        return tiempoTranscurrido;
    }
}
