using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Deshabilitar el botón al inicio
            OK.Enabled = false;
        }
        public string GetTextBox1Value()
        {
            return textBox1.Text;
        }

        public string GetTextBox3Value()
        {
            return textBox3.Text;
        }

        private void CheckTextBoxes()
        {
            // Verificar si todos los cuadros de texto contienen texto
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text))
            {
                // Habilitar el botón si todos los cuadros de texto están llenos
                OK.Enabled = true;
            }
            else
            {
                // Deshabilitar el botón si algún cuadro de texto está vacío
                OK.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (CheckAllTextBoxesFilled())
            {
               
                Form1 Form1 = new Form1();
                Form1.Show();
               
            }
        }

        private bool CheckAllTextBoxesFilled()
        {
            // Verificar si todos los cuadros de texto contienen texto
            return !string.IsNullOrEmpty(textBox1.Text) &&
                   !string.IsNullOrEmpty(textBox2.Text) &&
                   !string.IsNullOrEmpty(textBox3.Text) &&
                   !string.IsNullOrEmpty(textBox4.Text);
        }
    }
}
