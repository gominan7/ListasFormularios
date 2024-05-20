namespace Ejercicio6
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
            lblConjuntoA = new Label();
            lblConjuntoB = new Label();
            txtConjuntoA = new TextBox();
            txtConjuntoB = new TextBox();
            btnCalcular = new Button();
            RESULTADO = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblConjuntoA
            // 
            lblConjuntoA.AutoSize = true;
            lblConjuntoA.Location = new Point(84, 58);
            lblConjuntoA.Name = "lblConjuntoA";
            lblConjuntoA.Size = new Size(145, 15);
            lblConjuntoA.TabIndex = 0;
            lblConjuntoA.Text = "Elementos del Conjunto A";
            // 
            // lblConjuntoB
            // 
            lblConjuntoB.AutoSize = true;
            lblConjuntoB.Location = new Point(325, 58);
            lblConjuntoB.Name = "lblConjuntoB";
            lblConjuntoB.Size = new Size(144, 15);
            lblConjuntoB.TabIndex = 1;
            lblConjuntoB.Text = "Elementos del Conjunto B";
            // 
            // txtConjuntoA
            // 
            txtConjuntoA.Location = new Point(84, 76);
            txtConjuntoA.Name = "txtConjuntoA";
            txtConjuntoA.Size = new Size(150, 23);
            txtConjuntoA.TabIndex = 2;
            // 
            // txtConjuntoB
            // 
            txtConjuntoB.Location = new Point(325, 76);
            txtConjuntoB.Name = "txtConjuntoB";
            txtConjuntoB.Size = new Size(150, 23);
            txtConjuntoB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(194, 124);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(205, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR DIFERENCIA EN B";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // RESULTADO
            // 
            RESULTADO.FormattingEnabled = true;
            RESULTADO.ItemHeight = 15;
            RESULTADO.Location = new Point(194, 162);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(205, 94);
            RESULTADO.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(303, 262);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(RESULTADO);
            Controls.Add(btnCalcular);
            Controls.Add(txtConjuntoB);
            Controls.Add(txtConjuntoA);
            Controls.Add(lblConjuntoB);
            Controls.Add(lblConjuntoA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConjuntoA;
        private Label lblConjuntoB;
        private TextBox txtConjuntoA;
        private TextBox txtConjuntoB;
        private Button btnCalcular;
        private ListBox RESULTADO;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
