namespace notsistemi
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(textBox1.Text);

            if ((sonuc > 100) || (sonuc < 0))
            {
                MessageBox.Show("Yanlış Not Girdiniz");
            }
            else if (sonuc > 60)
            {
                MessageBox.Show("Geçtiniz");
            }
            else
            {
                MessageBox.Show("KALDINIZ!!!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
