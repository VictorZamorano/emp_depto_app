using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VictorJosafat_Trabajo3.Data;

namespace VictorJosafat_Trabajo3.Forms
{
    public partial class FrmList : Form
    {
        readonly DatabaseHelper dbHelper = new();

        public FrmList()
        {
            InitializeComponent();
        }

        // Carga los datos de empleados y departamentos al abrir el formulario
        private void FrmList_Load(object sender, EventArgs e)
        {
            // Formatea el DataGridView para mostrar los datos de forma clara
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                // Obtiene los datos de empleados y departamentos usando el repositorio
                EmpleadoRepo empleadoRepo = new();
                DataTable dt = empleadoRepo.ObtenerListaEmpDept();
                dataGridView1.DataSource = dt;

                var columnSueldo = dataGridView1.Columns["Sueldo"];
                // Si la columna "Sueldo" existe, se formatea para mostrar los valores como moneda
                columnSueldo?.DefaultCellStyle.Format = "C0"; // Formato de moneda

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
    }
}
