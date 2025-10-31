namespace Practica10_z___x____x_
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cua, cub, zeta;

            // Limpiar todos los ListBox antes de comenzar
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            for (i = 1; i <= 50; i++)
            {
                cua = i * i;        // x²
                cub = i * i * i;    // x³
                zeta = cua + cub;   // z = x² + x³

                listBox1.Items.Add(i);
                listBox2.Items.Add(cua);
                listBox3.Items.Add(cub);
                listBox4.Items.Add(zeta);
            }
        }
    }
}
