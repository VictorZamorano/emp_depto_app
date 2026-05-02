using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VictorJosafat_Trabajo3.Data
{
    // Singleton para manejar la conexión a la base de datos
    public class DatabaseHelper
    {
        private readonly string connectionString = "Server=localhost;Database=trabajo3;Uid=root;Pwd=;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}