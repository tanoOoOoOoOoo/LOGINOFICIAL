using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string contraseña = textBox2.Text;

            // Verificar si el usuario y la contraseña están rellenados
            if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(contraseña))
            {
                // Aquí puedes realizar la autenticación
                // Puedes comparar con credenciales predefinidas o realizar una verificación en una base de datos, etc.

                // Ejemplo de verificación simple
                if (Nombre == "usuario" && contraseña == "contraseña")
                {
                    MessageBox.Show("¡Inicio de sesión exitoso!");
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intenta de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa tanto el usuario como la contraseña.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica para el registro de nuevos usuarios
            // Puedes abrir otro formulario para el registro o realizar operaciones necesarias.

            MessageBox.Show("¡Registro de nuevo usuario!");
        }
    }
    }

