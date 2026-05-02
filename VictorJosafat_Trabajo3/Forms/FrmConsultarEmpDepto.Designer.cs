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
            lblRut.Location = new Point(35, 92);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(176, 20);
            lblRut.TabIndex = 0;
            lblRut.Text = "Ingrese Rut de Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(119, 142);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(119, 189);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(119, 236);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(55, 20);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Sueldo";
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Location = new Point(119, 276);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(106, 20);
            lblDepto.TabIndex = 4;
            lblDepto.Text = "Departamento";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(261, 92);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(210, 27);
            txtRut.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(261, 142);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(210, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(261, 186);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(210, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(261, 236);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(210, 27);
            txtSueldo.TabIndex = 8;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(261, 276);
            txtDepto.Name = "txtDepto";
            txtDepto.ReadOnly = true;
            txtDepto.Size = new Size(210, 27);
            txtDepto.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(302, 347);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmConsultarEmpDepto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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