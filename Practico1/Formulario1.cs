namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                this.textBox3.AppendText(String.Concat(textBox1.Text, textBox2.Text));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
