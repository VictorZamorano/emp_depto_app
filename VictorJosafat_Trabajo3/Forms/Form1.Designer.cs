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
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1365, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            agregarEmpleadoToolStripMenuItem.Size = new Size(149, 24);
            agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            agregarEmpleadoToolStripMenuItem.Click += AgregarEmpleadoToolStripMenuItem_Click;
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            agregarDepartamentoToolStripMenuItem.Size = new Size(178, 24);
            agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            agregarDepartamentoToolStripMenuItem.Click += agregarDepartamentoToolStripMenuItem_Click;
            // 
            // consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem
            // 
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Name = "consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem";
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Size = new Size(297, 24);
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Text = "Consulta de Empleados y Departamentos";
            consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem.Click += consultarPorEmpleadoYDepartamentoAsociadosToolStripMenuItem_Click;
            // 
            // modificacarEmpleadoODepartamentoToolStripMenuItem
            // 
            modificacarEmpleadoODepartamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarEmpleadoToolStripMenuItem, modificarDepartamentoToolStripMenuItem });
            modificacarEmpleadoODepartamentoToolStripMenuItem.Name = "modificacarEmpleadoODepartamentoToolStripMenuItem";
            modificacarEmpleadoODepartamentoToolStripMenuItem.Size = new Size(273, 24);
            modificacarEmpleadoODepartamentoToolStripMenuItem.Text = "Modificar Empleado o Departamento";
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            modificarEmpleadoToolStripMenuItem.Size = new Size(257, 26);
            modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
            modificarEmpleadoToolStripMenuItem.Click += modificarEmpleadoToolStripMenuItem_Click;
            // 
            // modificarDepartamentoToolStripMenuItem
            // 
            modificarDepartamentoToolStripMenuItem.Name = "modificarDepartamentoToolStripMenuItem";
            modificarDepartamentoToolStripMenuItem.Size = new Size(257, 26);
            modificarDepartamentoToolStripMenuItem.Text = "Modificar Departamento";
            modificarDepartamentoToolStripMenuItem.Click += modificarDepartamentoToolStripMenuItem_Click;
            // 
            // listarEmpleadoODepartamentoToolStripMenuItem
            // 
            listarEmpleadoODepartamentoToolStripMenuItem.Name = "listarEmpleadoODepartamentoToolStripMenuItem";
            listarEmpleadoODepartamentoToolStripMenuItem.Size = new Size(244, 24);
            listarEmpleadoODepartamentoToolStripMenuItem.Text = "Listar Empleado o Departamento";
            listarEmpleadoODepartamentoToolStripMenuItem.Click += ListarEmpleadoODepartamentoToolStripMenuItem_Click;
            // 
            // testConnection
            // 
            testConnection.Location = new Point(14, 133);
            testConnection.Margin = new Padding(3, 4, 3, 4);
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(203, 84);
            testConnection.TabIndex = 1;
            testConnection.Text = "Probar Conexión a la DB";
            testConnection.UseVisualStyleBackColor = true;
            testConnection.Click += TestConnection_Click;
            // 
            // seedButton
            // 
            seedButton.Location = new Point(14, 253);
            seedButton.Margin = new Padding(3, 4, 3, 4);
            seedButton.Name = "seedButton";
            seedButton.Size = new Size(203, 84);
            seedButton.TabIndex = 2;
            seedButton.Text = "Agregar datos de prueba";
            seedButton.UseVisualStyleBackColor = true;
            seedButton.Click += SeedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 57);
            label1.Name = "label1";
            label1.Size = new Size(1259, 46);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido a la aplicación de RRHH para el manejo de empleados y departamentos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 600);
            Controls.Add(label1);
            Controls.Add(seedButton);
            Controls.Add(testConnection);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
