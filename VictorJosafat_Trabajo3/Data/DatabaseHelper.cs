using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VictorJosafat_Trabajo3.Data
{
    // Singleton para manejar la conexión a la base de datos
    public class DatabaseHelper
    {
        // Cadena de conexión a la base de datos MySQL - MODIFICAR CON TUS DATOS
        private readonly string connectionString = "Server=127.0.0.1;Database=dept_emp_db;Uid=root;Password=;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}