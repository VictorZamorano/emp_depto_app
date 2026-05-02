namespace VictorJosafat_Trabajo3.Forms
{
    partial class FrmConsultarEmpDepto
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
            txtDepto = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(31, 69);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(138, 15);
            lblRut.TabIndex = 0;
            lblRut.Text = "Ingrese Rut de Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(104, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(104, 142);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(104, 177);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Sueldo";
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Location = new Point(104, 207);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(83, 15);
            lblDepto.TabIndex = 4;
            lblDepto.Text = "Departamento";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(228, 69);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "11.222.333-K";
            txtRut.Size = new Size(184, 23);
            txtRut.TabIndex = 5;
            txtRut.TextChanged += TxtRut_TextChanged;
            txtRut.Enter += TxtRut_Enter_1;
            txtRut.KeyPress += TxtRut_KeyPress;
            txtRut.Leave += TxtRut_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 106);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(228, 140);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(184, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(228, 177);
            txtSueldo.Margin = new Padding(3, 2, 3, 2);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(184, 23);
            txtSueldo.TabIndex = 8;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(228, 207);
            txtDepto.Margin = new Padding(3, 2, 3, 2);
            txtDepto.Name = "txtDepto";
            txtDepto.ReadOnly = true;
            txtDepto.Size = new Size(184, 23);
            txtDepto.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(264, 260);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultarEmpDepto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnBuscar);
            Controls.Add(txtDepto);
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
            Name = "FrmConsultarEmpDepto";
            Text = "FrmConsultarEmpDepto";
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
        private TextBox txtDepto;
        private Button btnBuscar;
    }
}