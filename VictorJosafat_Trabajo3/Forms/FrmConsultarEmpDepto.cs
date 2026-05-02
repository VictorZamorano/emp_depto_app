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
    public partial class FrmConsultarEmpDepto : Form
    {
        private readonly EmpleadoRepo _empRepo;
        private readonly DeptoRepo _deptoRepo;

        public FrmConsultarEmpDepto()
        {
            InitializeComponent();
            _empRepo = new EmpleadoRepo();
            _deptoRepo = new DeptoRepo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Debe ingresar un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar empleado
            Empleado emp = _empRepo.BuscarEmpleado(txtRut.Text.Trim());

            if (emp == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos del empleado
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            txtSueldo.Text = emp.Sueldo.ToString("N0");

            // Buscar departamento asociado
            Departamento dept = _deptoRepo.BuscarPorCodigo(emp.CodigoDepto);

            if (dept != null)
            {
                txtDepto.Text = dept.NombreDepto;
            }
            else
            {
                txtDepto.Text = "No encontrado";
            }
        }

        private void TxtRut_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRut.Text))
            {
                txtRut.Text = RutFormateador.FormatearRut(txtRut.Text);

                if (txtRut.Text.Length < 10)
                {
                    txtRut.ForeColor = Color.Red; // Aviso visual de que falta algo
                }
                else
                {
                    txtRut.ForeColor = SystemColors.WindowText; // Color normal
                }
            }
        }

        // Evento para validar el formato del RUT al salir del campo de texto
        private void TxtRut_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRut.Text))
            {
                string rutFormateado = RutFormateador.FormatearRut(txtRut.Text);
                if (rutFormateado != txtRut.Text)
                {
                    MessageBox.Show("RUT no válido. Por favor, ingrese un RUT correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRut.Focus();
                }
            }
        }

        // Evento para permitir solo números, guiones y la letra 'k' en el campo de texto del RUT
        private void TxtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != 'k' && e.KeyChar != 'K')
            {
                e.Handled = true;
            }
        }

        private void TxtRut_Enter_1(object sender, EventArgs e)
        {
            txtRut.Text = txtRut.Text.Replace(".", "").Replace("-", "");
        }
    }
}
