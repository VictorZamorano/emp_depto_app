namespace VictorJosafat_Trabajo3.Forms
{
    partial class FrmAgregarEmp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSueldo = new TextBox();
            cmbDepto = new ComboBox();
            label6 = new Label();
            btnAgregarEmp = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 102);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "RUT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 136);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 203);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Sueldo:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(291, 99);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "11.222.333-K";
            txtRut.Size = new Size(231, 23);
            txtRut.TabIndex = 5;
            txtRut.TextChanged += TxtRut_TextChanged;
            txtRut.Enter += TxtRut_Enter;
            txtRut.KeyPress += TxtRut_KeyPress;
            txtRut.Leave += TxtRut_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(291, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(291, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(231, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(291, 200);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(231, 23);
            txtSueldo.TabIndex = 8;
            // 
            // cmbDepto
            // 
            cmbDepto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepto.FormattingEnabled = true;
            cmbDepto.Location = new Point(291, 235);
            cmbDepto.Name = "cmbDepto";
            cmbDepto.Size = new Size(231, 23);
            cmbDepto.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 238);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 12;
            label6.Text = "Departamentos:";
            // 
            // btnAgregarEmp
            // 
            btnAgregarEmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarEmp.Location = new Point(177, 308);
            btnAgregarEmp.Name = "btnAgregarEmp";
            btnAgregarEmp.Size = new Size(345, 38);
            btnAgregarEmp.TabIndex = 13;
            btnAgregarEmp.Text = "Agregar Empleado";
            btnAgregarEmp.UseVisualStyleBackColor = true;
            btnAgregarEmp.Click += BtnAgregarEmp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(223, 32);
            label5.Name = "label5";
            label5.Size = new Size(248, 30);
            label5.TabIndex = 14;
            label5.Text = "Agregar nuevo Empleado";
            // 
            // FrmAgregarEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnAgregarEmp);
            Controls.Add(label6);
            Controls.Add(cmbDepto);
            Controls.Add(txtSueldo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgregarEmp";
            Text = "FrmAgregarEmp";
            Load += FrmAgregarEmp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSueldo;
        private ComboBox cmbDepto;
        private Label label6;
        private Button btnAgregarEmp;
        private Label label5;
    }
}