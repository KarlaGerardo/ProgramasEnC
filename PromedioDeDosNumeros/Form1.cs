namespace PromedioDeDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(textBox1.Text);
            int numero2 = Int32.Parse(textBox2.Text);
            int numero3 = Int32.Parse(textBox3.Text);

            double promedio = (Double) (numero1 + numero2 + numero3) / 3;

            MessageBox.Show("El promedio de los tres números es: " + promedio);

        }

    }
}