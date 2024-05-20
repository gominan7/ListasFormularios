namespace Ejercicio3
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
            lblIngreseNumeros = new Label();
            lblIngreseDivisor = new Label();
            txtIngreseNumeros = new TextBox();
            txtIngreseDivisor = new TextBox();
            btnCalcular = new Button();
            RESULTADOS = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngreseNumeros
            // 
            lblIngreseNumeros.AutoSize = true;
            lblIngreseNumeros.Location = new Point(165, 55);
            lblIngreseNumeros.Name = "lblIngreseNumeros";
            lblIngreseNumeros.Size = new Size(97, 15);
            lblIngreseNumeros.TabIndex = 0;
            lblIngreseNumeros.Text = "Ingrese Numeros";
            // 
            // lblIngreseDivisor
            // 
            lblIngreseDivisor.AutoSize = true;
            lblIngreseDivisor.Location = new Point(325, 55);
            lblIngreseDivisor.Name = "lblIngreseDivisor";
            lblIngreseDivisor.Size = new Size(84, 15);
            lblIngreseDivisor.TabIndex = 1;
            lblIngreseDivisor.Text = "Ingrese Divisor";
            // 
            // txtIngreseNumeros
            // 
            txtIngreseNumeros.Location = new Point(151, 73);
            txtIngreseNumeros.Multiline = true;
            txtIngreseNumeros.Name = "txtIngreseNumeros";
            txtIngreseNumeros.Size = new Size(139, 86);
            txtIngreseNumeros.TabIndex = 2;
            // 
            // txtIngreseDivisor
            // 
            txtIngreseDivisor.Location = new Point(325, 73);
            txtIngreseDivisor.Name = "txtIngreseDivisor";
            txtIngreseDivisor.Size = new Size(100, 23);
            txtIngreseDivisor.TabIndex = 3;
            txtIngreseDivisor.TextChanged += txtIngreseDivisor_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(280, 165);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // RESULTADOS
            // 
            RESULTADOS.FormattingEnabled = true;
            RESULTADOS.ItemHeight = 15;
            RESULTADOS.Location = new Point(244, 194);
            RESULTADOS.Name = "RESULTADOS";
            RESULTADOS.Size = new Size(165, 94);
            RESULTADOS.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(244, 294);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(334, 294);
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
            Controls.Add(RESULTADOS);
            Controls.Add(btnCalcular);
            Controls.Add(txtIngreseDivisor);
            Controls.Add(txtIngreseNumeros);
            Controls.Add(lblIngreseDivisor);
            Controls.Add(lblIngreseNumeros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreseNumeros;
        private Label lblIngreseDivisor;
        private TextBox txtIngreseNumeros;
        private TextBox txtIngreseDivisor;
        private Button btnCalcular;
        private ListBox RESULTADOS;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
