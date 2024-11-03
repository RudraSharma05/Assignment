namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1 = 0;
        int num2 = 0;
        string operation = "";
        bool isOperationPerformed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn4.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num1 = int.Parse(TextDisplay.Text);
            operation = "^";
            isOperationPerformed = true;
            TextDisplay.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn1.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn9.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn3.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn8.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + btn0.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = ""; 
            num1 = 0;               
            num2 = 0;                 
            operation = "";          
            isOperationPerformed = false; 
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(TextDisplay.Text);
            operation = "+";
            isOperationPerformed = true;
            TextDisplay.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(TextDisplay.Text);
            operation = "-";
            isOperationPerformed = true;
            TextDisplay.Clear();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(TextDisplay.Text);
            operation = "*";
            isOperationPerformed = true;
            TextDisplay.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(TextDisplay.Text);
            operation = "/";
            isOperationPerformed = true;
            TextDisplay.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TextDisplay.Text);

            switch (operation)
            {
                case "+":
                    TextDisplay.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    TextDisplay.Text = (num1 - num2).ToString(); 
                    break;
                case "*":
                    TextDisplay.Text = (num1 * num2).ToString(); 
                    break;
                case "/":
                    if (num2 != 0)
                        TextDisplay.Text = (num1 / num2).ToString();
                    else
                        TextDisplay.Text = "Cannot divide by zero";
                    break;
                case "^":
                    
                    TextDisplay.Text = Math.Pow(num1, num2).ToString();
                    break;
                default:
                    TextDisplay.Text = "Error"; 
                    break;
            }


            num1 = 0;
            num2 = 0;
            operation = "";
            isOperationPerformed = false;
        }
    }
}

