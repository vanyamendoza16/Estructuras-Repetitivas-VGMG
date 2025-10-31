namespace Practica3_SumaNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar el número del TextBox1 al ListBox
            listBox1.Items.Add(textBox1.Text);

            // Limpiar el TextBox1 para nuevo número
            textBox1.Text = "";

            // Poner el foco en TextBox1 para seguir escribiendo
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double suma = 0;

            // Recorrer todos los números en el ListBox y sumarlos
            foreach (string numero in listBox1.Items)
            {
                suma += double.Parse(numero);
            }

            // Mostrar el resultado en TextBox2
            textBox2.Text = suma.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
