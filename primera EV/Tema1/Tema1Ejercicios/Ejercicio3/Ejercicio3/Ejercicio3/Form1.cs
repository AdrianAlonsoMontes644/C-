using System.CodeDom.Compiler;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        int dinero = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random generador = new Random();

            int num1 = generador.Next(1, 8); 
            int num2 = generador.Next(1, 8);
            int num3 = generador.Next(1, 8);

            textBox1.Text = Convert.ToString(num1);
            textBox2.Text = Convert.ToString(num2);
            textBox3.Text = Convert.ToString(num3);

            dinero = dinero - 2;

            label2.Text = "Tienes = " + dinero.ToString() + "€";

            if(num1 == num2 && num2 == num3)
            {
                label1.Text = "¡Felicidades. Has ganado 20€!";

                dinero = dinero + 20;

                label2.Text = "Tienes = " + dinero.ToString() + "€";
            }else if(num1 == num2 || num1 == num3 | num2 == num3)
            {
                label1.Text = "¡Felicidades. Has ganado 5€!";
#if DEBUG
                dinero = dinero - 5;
#else
                dinero = dinero + 5;
#endif
                label2.Text = "Tienes = " + dinero.ToString() + "€";
            }
            else
            {
                label1.Text = "No Has Ganado Nada";
            }

            button1.Enabled = dinero!=0;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dinero = dinero + 10;
            label2.Text = "Tienes = " + dinero + "€";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}