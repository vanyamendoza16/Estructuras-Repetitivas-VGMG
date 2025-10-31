namespace Practica7_RangoSuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangeinferior, rangesuperior, suma = 0;

            rangeinferior = int.Parse(textBox1.Text);
            rangesuperior = int.Parse(textBox2.Text);

            // Limpiar ListBox antes de agregar nuevos números
            listBox1.Items.Clear();

            for (int i = rangeinferior; i <= rangesuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }

            textBox3.Text = suma.ToString();
        }
    }
}
