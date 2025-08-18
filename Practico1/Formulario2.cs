using System;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        // --- Métodos de eventos de controles de texto ---

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // No hace falta modificar nada aquí si solo quieres apellido y nombre
        }

        private void TextBox2_TextChanged(object sender, EventArgs e) { }

        private void TextBox3_TextChanged(object sender, EventArgs e) { }

        // --- Métodos de eventos de botones ---

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CamposObligatoriosVacios())
            {
                MessageBox.Show(
                    "Debe completar todos los campos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Inserción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (confirmacion == DialogResult.Yes)
            {
                ActualizarLabel();
                MessageBox.Show(
                    $"El Cliente: {TApellido.Text} {TNombre.Text} se insertó correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show(
                $"Está apunto de eliminar el Cliente: {TApellido.Text} {TNombre.Text}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                LModificar.Text = "modificar";
                MessageBox.Show(
                    $"El Cliente: {TApellido.Text} {TNombre.Text} se eliminó correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarCampos();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Métodos de eventos de radio buttons ---

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (RBHombre.Checked)
            {
                RBMujer.Checked = false;
                pictureBox1.Image = Properties.Resources.bussiness_man;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                RBHombre.Checked = false;
                pictureBox1.Image = Properties.Resources.businesswoman;
            }
        }

        // --- Métodos de eventos de validación de entrada ---

        private void TDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // --- Métodos auxiliares ---

        private void ActualizarLabel()
        {
            LModificar.Text = $"{TApellido.Text} {TNombre.Text}";
        }

        private void LimpiarCampos()
        {
            TDNI.Clear();
            TApellido.Clear();
            TNombre.Clear();
            TTelefono.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private bool CamposObligatoriosVacios()
        {
            return string.IsNullOrWhiteSpace(TDNI.Text)
                || string.IsNullOrWhiteSpace(TApellido.Text)
                || string.IsNullOrWhiteSpace(TNombre.Text);
        }

        // --- Métodos de eventos de etiquetas (sin implementación) ---

        private void LModificar_Click(object sender, EventArgs e) { }

        private void LNyA_Click(object sender, EventArgs e) { }
    }
}
