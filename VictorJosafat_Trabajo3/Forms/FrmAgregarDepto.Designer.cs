namespace VictorJosafat_Trabajo3.Forms
{
    partial class FrmAgregarDepto
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
            lblNombreDepto = new Label();
            txtCodigo = new TextBox();
            txtNombreDepto = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(141, 146);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombreDepto
            // 
            lblNombreDepto.AutoSize = true;
            lblNombreDepto.Location = new Point(141, 207);
            lblNombreDepto.Name = "lblNombreDepto";
            lblNombreDepto.Size = new Size(106, 20);
            lblNombreDepto.TabIndex = 1;
            lblNombreDepto.Text = "Departamento";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(293, 146);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(193, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombreDepto
            // 
            txtNombreDepto.Location = new Point(293, 200);
            txtNombreDepto.Name = "txtNombreDepto";
            txtNombreDepto.Size = new Size(193, 27);
            txtNombreDepto.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(339, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarDepto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 509);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreDepto);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombreDepto);
            Controls.Add(lblCodigo);
            Name = "FrmAgregarDepto";
            Text = "FrmAgregarDepto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombreDepto;
        private TextBox txtCodigo;
        private TextBox txtNombreDepto;
        private Button btnGuardar;
    }
}