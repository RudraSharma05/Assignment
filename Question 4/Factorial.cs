using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long calculate(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate and parse user input
            if (int.TryParse(textBox1.Text, out int number) && number >= 0)
            {
                long factorial = calculate(number);
                listBox1.Items.Clear(); // Clear previous results
                listBox1.Items.Add($"Factorial of {number} is {factorial}");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please enter a valid, non-negative integer between 1 and 20.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
