using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace VictorJosafat_Trabajo3.Data
{
    // Esta clase se encarga de insertar datos de prueba en la base de datos
    public class DataSeeder
    {
        private readonly DatabaseHelper _dbHelper;

        public DataSeeder()
        {
            _dbHelper = new DatabaseHelper();
        }

        public void InicializarDatos()
        {
            using var conn = _dbHelper.ObtenerConexion();
            conn.Open();

            // Eliminar datos existentes para evitar duplicados
            string sqlDeleteEmpleados = "DELETE FROM Empleado;";
            string sqlDeleteDepartamentos = "DELETE FROM Departamento;";

            using (var cmd = new MySqlCommand(sqlDeleteEmpleados, conn))
            {
                cmd.ExecuteNonQuery();
            }

            using (var cmd = new MySqlCommand(sqlDeleteDepartamentos, conn))
            {
                cmd.ExecuteNonQuery();
            }

            // 1. Insertar Departamentos
            string sqlDeptos = @"INSERT IGNORE INTO Departamento (codigo, nombre_depto) VALUES 
                                    (10, 'Informática'),
                                    (20, 'Recursos Humanos'),
                                    (30, 'Contabilidad'),
                                    (40, 'Ventas');";

            using (var cmd = new MySqlCommand(sqlDeptos, conn))
            {
                cmd.ExecuteNonQuery();
            }

            // 2. Insertar Empleados
            string sqlEmpleados = @"INSERT IGNORE INTO Empleado (rut, nombre, apellido, sueldo, codigo_depto) VALUES 
                                        ('12.323.444-1', 'Allan', 'Brown', 800000, 10),
                                        ('22.444.555-K', 'Maria', 'Pinto', 950000, 10),
                                        ('33.555.666-3', 'Carlos', 'Soto', 750000, 20),
                                        ('44.666.777-4', 'Ana', 'Luz', 1200000, 30),
                                        ('55.777.888-5', 'Victor', 'Jara', 880000, 40);";

            using (var cmd = new MySqlCommand(sqlEmpleados, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
