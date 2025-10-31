namespace Practica9_Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el número ingresado
            ulong numero = ulong.Parse(textBox1.Text);
            ulong factorial = 1;

            // Limpiar ListBox antes de comenzar
            listBox1.Items.Clear();

            // Calcular factorial
            for (ulong i = 1; i <= numero; i++)
            {
                listBox1.Items.Add(i);
                factorial = factorial * i;
            }

            // Mostrar resultados
            textBox2.Text = numero.ToString();
            textBox3.Text = factorial.ToString();
        }
    }
}
