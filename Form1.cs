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

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\192.168.3.250\Veda\3 курс\ИСП 32-9\Пономарев\neriks.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    
    }
}
