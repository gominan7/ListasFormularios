namespace Ejercicios1
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
            txtNumero = new TextBox();
            btnAgregarNumero = new Button();
            txtLista1 = new TextBox();
            btnPrimos = new Button();
            txtLista2 = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
           // txtNumero
            // 
            txtNumero.Location = new Point(189, 55);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(189, 84);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(114, 23);
            btnAgregarNumero.TabIndex = 2;
            btnAgregarNumero.Text = "Agregar Numero";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(333, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(188, 156);
            txtLista1.TabIndex = 3;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(189, 280);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(114, 23);
            btnPrimos.TabIndex = 4;
            btnPrimos.Text = "Buscar Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            btnPrimos.Click += btnPrimos_Click;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(333, 232);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(188, 156);
            txtLista2.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtLista2);
            Controls.Add(btnPrimos);
            Controls.Add(txtLista1);
            Controls.Add(btnAgregarNumero);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumero;
        private Button btnAgregarNumero;
        private TextBox txtLista1;
        private Button btnPrimos;
        private TextBox txtLista2;
        private Button btnAgregar;
    }
}
