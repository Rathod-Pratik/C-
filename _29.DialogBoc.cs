namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result=MessageBox.Show("Do you want to continue ?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Result == DialogResult.Yes) {
                MessageBox.Show("You click Yes");
            }
            if (Result == DialogResult.No) {
                MessageBox.Show("You click No");
            }
        }
    }
}
