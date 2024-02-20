using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();  // Crear una instancia de Form2 al iniciar Form1
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si textBox1 y textBox3 son iguales a los de Form2
            if (textBox1.Text == form2.GetTextBox1Value() && textBox2.Text == form2.GetTextBox3Value())
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}