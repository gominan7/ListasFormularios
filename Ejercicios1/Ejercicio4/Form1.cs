namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RESULTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el primer conjunto de números desde el TextBox
                string numbersInput1 = txtElementosConjuntoA.Text;
                List<int> numbers1 = numbersInput1.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener el segundo conjunto de números desde el TextBox
                string numbersInput2 = txtElementosConjuntoB.Text;
                List<int> numbers2 = numbersInput2.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener la intersección de los dos conjuntos
                List<int> intersectedNumbers = GetIntersectedNumbers(numbers1, numbers2);

                // Mostrar los resultados en el ListBox
                RESULTADO.Items.Clear();
                foreach (int num in intersectedNumbers)
                {
                    RESULTADO.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<int> GetIntersectedNumbers(List<int> numbers1, List<int> numbers2)
        {
            return numbers1.Intersect(numbers2).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtElementosConjuntoA.Clear();
            txtElementosConjuntoB.Clear();
            RESULTADO.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
