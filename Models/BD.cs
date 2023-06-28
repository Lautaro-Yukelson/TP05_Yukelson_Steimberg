using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace TP05_Yukelson_Steimberg
{
    public class BD
    {
        private static string _connectionString = @"Server=localhost;DataBase=sala_de_escape;Trusted_Connection=True;";
        private static List<Jugador> _ListadoJugadores = new List<Jugador>();
        private static List<Usuario> _ListadoUsuarios = new List<Usuario>();
        
        public static void LevantarJugadores()
        {
            string sql = "SELECT * FROM Jugadores";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                _ListadoJugadores = db.Query<Jugador>(sql).ToList();
            }
        }

        public static void LevantarUsuarios()
        {
            string sql = "SELECT * FROM Usuarios";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                _ListadoUsuarios = db.Query<Usuario>(sql).ToList();
            }
        }
        
        public static Dictionary<string, Usuario> GetDiccionarioUsuarios(){
            Dictionary<string, Usuario> diccionarioUsuarios = new Dictionary<string, Usuario>();
            foreach (Usuario user in _ListadoUsuarios){
                diccionarioUsuarios.Add(user.usuario, user);
            }
            return diccionarioUsuarios;
        }

        public static List<Jugador> GetListadoJugadores()
        {
            _ListadoJugadores = _ListadoJugadores.OrderBy(j => j.tiempo).ToList();
            return _ListadoJugadores;
        }

        public static List<Usuario> GetListadoUsuarios()
        {
            return _ListadoUsuarios;
        }

        public static void AgregarJugador(Jugador Jug)
        {
            string sql = "INSERT INTO Jugadores(nombre, errores, tiempo) VALUES (@pNombre, @pErrores, @pTiempo)";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(sql, new { pNombre = Jug.nombre, pErrores = Jug.errores, pTiempo = Jug.tiempo.ToString("c") });
            }
        }

        public static void EliminarJugador(int jugadorAEliminar)
        {
            string sql = "DELETE FROM Jugadores WHERE idJugador = @id";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(sql, new {id = jugadorAEliminar});
            }
        }
    }
}