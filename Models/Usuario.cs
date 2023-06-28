public class Usuario{
    public int idUsuario { get; set; }
    public bool admin { get; set; }
    public string usuario { get; set; }
    public string contrasena { get; set; }

    public Usuario(){}

    public Usuario(bool a, string u, string c){
        admin = a;
        usuario = u;
        contrasena = c;
    }
}