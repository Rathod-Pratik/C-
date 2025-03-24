namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input from textBox1 and textBox2
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                // Calculate sum
                int sum = num1 + num2;

                // Display result (e.g., using a label or MessageBox)
                MessageBox.Show($"The sum is: {sum}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
