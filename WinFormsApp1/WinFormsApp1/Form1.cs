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

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl1.png");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl2.png");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl3.png");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl4.png");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl5.png");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl6.png");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl7.jpg");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl8.png");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl9.png");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\img\fl10.png");
        }
    }
}