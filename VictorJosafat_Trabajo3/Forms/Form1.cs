using MySql.Data.MySqlClient;
using VictorJosafat_Trabajo3.Data;
using VictorJosafat_Trabajo3.Forms;

namespace VictorJosafat_Trabajo3
{
    public partial class Form1 : Form
    {
        readonly DatabaseHelper dbHelper = new();

        public Form1()
        {
            InitializeComponent();
        }



        private void AgregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarEmp ventana = new();
            ventana.ShowDialog();
        }


        private void ListarEmpleadoODepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList ventana = new();
            ventana.ShowDialog();
        }

        // EVENTOS
        // Evento para probar la conexión a la base de datos
        private void TestConnection_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = dbHelper.ObtenerConexion();
            try
            {
                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        // Evento para agregar datos de prueba a la base de datos
        private void SeedButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSeeder seeder = new();
                seeder.InicializarDatos();
                MessageBox.Show("Datos de prueba agregados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar datos de prueba: " + ex.Message);
            }
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarDepto ventana = new();
            ventana.ShowDialog();
        }

        private void consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarEmpDepto ventana = new();
            ventana.ShowDialog();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarEmpleado ventana = new();
            ventana.ShowDialog();
        }

        private void modificarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarDepto ventana = new();
            ventana.ShowDialog();
        }
    }
}
