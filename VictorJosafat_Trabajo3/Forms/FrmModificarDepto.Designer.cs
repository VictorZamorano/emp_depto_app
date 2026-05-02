namespace VictorJosafat_Trabajo3.Forms
{
    partial class FrmModificarDepto
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
            lblCodigo = new Label();
            lblDepto = new Label();
            txtCodigo = new TextBox();
            txtNombreDepto = new TextBox();
            btnBuscar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(51, 119);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(181, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Ingrese Código del Depto";
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Location = new Point(37, 200);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(195, 20);
            lblDepto.TabIndex = 1;
            lblDepto.Text = "Modifique el Departamento";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(296, 119);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombreDepto
            // 
            txtNombreDepto.Location = new Point(276, 197);
            txtNombreDepto.Name = "txtNombreDepto";
            txtNombreDepto.Size = new Size(202, 27);
            txtNombreDepto.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(526, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(309, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmModificarDepto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombreDepto);
            Controls.Add(txtCodigo);
            Controls.Add(lblDepto);
            Controls.Add(lblCodigo);
            Name = "FrmModificarDepto";
            Text = "FrmModificarDepto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblDepto;
        private TextBox txtCodigo;
        private TextBox txtNombreDepto;
        private Button btnBuscar;
        private Button btnGuardar;
    }
}