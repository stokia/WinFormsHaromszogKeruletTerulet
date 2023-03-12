namespace WinFormsHaromszogKeruletTerulet
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

        }

        private void bOldal_Click(object sender, EventArgs e)
        {

        }

        private void cOldal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            HaromszogKeruletTerulet(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), Convert.ToDouble(textBoxC.Text));

        }
        void HaromszogKeruletTerulet(double a, double b, double c)
        {
            if (!(a < b + c) || !(b < a + c) || !(c < b + a)) /* haromszog tetele: 1 oldal hossza nem lehet nagyobb a masik 2 oldal hosszanak osszegevel, a tetelt megforditom (!) operatorral */
            {
                labelKerulet.Text = "Kerület:" + " Nem számítható ki";
                labelTerulet.Text = "Terület:" + " Nem számítható ki";
                labelHibauzenet.Text = "A háromszög bármely oldala nem lehet nagyobb a másik kettõ oldal összegénél!";

            }
            else
            {
                double kerulet, terulet;
                kerulet = a + b + c;
                double s;
                s = kerulet / 2;
                terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                labelKerulet.Text = "Kerület:" + kerulet.ToString();
                labelTerulet.Text = "Terület:" + terulet.ToString();
            }

        }

    }
}