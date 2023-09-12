namespace dima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\Student\Downloads\Без названия.jfif";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
