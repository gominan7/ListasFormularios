namespace Ejercicio3
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
                // Obtener el conjunto de números desde el TextBox
                string numbersInput = txtIngreseNumeros.Text;
                List<int> numbers = numbersInput.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToList();

                // Obtener el divisor
                int divisor = int.Parse(txtIngreseDivisor.Text);

                // Obtener los números divisibles
                List<int> divisibleNumbers = GetDivisibleNumbers(numbers, divisor);

                // Mostrar los resultados en el ListBox
                RESULTADOS.Items.Clear();
                foreach (int num in divisibleNumbers)
                {
                    RESULTADOS.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private List<int> GetDivisibleNumbers(List<int> numbers, int divisor)
        {
            return numbers.Where(n => n % divisor == 0).ToList();
        }

        private void txtIngreseDivisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngreseNumeros.Clear();
            txtIngreseDivisor.Clear();
            RESULTADOS.Items.Clear();
        }
    }
}
