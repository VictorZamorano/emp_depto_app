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
            label5 = new Label();
            rutBox = new TextBox();
            nameBox = new TextBox();
            apellBox = new TextBox();
            sueldoBox = new TextBox();
            codigoBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 94);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "RUT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 128);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 163);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 195);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Sueldo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 227);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Código:";
            // 
            // rutBox
            // 
            rutBox.Location = new Point(270, 86);
            rutBox.Name = "rutBox";
            rutBox.Size = new Size(231, 23);
            rutBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(270, 120);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(231, 23);
            nameBox.TabIndex = 6;
            // 
            // apellBox
            // 
            apellBox.Location = new Point(270, 155);
            apellBox.Name = "apellBox";
            apellBox.Size = new Size(231, 23);
            apellBox.TabIndex = 7;
            // 
            // sueldoBox
            // 
            sueldoBox.Location = new Point(270, 187);
            sueldoBox.Name = "sueldoBox";
            sueldoBox.Size = new Size(231, 23);
            sueldoBox.TabIndex = 8;
            // 
            // codigoBox
            // 
            codigoBox.Location = new Point(270, 219);
            codigoBox.Name = "codigoBox";
            codigoBox.Size = new Size(231, 23);
            codigoBox.TabIndex = 9;
            // 
            // FrmAgregarEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(codigoBox);
            Controls.Add(sueldoBox);
            Controls.Add(apellBox);
            Controls.Add(nameBox);
            Controls.Add(rutBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgregarEmp";
            Text = "FrmAgregarEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox rutBox;
        private TextBox nameBox;
        private TextBox apellBox;
        private TextBox sueldoBox;
        private TextBox codigoBox;
    }
}