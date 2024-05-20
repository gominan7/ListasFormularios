namespace Ejercicio5
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
            lblConjtunoA = new Label();
            lblConjuntoB = new Label();
            txtConjuntoA = new TextBox();
            txtConjuntoB = new TextBox();
            btnCalcularDiferencia = new Button();
            RESULTADO = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblConjtunoA
            // 
            lblConjtunoA.AutoSize = true;
            lblConjtunoA.Location = new Point(81, 38);
            lblConjtunoA.Name = "lblConjtunoA";
            lblConjtunoA.Size = new Size(145, 15);
            lblConjtunoA.TabIndex = 0;
            lblConjtunoA.Text = "Elementos del Conjunto A";
            // 
            // lblConjuntoB
            // 
            lblConjuntoB.AutoSize = true;
            lblConjuntoB.Location = new Point(402, 38);
            lblConjuntoB.Name = "lblConjuntoB";
            lblConjuntoB.Size = new Size(144, 15);
            lblConjuntoB.TabIndex = 1;
            lblConjuntoB.Text = "Elementos del Conjunto B";
            // 
            // txtConjuntoA
            // 
            txtConjuntoA.Location = new Point(68, 56);
            txtConjuntoA.Name = "txtConjuntoA";
            txtConjuntoA.Size = new Size(172, 23);
            txtConjuntoA.TabIndex = 2;
            // 
            // txtConjuntoB
            // 
            txtConjuntoB.Location = new Point(386, 56);
            txtConjuntoB.Name = "txtConjuntoB";
            txtConjuntoB.Size = new Size(177, 23);
            txtConjuntoB.TabIndex = 3;
            // 
            // btnCalcularDiferencia
            // 
            btnCalcularDiferencia.Location = new Point(229, 120);
            btnCalcularDiferencia.Name = "btnCalcularDiferencia";
            btnCalcularDiferencia.Size = new Size(176, 23);
            btnCalcularDiferencia.TabIndex = 4;
            btnCalcularDiferencia.Text = "CALCULAR DIFERENCIA";
            btnCalcularDiferencia.UseVisualStyleBackColor = true;
            btnCalcularDiferencia.Click += btnCalcularDiferencia_Click;
            // 
            // RESULTADO
            // 
            RESULTADO.FormattingEnabled = true;
            RESULTADO.ItemHeight = 15;
            RESULTADO.Location = new Point(229, 153);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(176, 109);
            RESULTADO.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(229, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(316, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 23);
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
            Controls.Add(btnCalcularDiferencia);
            Controls.Add(txtConjuntoB);
            Controls.Add(txtConjuntoA);
            Controls.Add(lblConjuntoB);
            Controls.Add(lblConjtunoA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConjtunoA;
        private Label lblConjuntoB;
        private TextBox txtConjuntoA;
        private TextBox txtConjuntoB;
        private Button btnCalcularDiferencia;
        private ListBox RESULTADO;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
