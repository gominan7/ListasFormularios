namespace Ejercicio2
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
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtAgregarPalabras = new TextBox();
            lblAgregarPalabras = new Label();
            lblnsertarLetra = new Label();
            txtInsertarLetra = new TextBox();
            RESULTADOS = new ListBox();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(405, 183);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(349, 327);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(477, 336);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(349, 85);
            txtAgregarPalabras.Multiline = true;
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(203, 92);
            txtAgregarPalabras.TabIndex = 3;
            txtAgregarPalabras.TextChanged += txtAgregarPalabras_TextChanged;
            // 
            // lblAgregarPalabras
            // 
            lblAgregarPalabras.AutoSize = true;
            lblAgregarPalabras.Location = new Point(405, 67);
            lblAgregarPalabras.Name = "lblAgregarPalabras";
            lblAgregarPalabras.Size = new Size(96, 15);
            lblAgregarPalabras.TabIndex = 4;
            lblAgregarPalabras.Text = "Agregar Palabras";
            // 
            // lblnsertarLetra
            // 
            lblnsertarLetra.AutoSize = true;
            lblnsertarLetra.Location = new Point(229, 85);
            lblnsertarLetra.Name = "lblnsertarLetra";
            lblnsertarLetra.Size = new Size(75, 15);
            lblnsertarLetra.TabIndex = 5;
            lblnsertarLetra.Text = "Insertar Letra";
            // 
            // txtInsertarLetra
            // 
            txtInsertarLetra.Location = new Point(219, 103);
            txtInsertarLetra.Name = "txtInsertarLetra";
            txtInsertarLetra.Size = new Size(100, 23);
            txtInsertarLetra.TabIndex = 6;
            // 
            // RESULTADOS
            // 
            RESULTADOS.FormattingEnabled = true;
            RESULTADOS.ItemHeight = 15;
            RESULTADOS.Location = new Point(349, 212);
            RESULTADOS.Name = "RESULTADOS";
            RESULTADOS.Size = new Size(203, 109);
            RESULTADOS.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RESULTADOS);
            Controls.Add(txtInsertarLetra);
            Controls.Add(lblnsertarLetra);
            Controls.Add(lblAgregarPalabras);
            Controls.Add(txtAgregarPalabras);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFiltrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtAgregarPalabras;
        private Label lblAgregarPalabras;
        private Label lblnsertarLetra;
        private TextBox txtInsertarLetra;
        private ListBox RESULTADOS;
    }
}
