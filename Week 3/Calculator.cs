namespace Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double total = 0;
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);
            switch(textBox4.Text)
            {
                case "+":
                    total = number1 + number2;
                    textBox3.Text = total.ToString();
                    listBox1.Items.Add(number1.ToString() + " + " + number2.ToString() + " = " + total.ToString());
                    break;

                case "-":
                    total = number1 - number2;
                    textBox3.Text = total.ToString();
                    listBox1.Items.Add(number1.ToString() + " - " + number2.ToString() + " = " + total.ToString());
                    break;

                case "X":
                    total = number1 * number2;
                    textBox3.Text = total.ToString();
                    listBox1.Items.Add(number1.ToString() + " X " + number2.ToString() + " = " + total.ToString());
                    break;

                case "/":
                    total = number1 / number2;
                    textBox3.Text = total.ToString();
                    listBox1.Items.Add(number1.ToString() + " / " + number2.ToString() + " = " + total.ToString());
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox4.Text = "X";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox4.Text = "/";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}