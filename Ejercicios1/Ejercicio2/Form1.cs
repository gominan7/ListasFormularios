namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string inputPalabras = txtAgregarPalabras.Text.Trim();
            string inputLetra = txtInsertarLetra.Text.Trim();
            if (inputLetra.Length != 1)
            {
                MessageBox.Show("Por favor, ingrese una sola letra.");
                return;
            }
            char letra = inputLetra[0];
            HashSet<string> Palabras = new HashSet<string>(inputPalabras.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim()).Where(p => !string.IsNullOrEmpty(p)));

            HashSet<string> palabrasFiltradas = Filtrar.ObtenerPalabrasQueComienzanCon(Palabras, letra);

            RESULTADOS.Items.Clear();
            foreach (string palabra in palabrasFiltradas)
            {
                RESULTADOS.Items.Add(palabra);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInsertarLetra.Clear();
            txtAgregarPalabras.Clear();
            RESULTADOS.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAgregarPalabras_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class Filtrar
    {
        public static HashSet<string> ObtenerPalabrasQueComienzanCon(HashSet<string> Palabras, char letra)
        {
            letra = char.ToLower(letra); // Convertimos la letra a minúscula para comparación
            HashSet<string> resultados = new HashSet<string>();

            foreach (string palabra in Palabras)
            {
                if (palabra.Length > 0 && char.ToLower(palabra[0]) == letra)
                {
                    resultados.Add(palabra);
                }
            }

            return resultados;
        }
    }
}
