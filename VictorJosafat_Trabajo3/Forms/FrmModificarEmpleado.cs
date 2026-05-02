using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Windows.Forms;
using VictorJosafat_Trabajo3.Data;
using VictorJosafat_Trabajo3.Models;

namespace VictorJosafat_Trabajo3.Forms
{
    public partial class FrmModificarEmpleado : Form
    {
        private readonly EmpleadoRepo _empRepo;
        private readonly DeptoRepo _deptoRepo;
        private Empleado _empleadoActual;

        public FrmModificarEmpleado()
        {
            InitializeComponent();
            _empRepo = new EmpleadoRepo();
            _deptoRepo = new DeptoRepo();

            CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            var lista = _deptoRepo.ListarDepartamentos();
            cmbDepto.DataSource = lista;
            cmbDepto.DisplayMember = "NombreDepto";
            cmbDepto.ValueMember = "Codigo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Debe ingresar un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _empleadoActual = _empRepo.BuscarEmpleado(txtRut.Text.Trim());

            if (_empleadoActual == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cargar datos en los controles
            txtNombre.Text = _empleadoActual.Nombre;
            txtApellido.Text = _empleadoActual.Apellido;
            txtSueldo.Text = _empleadoActual.Sueldo.ToString();

            // Seleccionar departamento en ComboBox
            cmbDepto.SelectedValue = _empleadoActual.CodigoDepto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_empleadoActual == null)
            {
                MessageBox.Show("Debe buscar un empleado primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo))
            {
                MessageBox.Show("El sueldo debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar datos
            _empleadoActual.Nombre = txtNombre.Text.Trim();
            _empleadoActual.Apellido = txtApellido.Text.Trim();
            _empleadoActual.Sueldo = sueldo;
            _empleadoActual.CodigoDepto = (int)cmbDepto.SelectedValue;

            try
            {
                _empRepo.ModificarEmpleado(_empleadoActual);
                MessageBox.Show("Empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}