using System.CodeDom;

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
            string imagepath = "C:/Users/Lenovo/Downloads/SunShine.jpg";
            try
            {
              pictureBox1.Image=  System.Drawing.Image.FromFile(imagepath);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;

        }
    }
}