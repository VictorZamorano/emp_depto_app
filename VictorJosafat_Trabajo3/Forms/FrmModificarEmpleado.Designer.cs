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
            lblRut.Location = new Point(28, 96);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(176, 20);
            lblRut.TabIndex = 0;
            lblRut.Text = "Ingrese Rut de Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 136);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Ingrese Nuevo Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(39, 178);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(165, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Ingrese Nuevo Apellido";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(50, 219);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(154, 20);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Ingrese Nuevo Sueldo";
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Location = new Point(31, 258);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(173, 20);
            lblDepto.TabIndex = 4;
            lblDepto.Text = "Seleccione Nuevo Depto";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(263, 93);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(208, 27);
            txtRut.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(263, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(263, 175);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(208, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(263, 212);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(208, 27);
            txtSueldo.TabIndex = 9;
            // 
            // cmbDepto
            // 
            cmbDepto.FormattingEnabled = true;
            cmbDepto.Location = new Point(263, 255);
            cmbDepto.Name = "cmbDepto";
            cmbDepto.Size = new Size(208, 28);
            cmbDepto.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(526, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(288, 311);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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