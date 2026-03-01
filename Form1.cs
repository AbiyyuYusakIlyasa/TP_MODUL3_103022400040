namespace TP_MODUL3_103022400040
{
    public partial class Form1 : Form
    {
        int angka1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += "2";
        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            label1.Text += "3";
        }
        private void button6_Click_5(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click_4(object sender, EventArgs e)
        {
            label1.Text += "5";
        }
        private void button4_Click_3(object sender, EventArgs e)
        {
            label1.Text += "6";
        }
        private void button9_Click_6(object sender, EventArgs e)
        {
            label1.Text += "9";
        }
        private void button8_Click_7(object sender, EventArgs e)
        {
            label1.Text += "8";
        }
        private void button7_Click_8(object sender, EventArgs e)
        {
            label1.Text += "7";
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(label1.Text);
            label1.Text = "";
        }
        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            int angka2 = int.Parse(label1.Text);
            int hasil = angka1 + angka2;
            label1.Text = hasil.ToString();
        }
    }
}
