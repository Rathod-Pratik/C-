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
            String SelectOption = "";
            if (radioButton1.Checked)
            {
                SelectOption = "Option1 is selected";
            }
            else if (radioButton2.Checked)
            {
                SelectOption = "Option2 is selected";
            }
            else if (radioButton3.Checked)
            {
                SelectOption = "Option 3 is selected";
            }
            else
            {
                SelectOption = "No Option selected";
            }
            MessageBox.Show(SelectOption, "Selection Result");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
