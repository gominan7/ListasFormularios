namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarAnagramas_Click(object sender, EventArgs e)
        {
            var IngresarPalabras = new HashSet<string>(txtIngresePalabras.Lines);

            // Obtener los anagramas
            var anagrams = GetAnagrams(IngresarPalabras);

            // Mostrar los anagramas en el ListBox
            lstANAGRAMAS.Items.Clear();
            foreach (var word in anagrams)
            {
                lstANAGRAMAS.Items.Add(word);
            }
        }
        private HashSet<string> GetAnagrams(HashSet<string> words)
        {
            // Diccionario para agrupar las palabras por su versión ordenada.
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                // Ordenar las letras de la palabra.
                string sortedWord = String.Concat(word.OrderBy(c => c));

                // Si la clave ya existe, agregar la palabra a la lista.
                if (anagramGroups.ContainsKey(sortedWord))
                {
                    anagramGroups[sortedWord].Add(word);
                }
                else
                {
                    // Si la clave no existe, crear una nueva entrada.
                    anagramGroups[sortedWord] = new List<string> { word };
                }
            }
            HashSet<string> anagramSet = new HashSet<string>();

            // Añadir sólo las palabras que tienen al menos un anagrama.
            foreach (var group in anagramGroups.Values)
            {
                if (group.Count > 1)
                {
                    foreach (var word in group)
                    {
                        anagramSet.Add(word);
                    }
                }
            }

            return anagramSet;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresePalabras.Clear();
            lstANAGRAMAS.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
