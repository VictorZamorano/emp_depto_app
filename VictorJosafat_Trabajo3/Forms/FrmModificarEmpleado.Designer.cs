namespace VictorJosafat_Trabajo3.Forms
{
    partial class FrmModificarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRut = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblSueldo = new Label();
            lblDepto = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSueldo = new TextBox();
            cmbDepto = new ComboBox();
            btnBuscar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(24, 72);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(138, 15);
            lblRut.TabIndex = 0;
            lblRut.Text = "Ingrese Rut de Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(130, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Ingrese Nuevo Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 134);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(130, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Ingrese Nuevo Apellido";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(44, 164);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(122, 15);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Ingrese Nuevo Sueldo";
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Location = new Point(27, 194);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(136, 15);
            lblDepto.TabIndex = 4;
            lblDepto.Text = "Seleccione Nuevo Depto";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(230, 70);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "11222333K";
            txtRut.Size = new Size(182, 23);
            txtRut.TabIndex = 5;
            txtRut.TextChanged += txtRut_TextChanged;
            txtRut.Enter += txtRut_Enter;
            txtRut.KeyPress += txtRut_KeyPress;
            txtRut.Leave += txtRut_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(230, 102);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(230, 131);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(230, 159);
            txtSueldo.Margin = new Padding(3, 2, 3, 2);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(182, 23);
            txtSueldo.TabIndex = 9;
            // 
            // cmbDepto
            // 
            cmbDepto.FormattingEnabled = true;
            cmbDepto.Location = new Point(230, 191);
            cmbDepto.Margin = new Padding(3, 2, 3, 2);
            cmbDepto.Name = "cmbDepto";
            cmbDepto.Size = new Size(182, 23);
            cmbDepto.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(460, 69);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(252, 233);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 26);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbDepto);
            Controls.Add(txtSueldo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(lblDepto);
            Controls.Add(lblSueldo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblRut);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmModificarEmpleado";
            Text = "FrmModificarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRut;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblSueldo;
        private Label lblDepto;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSueldo;
        private ComboBox cmbDepto;
        private Button btnBuscar;
        private Button btnGuardar;
    }
}