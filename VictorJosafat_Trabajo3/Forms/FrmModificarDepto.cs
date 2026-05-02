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
    public partial class FrmModificarDepto : Form
    {
        private readonly DeptoRepo _repo;
        private Departamento _deptoActual;

        public FrmModificarDepto()
        {
            InitializeComponent();
            _repo = new DeptoRepo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _deptoActual = _repo.BuscarPorCodigo(codigo);

            if (_deptoActual == null)
            {
                MessageBox.Show("Departamento no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos
            txtNombreDepto.Text = _deptoActual.NombreDepto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_deptoActual == null)
            {
                MessageBox.Show("Debe buscar un departamento primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreDepto.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _deptoActual.NombreDepto = txtNombreDepto.Text.Trim();

            try
            {
                _repo.ModificarDepartamento(_deptoActual);
                MessageBox.Show("Departamento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

