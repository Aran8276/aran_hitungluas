namespace aran_hitungluas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 panggil = new Form2();
            panggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 panggil = new Form3();
            panggil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
