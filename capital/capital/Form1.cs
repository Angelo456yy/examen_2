namespace capital
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

        private void Calcular_Click(object sender, EventArgs e)
        {
            Double Mi = double.Parse(MI.Text);
            double TIa = double.Parse(Taza.Text);
            int pi = int.Parse(Pi.Text);

            double calcular = Mi * 1 + TIa * pi / 100;

            double intereses = calcular * (Math.Pow(1 + TIa / 100, pi) - 1);

            MessageBox.Show("tu capital es\n " + calcular + "\n tus intereses son de: " + intereses);
        }

        private void MI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taza_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click_1(object sender, EventArgs e)
        {
            Double Mi = double.Parse(MI.Text);
            double TIa = double.Parse(Taza.Text);
            int pi = int.Parse(Pi.Text);

            double calcular = Mi * 1 + TIa * pi / 100;

            MessageBox.Show("Tu capital es de:  " + calcular + "\n Tu intereses acumulados son de: ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MI.Clear();
            Taza.Clear();
            Pi.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
