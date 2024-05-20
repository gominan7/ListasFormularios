namespace Ejercicio8
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
            txtAgregarPalabras = new TextBox();
            lblAgregarPalabras = new Label();
            btnFiltrar = new Button();
            lstResultados = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblPalindrome = new Label();
            SuspendLayout();
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(51, 74);
            txtAgregarPalabras.Multiline = true;
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(163, 89);
            txtAgregarPalabras.TabIndex = 0;
            // 
            // lblAgregarPalabras
            // 
            lblAgregarPalabras.AutoSize = true;
            lblAgregarPalabras.Location = new Point(83, 56);
            lblAgregarPalabras.Name = "lblAgregarPalabras";
            lblAgregarPalabras.Size = new Size(96, 15);
            lblAgregarPalabras.TabIndex = 1;
            lblAgregarPalabras.Text = "Agregar Palabras";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(83, 169);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(51, 228);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(163, 94);
            lstResultados.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(51, 328);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(139, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPalindrome
            // 
            lblPalindrome.AutoSize = true;
            lblPalindrome.Location = new Point(74, 210);
            lblPalindrome.Name = "lblPalindrome";
            lblPalindrome.Size = new Size(120, 15);
            lblPalindrome.TabIndex = 6;
            lblPalindrome.Text = "Palabras Palindromes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPalindrome);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lstResultados);
            Controls.Add(btnFiltrar);
            Controls.Add(lblAgregarPalabras);
            Controls.Add(txtAgregarPalabras);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAgregarPalabras;
        private Label lblAgregarPalabras;
        private Button btnFiltrar;
        private ListBox lstResultados;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblPalindrome;
    }
}
