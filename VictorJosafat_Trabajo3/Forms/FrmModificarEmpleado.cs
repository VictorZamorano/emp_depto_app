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
        private Empleado? _empleadoActual;

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

            // Buscamos (el repo ya se encarga de limpiar el parámetro)
            _empleadoActual = _empRepo.BuscarEmpleado(txtRut.Text);

            if (_empleadoActual == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Al asignar al TextBox, el RUT ya vendrá con puntos gracias al modelo
            txtRut.Text = _empleadoActual.Rut;
            txtNombre.Text = _empleadoActual.Nombre;
            txtApellido.Text = _empleadoActual.Apellido;
            txtSueldo.Text = _empleadoActual.Sueldo.ToString("N0"); // Formato con miles sin decimales

            cmbDepto.SelectedValue = _empleadoActual.CodigoDepto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_empleadoActual == null) return;

            // Validación de nombre y apellido para no permitir números
            if (txtNombre.Text.Any(char.IsDigit) || txtApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Los campos de nombre y apellido no pueden contener números.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de sueldo
            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo))
            {
                MessageBox.Show("Sueldo inválido.");
                return;
            }

            // Actualizamos el objeto con los nuevos valores ingresados por el usuario
            _empleadoActual.Nombre = txtNombre.Text;
            _empleadoActual.Apellido = txtApellido.Text;
            _empleadoActual.Sueldo = sueldo;

            if (cmbDepto.SelectedValue is int idDepto)
            {
                _empleadoActual.CodigoDepto = idDepto;
            }

            try
            {
                _empRepo.ModificarEmpleado(_empleadoActual);
                MessageBox.Show("Cambios guardados con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            string soloNumeros = txtRut.Text.Replace(".", "").Replace("-", "").Replace(" ", "");

            // Si tiene menos de 8 caracteres (un RUT chileno válido tiene entre 8 y 9), se pone rojo
            if (soloNumeros.Length < 8)
            {
                txtRut.ForeColor = Color.Red;
            }
            else
            {
                // Vuelve al color por defecto del sistema (negro o el que tengas configurado)
                txtRut.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            // Limpiamos visualmente para facilitar la edición o búsqueda manual
            txtRut.Text = txtRut.Text.Replace(".", "").Replace("-", "");
            txtRut.SelectAll();
        }

        // 2. KeyPress: Bloquea cualquier tecla que no sea número, letra 'K' o teclas de control
        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                char.ToLower(e.KeyChar) != 'k')
            {
                e.Handled = true;
            }
        }

        // 3. Leave: Al salir del campo, el modelo 'Empleado' se encargará de formatear
        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRut.Text))
            {
                _empleadoActual ??= new Empleado();
                _empleadoActual.Rut = txtRut.Text;
                txtRut.Text = _empleadoActual.Rut;
            }
        }
    }
}