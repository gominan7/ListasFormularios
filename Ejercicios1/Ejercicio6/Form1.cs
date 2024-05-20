namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el primer conjunto de números desde el TextBox
                string numbersInput1 = txtConjuntoA.Text;
                List<int> numbers1 = numbersInput1.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener el segundo conjunto de números desde el TextBox
                string numbersInput2 = txtConjuntoB.Text;
                List<int> numbers2 = numbersInput2.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener la diferencia de los dos conjuntos (números que están en el segundo conjunto pero no en el primero)
                List<int> differenceNumbers = GetDifferenceNumbers(numbers2, numbers1);

                // Mostrar los resultados en el ListBox
                RESULTADO.Items.Clear();
                foreach (int num in differenceNumbers)
                {
                    RESULTADO.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private List<int> GetDifferenceNumbers(List<int> numbers1, List<int> numbers2)
        {
            return numbers1.Except(numbers2).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConjuntoA.Clear();
            txtConjuntoB.Clear();
            RESULTADO.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
