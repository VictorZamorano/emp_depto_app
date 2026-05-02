using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VictorJosafat_Trabajo3.Data;
using VictorJosafat_Trabajo3.Models;

namespace VictorJosafat_Trabajo3.Data
{
    public class EmpleadoRepo
    {
        // Este repositorio se encarga de manejar las operaciones relacionadas con los empleados en la base de datos
        private readonly DatabaseHelper _dbHelper;

        // El constructor inicializa el helper de base de datos para usarlo en los métodos del repositorio
        public EmpleadoRepo()
        {
            _dbHelper = new DatabaseHelper();
        }

        // 1. Metodo para agregar un nuevo empleado a la base de datos
        public void AgregarEmpleado(Empleado emp, Departamento dept)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();
            string query = "INSERT INTO Empleado (rut, nombre, apellido, sueldo, codigo_depto) VALUES (@rut, @nombre, @apellido, @sueldo, @codigo_depto)";
            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@rut", emp.Rut);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
            cmd.Parameters.AddWithValue("@sueldo", emp.Sueldo);
            cmd.Parameters.AddWithValue("@codigo_depto", dept.Codigo);
            cmd.Parameters.AddWithValue("@nombre_depto", dept.NombreDepto);
            cmd.ExecuteNonQuery();
        }

        // 5. Este método obtiene una lista de empleados junto con su departamento asociado
        public DataTable ObtenerListaEmpDept()
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();
            string query = @"SELECT E.rut AS 'RUT', 
                                    E.nombre AS 'Nombre', 
                                    E.apellido AS 'Apellido', 
                                    E.sueldo AS 'Sueldo', 
                                    D.codigo AS 'Código Depto',
                                    D.nombre_depto AS 'Departamento'
                             FROM Empleado E
                             INNER JOIN Departamento D ON E.codigo_depto = D.codigo";
            MySqlDataAdapter adapter = new(query, conn);
            DataTable dt = new();
            adapter.Fill(dt);
            return dt;
        }
        // Método para buscar empleado por RUT
        public Empleado BuscarEmpleado(string rut)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = "SELECT rut, nombre, apellido, sueldo, codigo_depto FROM Empleado WHERE rut = @rut";

            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@rut", rut);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Empleado
                {
                    Rut = reader["rut"].ToString(),
                    Nombre = reader["nombre"].ToString(),
                    Apellido = reader["apellido"].ToString(),
                    Sueldo = Convert.ToDecimal(reader["sueldo"]),
                    CodigoDepto = Convert.ToInt32(reader["codigo_depto"])
                };
            }

            return null;
        }

        // Método para modificar un empleado existente
        public void ModificarEmpleado(Empleado emp)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = @"UPDATE Empleado 
                     SET nombre = @nombre,
                         apellido = @apellido,
                         sueldo = @sueldo,
                         codigo_depto = @codigo_depto
                     WHERE rut = @rut";

            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@rut", emp.Rut);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
            cmd.Parameters.AddWithValue("@sueldo", emp.Sueldo);
            cmd.Parameters.AddWithValue("@codigo_depto", emp.CodigoDepto);

            cmd.ExecuteNonQuery();
        }
    }
}