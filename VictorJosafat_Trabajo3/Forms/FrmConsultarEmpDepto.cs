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
    }
}
