namespace Ejercicio4
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
            lblElementosConjuntoA = new Label();
            lblElementosConjuntoB = new Label();
            txtElementosConjuntoA = new TextBox();
            txtElementosConjuntoB = new TextBox();
            btnCalcular = new Button();
            RESULTADO = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblElementosConjuntoA
            // 
            lblElementosConjuntoA.AutoSize = true;
            lblElementosConjuntoA.Location = new Point(81, 73);
            lblElementosConjuntoA.Name = "lblElementosConjuntoA";
            lblElementosConjuntoA.Size = new Size(143, 15);
            lblElementosConjuntoA.TabIndex = 0;
            lblElementosConjuntoA.Text = "Elementos del conjunto A";
            // 
            // lblElementosConjuntoB
            // 
            lblElementosConjuntoB.AutoSize = true;
            lblElementosConjuntoB.Location = new Point(348, 73);
            lblElementosConjuntoB.Name = "lblElementosConjuntoB";
            lblElementosConjuntoB.Size = new Size(142, 15);
            lblElementosConjuntoB.TabIndex = 1;
            lblElementosConjuntoB.Text = "Elementos del conjunto B";
            // 
            // txtElementosConjuntoA
            // 
            txtElementosConjuntoA.Location = new Point(59, 91);
            txtElementosConjuntoA.Name = "txtElementosConjuntoA";
            txtElementosConjuntoA.Size = new Size(187, 23);
            txtElementosConjuntoA.TabIndex = 2;
            // 
            // txtElementosConjuntoB
            // 
            txtElementosConjuntoB.Location = new Point(326, 91);
            txtElementosConjuntoB.Name = "txtElementosConjuntoB";
            txtElementosConjuntoB.Size = new Size(187, 23);
            txtElementosConjuntoB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(208, 151);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(166, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR INTERSECCION";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // RESULTADO
            // 
            RESULTADO.FormattingEnabled = true;
            RESULTADO.ItemHeight = 15;
            RESULTADO.Location = new Point(208, 190);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(166, 94);
            RESULTADO.TabIndex = 5;
            RESULTADO.SelectedIndexChanged += RESULTADO_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(208, 290);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(299, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
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
            Controls.Add(txtElementosConjuntoB);
            Controls.Add(txtElementosConjuntoA);
            Controls.Add(lblElementosConjuntoB);
            Controls.Add(lblElementosConjuntoA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElementosConjuntoA;
        private Label lblElementosConjuntoB;
        private TextBox txtElementosConjuntoA;
        private TextBox txtElementosConjuntoB;
        private Button btnCalcular;
        private ListBox RESULTADO;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
