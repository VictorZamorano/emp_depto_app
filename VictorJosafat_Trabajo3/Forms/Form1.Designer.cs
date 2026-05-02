namespace VictorJosafat_Trabajo3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            agregarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            agregarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem = new ToolStripMenuItem();
            modificacarEmpleadoODepartamentoToolStripMenuItem = new ToolStripMenuItem();
            modificarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            modificarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            listarEmpleadoODepartamentoToolStripMenuItem = new ToolStripMenuItem();
            testConnection = new Button();
            seedButton = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarEmpleadoToolStripMenuItem, agregarDepartamentoToolStripMenuItem, consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem, modificacarEmpleadoODepartamentoToolStripMenuItem, listarEmpleadoODepartamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(117, 20);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += AgregarEmpleadoToolStripMenuItem_Click;
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            agregarDepartamentoToolStripMenuItem.Size = new Size(140, 20);
            agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            agregarDepartamentoToolStripMenuItem.Click += agregarDepartamentoToolStripMenuItem_Click;
            // 
            // consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem
            // 
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Name = "consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem";
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Size = new Size(236, 20);
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Text = "Consulta de Empleados y Departamentos";
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Click += consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem_Click;
            // 
            // modificacarEmpleadoODepartamentoToolStripMenuItem
            // 
            modificacarEmpleadoODepartamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarEmpleadoToolStripMenuItem, modificarDepartamentoToolStripMenuItem });
            modificacarEmpleadoODepartamentoToolStripMenuItem.Name = "modificacarEmpleadoODepartamentoToolStripMenuItem";
            modificacarEmpleadoODepartamentoToolStripMenuItem.Size = new Size(215, 20);
            modificacarEmpleadoODepartamentoToolStripMenuItem.Text = "Modificar Empleado o Departamento";
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            modificarEmpleadoToolStripMenuItem.Size = new Size(204, 22);
            modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
            modificarEmpleadoToolStripMenuItem.Click += modificarEmpleadoToolStripMenuItem_Click;
            // 
            // modificarDepartamentoToolStripMenuItem
            // 
            modificarDepartamentoToolStripMenuItem.Name = "modificarDepartamentoToolStripMenuItem";
            modificarDepartamentoToolStripMenuItem.Size = new Size(204, 22);
            modificarDepartamentoToolStripMenuItem.Text = "Modificar Departamento";
            modificarDepartamentoToolStripMenuItem.Click += modificarDepartamentoToolStripMenuItem_Click;
            // 
            // listarEmpleadoODepartamentoToolStripMenuItem
            // 
            listarEmpleadoODepartamentoToolStripMenuItem.Name = "listarEmpleadoODepartamentoToolStripMenuItem";
            listarEmpleadoODepartamentoToolStripMenuItem.Size = new Size(192, 20);
            listarEmpleadoODepartamentoToolStripMenuItem.Text = "Listar Empleado o Departamento";
            listarEmpleadoODepartamentoToolStripMenuItem.Click += ListarEmpleadoODepartamentoToolStripMenuItem_Click;
            // 
            // testConnection
            // 
            testConnection.Location = new Point(12, 100);
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(178, 63);
            testConnection.TabIndex = 1;
            testConnection.Text = "Probar Conexión a la DB";
            testConnection.UseVisualStyleBackColor = true;
            testConnection.Click += TestConnection_Click;
            // 
            // seedButton
            // 
            seedButton.Location = new Point(12, 190);
            seedButton.Name = "seedButton";
            seedButton.Size = new Size(178, 63);
            seedButton.TabIndex = 2;
            seedButton.Text = "Agregar datos de prueba";
            seedButton.UseVisualStyleBackColor = true;
            seedButton.Click += SeedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(1005, 37);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido a la aplicación de RRHH para el manejo de empleados y departamentos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 450);
            Controls.Add(label1);
            Controls.Add(seedButton);
            Controls.Add(testConnection);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem agregarDepartamentoToolStripMenuItem;
        private ToolStripMenuItem consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem;
        private ToolStripMenuItem modificacarEmpleadoODepartamentoToolStripMenuItem;
        private ToolStripMenuItem listarEmpleadoODepartamentoToolStripMenuItem;
        private Button testConnection;
        private Button seedButton;
        private ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem modificarDepartamentoToolStripMenuItem;
        private Label label1;
    }
}
