namespace Squared
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBoxSquares.Items.Clear();

            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int square = i * i; 
                    listBoxSquares.Items.Add(square); 
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBoxSquares.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
