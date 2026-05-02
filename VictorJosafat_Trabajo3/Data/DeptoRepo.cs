using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using VictorJosafat_Trabajo3.Models;

namespace VictorJosafat_Trabajo3.Data
{
    public class DeptoRepo
    {
        private readonly DatabaseHelper _dbHelper;

        public DeptoRepo()
        {
            _dbHelper = new DatabaseHelper();
        }

        // 1. Este método agrega un nuevo empleado a la base de datos, asociándolo con un departamento específico
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

        // 2. Este método obtiene una lista de empleados junto con su departamento asociado
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

        // 3. Agregar Departamento
        public void AgregarDepartamento(Departamento d)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = "INSERT INTO Departamento (codigo, nombre_depto) VALUES (@codigo, @nombre_depto)";

            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@codigo", d.Codigo);
            cmd.Parameters.AddWithValue("@nombre_depto", d.NombreDepto);

            cmd.ExecuteNonQuery();
        }

        // 4. Listar Departamentos
        public List<Departamento> ListarDepartamentos()
        {
            List<Departamento> lista = new();

            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = "SELECT codigo, nombre_depto FROM Departamento";

            MySqlCommand cmd = new(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Departamento
                {
                    Codigo = Convert.ToInt32(reader["codigo"]),
                    NombreDepto = reader["nombre_depto"].ToString()
                });
            }

            return lista;
        }

        // 5. Buscar por Código
        public Departamento BuscarPorCodigo(int codigo)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = "SELECT codigo, nombre_depto FROM Departamento WHERE codigo = @codigo";

            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Departamento
                {
                    Codigo = Convert.ToInt32(reader["codigo"]),
                    NombreDepto = reader["nombre_depto"].ToString()
                };
            }

            return null;
        }

        // 6. Modificar Departamento
        public void ModificarDepartamento(Departamento d)
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            string query = "UPDATE Departamento SET nombre_depto = @nombre_depto WHERE codigo = @codigo";

            MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@codigo", d.Codigo);
            cmd.Parameters.AddWithValue("@nombre_depto", d.NombreDepto);

            cmd.ExecuteNonQuery();
        }
    }
}

