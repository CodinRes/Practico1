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
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
            ColumnaFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellido.Text.Trim();
            string nombre = textBoxNombre.Text.Trim();
            string fechaNacimiento = dateTimePicker1.Value.ToShortDateString();
            string sexo = radioButtonHombre.Checked ? "Hombre" : "Mujer";
            string saldoText = textBoxSaldo.Text.Trim();
            Image foto = pictureBoxFotoPerfil.Image;
            string ruta = textBoxRuta.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(saldoText))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(saldoText, out decimal saldoDecimal))
            {
                MessageBox.Show("El campo Saldo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (saldoDecimal < 0)
            {
                MessageBox.Show("El campo Saldo no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = dataGridView1.Rows.Add(apellido, nombre, fechaNacimiento, sexo, saldoDecimal.ToString("F2"), foto, ruta, "Eliminar");

            if (saldoDecimal < 50)
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            pictureBoxFotoPerfil.Image = Properties.Resources.user;
            textBoxRuta.Clear();
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            textBoxSaldo.Clear();
        }

        private void textBoxRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BotonFoto_Click(object sender, EventArgs e)
        {
            // Configura el filtro para mostrar solo imágenes
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Seleccionar imagen de perfil";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Muestra la ruta en el TextBox
                textBoxRuta.Text = openFileDialog1.FileName;
                try
                {
                    // Carga la imagen seleccionada en el PictureBox
                    pictureBoxFotoPerfil.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?",
                                                         "Confirmar",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
