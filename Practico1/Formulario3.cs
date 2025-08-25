using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario3 : Form
    {
        int desde, hasta;

        public Formulario3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Opcional: validación en tiempo real (solo números)
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten números.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Opcional: validación en tiempo real (solo números)
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten números.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!controlarRango())
            {
                return;
            }

            // Cargar números en el ListBox usando un bucle for
            for (int i = desde; i <= hasta; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Por ahora no hace nada, pero puedes manejar eventos si seleccionan un número
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!controlarRango())
            {
                return;
            }

            // Cargar números en el ListBox usando un bucle for
            for (int i = desde; i <= hasta; i++)
            {
                if (int.IsEvenInteger(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!controlarRango())
            {
                return;
            }

            // Cargar números en el ListBox usando un bucle for
            for (int i = desde; i <= hasta; i++)
            {
                if (int.IsOddInteger(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!controlarRango())
            {
                return;
            }

            // Cargar números en el ListBox usando un bucle for
            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        /// <summary>
        /// controla el rango ingresado en los TextBox
        /// </summary>
        /// <returns>devuelve true si el rango es correcto, false si no lo es
        /// </returns>
        private bool controlarRango()
        {
            listBox1.Items.Clear(); // Limpiamos el ListBox antes de cargar datos

            // Validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Debe completar ambos campos.");
                return false;
            }

            // Convertir valores
            if (!int.TryParse(textBox1.Text, out desde) || !int.TryParse(textBox2.Text, out hasta))
            {
                MessageBox.Show("Debe ingresar valores numéricos válidos.");
                return false;
            }

            // Validar que el rango sea correcto
            if (desde > hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual a 'Hasta'.");
                return false;
            }

            return true;
        }

        private static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}