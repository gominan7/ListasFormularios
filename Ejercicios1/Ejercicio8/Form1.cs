namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Obtener el conjunto de palabras desde el TextBox
            string inputPalabras = txtAgregarPalabras.Text;
            HashSet<string> palabras = new HashSet<string>(inputPalabras.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim()).Where(p => !string.IsNullOrEmpty(p)));

            // Obtener las palabras palíndromos
            HashSet<string> palabrasPalindromos = PalindromoFiltro.ObtenerPalabrasPalindromos(palabras);

            // Mostrar los resultados en el ListBox
            lstResultados.Items.Clear();
            foreach (string palabra in palabrasPalindromos)
            {
                lstResultados.Items.Add(palabra);
            }
        }
        public static class PalindromoFiltro
        {
            public static HashSet<string> ObtenerPalabrasPalindromos(HashSet<string> palabras)
            {
                HashSet<string> resultados = new HashSet<string>();

                foreach (string palabra in palabras)
                {
                    if (EsPalindromo(palabra))
                    {
                        resultados.Add(palabra);
                    }
                }

                return resultados;
            }

            private static bool EsPalindromo(string palabra)
            {
                int longitud = palabra.Length;
                for (int i = 0; i < longitud / 2; i++)
                {
                    if (palabra[i] != palabra[longitud - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAgregarPalabras.Clear();
            lstResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
