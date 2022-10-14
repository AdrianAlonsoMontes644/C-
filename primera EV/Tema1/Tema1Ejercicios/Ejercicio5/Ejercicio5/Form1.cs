namespace Ejercicio5
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
            DialogResult mensaje;
            mensaje = MessageBox.Show("¿Quieres poner " +textBox1.Text+ " como título?", "Cambio de Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                this.Text= textBox1.Text;
            }
        }
    }
}