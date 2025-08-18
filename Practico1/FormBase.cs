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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Buscar si ya hay una instancia abierta de Formulario1
            var formAbierto = Application.OpenForms.OfType<Formulario1>().FirstOrDefault();
            if (formAbierto == null)
            {
                Formulario1 form1 = new Formulario1();
                form1.Show();
            }
            else
            {
                // Si ya está abierto, lo traemos al frente
                formAbierto.BringToFront();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Buscar si ya hay una instancia abierta de Formulario1
            var formAbierto = Application.OpenForms.OfType<Formulario2>().FirstOrDefault();
            if (formAbierto == null)
            {
                Formulario2 form2 = new Formulario2();
                form2.Show();
            }
            else
            {
                // Si ya está abierto, lo traemos al frente
                formAbierto.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}