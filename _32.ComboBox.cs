namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Veraval");
                comboBox1.Items.Add("Rajkot");
                comboBox1.Items.Add("Ahemdabad");
                comboBox1.Items.Add("Bombay");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem != null)
            {
                string selectOption = comboBox1.SelectedItem.ToString();
                MessageBox.Show("You selected: " + selectOption);
            }
            else
            {
                MessageBox.Show("Please select an option first.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}