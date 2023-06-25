public class Jugador{
    public int idJugador { get; set; }
    public string nombre { get; set; }
    public int errores { get; set; }
    public TimeSpan tiempo { get; set; }

    public Jugador(){}

    public Jugador(string n, int e, TimeSpan t){
        nombre = n;
        errores = e;
        tiempo = t;
    }
}