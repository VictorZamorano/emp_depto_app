using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VictorJosafat_Trabajo3.Data;
using VictorJosafat_Trabajo3.Models;

namespace VictorJosafat_Trabajo3.Forms
{
    public partial class FrmListDepto : Form
    {
        public FrmListDepto()
        {
            InitializeComponent();
        }

        private void FrmListDepto_Load(object sender, EventArgs e)
        {
            // Formatea el DataGridView para mostrar los datos de forma clara
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                // Obtiene los datos de empleados y departamentos usando el repositorio
                DeptoRepo deptoRepo = new();
                var listaDepartamentos = deptoRepo.ListarDepartamentos();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaDepartamentos;

                if (dataGridView1.Columns["NombreDepto"] != null)
                    dataGridView1.Columns["NombreDepto"]?.HeaderText = "Nombre del Departamento";
                    
                if (dataGridView1.Columns["Codigo"] != null)
                    dataGridView1.Columns["Codigo"]?.HeaderText = "Código ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
    }
}
