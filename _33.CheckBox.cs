namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SelectOption = "";
            if (checkBox1.Checked)
            {
                SelectOption = "You selected first Option";
            }
            else if (checkBox2.Checked)
            {
                SelectOption = "You selected second Option";
            }
            else if (checkBox3.Checked)
            {
                SelectOption = "You selected thired Option";
            }
            else
            {
                SelectOption = "Please Select option";
            }
            MessageBox.Show(SelectOption);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }
    }
}