public static class Escape
{
    public static List<string> incognitasSalas { get; set; } = new List<string>{};
    private static List<Jugador> Jugadores { get; set; } = new List<Jugador>{
        new Jugador("Messi", ((new DateTime(2023, 12, 12, 19, 0, 30))-(new DateTime(2023, 12, 12, 19, 0, 0))), 0),
        new Jugador("Superman", ((new DateTime(2023, 12, 12, 19, 1, 30))-(new DateTime(2023, 12, 12, 19, 0, 0))), 1)
    };
    private static int estadoJuego { get; set; } = 0;
    private static int cantErrores { get; set;} = 0;
    private static bool yaTermino { get; set;} = false;
    public static bool primeraVez { get; set;}
    public static bool resuelto { get; set; }
    private static TimeOnly horaInicio { get; set; }
    private static TimeSpan tiempoTranscurrido { get; set;}

    private static void InicializarJuego(){
        incognitasSalas.Add("motosierra"); // A Jack Baker usa la... 
        incognitasSalas.Add("Holomorfos"); // Nombre del enemigo del juego
        incognitasSalas.Add("1408"); // Codigo minijuego cumpleaños
        incognitasSalas.Add("no se lo come"); // En la comida familiar luego de la primera pelea con mia, la madre se estresa por que ethan...
        incognitasSalas.Add("loser"); // Contraseña para la valvula --> Minijuego cumpleaños
        incognitasSalas.Add("10:15"); // Hora para poner el reloj para conseguir la llave roja.
        incognitasSalas.Add("mr-everywhere"); // Donde estan los coleccionables cabezones?
        incognitasSalas.Add("huella"); // Tres a y una huella
        incognitasSalas.Add("evelyn"); // ella solo queria una flia

        horaInicio = TimeOnly.FromDateTime(DateTime.Now);

    }

    public static int GetEstadoJuego(){
        if (estadoJuego == 0) { InicializarJuego(); estadoJuego++; }
        return estadoJuego;
    }

    public static void ResetearJuego(){
        estadoJuego = 1;
        yaTermino = false;
        horaInicio = TimeOnly.FromDateTime(DateTime.Now);
    }

    public static int GetErrores(){
        return cantErrores;
    }

    public static List<Jugador> GetJugadores(){
        return Jugadores;
    }

    public static void AgregarJugador(Jugador nuevoJugador){
        Jugadores.Add(nuevoJugador);
    }

    public static void OrdenarJugadores(){
        Jugadores = Jugadores.OrderBy(j => j.Tiempo).ToList();
    }

    public static bool ResolverSala(int sala, string incognita){
        Escape.primeraVez = false;
        if (incognita == incognitasSalas[sala - 1]){
            estadoJuego++;
            return true;
        } else {
            cantErrores++;
            return false;
        }
    }
    public static TimeSpan TerminarJuego(){
        if (!yaTermino){
            TimeOnly horaFin = TimeOnly.FromDateTime(DateTime.Now);
            tiempoTranscurrido = horaFin - horaInicio;
            yaTermino = true;
        }
        return tiempoTranscurrido;
    }
}
