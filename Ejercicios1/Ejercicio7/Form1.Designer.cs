namespace Ejercicio7
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
            lblIngresePalabras = new Label();
            txtIngresePalabras = new TextBox();
            btnEncontrarAnagramas = new Button();
            lstANAGRAMAS = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngresePalabras
            // 
            lblIngresePalabras.AutoSize = true;
            lblIngresePalabras.Location = new Point(74, 38);
            lblIngresePalabras.Name = "lblIngresePalabras";
            lblIngresePalabras.Size = new Size(92, 15);
            lblIngresePalabras.TabIndex = 0;
            lblIngresePalabras.Text = "Ingrese Palabras";
            // 
            // txtIngresePalabras
            // 
            txtIngresePalabras.Location = new Point(58, 56);
            txtIngresePalabras.Multiline = true;
            txtIngresePalabras.Name = "txtIngresePalabras";
            txtIngresePalabras.Size = new Size(131, 150);
            txtIngresePalabras.TabIndex = 1;
            // 
            // btnEncontrarAnagramas
            // 
            btnEncontrarAnagramas.Location = new Point(44, 212);
            btnEncontrarAnagramas.Name = "btnEncontrarAnagramas";
            btnEncontrarAnagramas.Size = new Size(173, 23);
            btnEncontrarAnagramas.TabIndex = 2;
            btnEncontrarAnagramas.Text = "ENCONTRAR ANAGRAMAS";
            btnEncontrarAnagramas.UseVisualStyleBackColor = true;
            btnEncontrarAnagramas.Click += btnEncontrarAnagramas_Click;
            // 
            // lstANAGRAMAS
            // 
            lstANAGRAMAS.FormattingEnabled = true;
            lstANAGRAMAS.ItemHeight = 15;
            lstANAGRAMAS.Location = new Point(44, 241);
            lstANAGRAMAS.Name = "lstANAGRAMAS";
            lstANAGRAMAS.Size = new Size(173, 109);
            lstANAGRAMAS.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(44, 356);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(137, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 23);
            btnSalir.TabIndex = 5;
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
            Controls.Add(lstANAGRAMAS);
            Controls.Add(btnEncontrarAnagramas);
            Controls.Add(txtIngresePalabras);
            Controls.Add(lblIngresePalabras);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresePalabras;
        private TextBox txtIngresePalabras;
        private Button btnEncontrarAnagramas;
        private ListBox lstANAGRAMAS;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
