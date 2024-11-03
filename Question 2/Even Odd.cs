namespace Even_odd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous results
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            // Validate input
            if (int.TryParse(textBox1.Text, out int n) && n >= 0)
            {
                // Generate even numbers up to n
                for (int i = 0; i <= n; i += 2) // i increments by 2 to get even numbers
                {
                    listBox1.Items.Add(i); // Add even numbers
                }

                // Generate odd numbers up to n
                for (int i = 1; i <= n; i += 2) // i increments by 2 to get odd numbers
                {
                    listBox2.Items.Add(i); // Add odd numbers
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid non-negative integer.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
