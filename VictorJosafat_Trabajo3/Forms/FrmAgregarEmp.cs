using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VictorJosafat_Trabajo3.Data;
using VictorJosafat_Trabajo3.Models;
using System.Globalization;

namespace VictorJosafat_Trabajo3.Forms
{
    public partial class FrmAgregarEmp : Form
    {
        public FrmAgregarEmp()
        {
            InitializeComponent();
        }

        private void FrmAgregarEmp_Load(object sender, EventArgs e)
        {
            DeptoRepo deptoRepo = new DeptoRepo();
            List<Departamento> listaDeptos = deptoRepo.ListarDepartamentos();

            cmbDepto.DataSource = listaDeptos;

            // DisplayCombo = "Codigo - NombreDepto"
            cmbDepto.DisplayMember = "DisplayCombo";

            // Extraemos el FK de la tabla Departamento para guardarlo en Empleado
            cmbDepto.ValueMember = "Codigo";
        }

        private void BtnAgregarEmp_Click(object sender, EventArgs e)
        {
            // Limpia el RUT de puntos, guiones y lo conveierte a mayúscula para su almacenamiento
            string rutLimpio = txtRut.Text.Replace(".", "").Replace("-", "").ToUpper();

            if (cmbDepto.SelectedValue is int codigoSeleccionado)
            {
                Empleado nuevoEmp = new Empleado
                {
                    Rut = rutLimpio,
                    Nombre = Formateador.Capitalizar(txtNombre.Text),
                    Apellido = Formateador.Capitalizar(txtApellido.Text),
                    Sueldo = decimal.Parse(txtSueldo.Text),
                };

                Departamento deptoSeleccionado = new Departamento { Codigo = codigoSeleccionado };

                EmpleadoRepo empRepo = new EmpleadoRepo();
                empRepo.AgregarEmpleado(nuevoEmp, deptoSeleccionado);

                MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un departamento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TxtRut_Enter(object sender, EventArgs e)
        {
            txtRut.Text = txtRut.Text.Replace(".", "").Replace("-", "");
        }
    }
}
