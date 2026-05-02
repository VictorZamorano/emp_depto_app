using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        // 1. Agregar Departamento
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

        // 2. Listar Departamentos
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

        // 3. Buscar por Código
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

        // 4. Modificar Departamento
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

