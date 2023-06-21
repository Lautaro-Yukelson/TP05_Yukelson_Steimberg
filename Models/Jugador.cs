public class Jugador
{
    public string Nombre { get; private set; }
    public TimeSpan Tiempo { get; private set; }
    public int Errores { get; private set; }

    public Jugador(string nombre, TimeSpan tiempo, int errores){
        Nombre = nombre;
        Tiempo = tiempo;
        Errores = errores;
    }
}
