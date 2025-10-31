namespace Practica2_TablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, count = 0, limite;
            n = int.Parse(textBox1.Text);
            limite = int.Parse(textBox2.Text);

            // Limpiar el ListBox antes de agregar nuevos elementos
            listBox1.Items.Clear();

            do
            {
                listBox1.Items.Add(n + " * " + count + " = " + (n * count));
                count++;
            } while (count <= limite);
        }
    }
}
