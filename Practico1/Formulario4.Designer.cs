namespace Practico1
{
    partial class Formulario4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario4));
            BotonGuardar = new Button();
            BotonFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            dateTimePicker1 = new DateTimePicker();
            pictureBoxFotoPerfil = new PictureBox();
            panel1 = new Panel();
            textBoxRuta = new TextBox();
            radioButtonMujer = new RadioButton();
            radioButtonHombre = new RadioButton();
            textBoxSaldo = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaNacimiento = new DataGridViewTextBoxColumn();
            ColumnaSexo = new DataGridViewTextBoxColumn();
            ColumnaSaldo = new DataGridViewTextBoxColumn();
            ColumnaFoto = new DataGridViewImageColumn();
            ColumnaRuta = new DataGridViewTextBoxColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFotoPerfil).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BotonGuardar
            // 
            BotonGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonGuardar.Image = (Image)resources.GetObject("BotonGuardar.Image");
            BotonGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGuardar.Location = new Point(280, 304);
            BotonGuardar.Margin = new Padding(2, 1, 2, 1);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(108, 48);
            BotonGuardar.TabIndex = 0;
            BotonGuardar.Text = "Agregar";
            BotonGuardar.TextAlign = ContentAlignment.MiddleRight;
            BotonGuardar.UseVisualStyleBackColor = true;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // BotonFoto
            // 
            BotonFoto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonFoto.Location = new Point(32, 272);
            BotonFoto.Margin = new Padding(2, 1, 2, 1);
            BotonFoto.Name = "BotonFoto";
            BotonFoto.Size = new Size(72, 24);
            BotonFoto.TabIndex = 1;
            BotonFoto.Text = "Foto";
            BotonFoto.UseVisualStyleBackColor = true;
            BotonFoto.Click += BotonFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(224, 128);
            dateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker1.MaxDate = new DateTime(2025, 8, 25, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(424, 35);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2025, 8, 25, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBoxFotoPerfil
            // 
            pictureBoxFotoPerfil.BackColor = Color.Transparent;
            pictureBoxFotoPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxFotoPerfil.Image = Properties.Resources.user;
            pictureBoxFotoPerfil.Location = new Point(800, 40);
            pictureBoxFotoPerfil.Margin = new Padding(2, 1, 2, 1);
            pictureBoxFotoPerfil.MaximumSize = new Size(350, 360);
            pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            pictureBoxFotoPerfil.Size = new Size(350, 360);
            pictureBoxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFotoPerfil.TabIndex = 4;
            pictureBoxFotoPerfil.TabStop = false;
            pictureBoxFotoPerfil.Click += pictureBoxFotoPerfil_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.negro;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textBoxRuta);
            panel1.Controls.Add(radioButtonMujer);
            panel1.Controls.Add(radioButtonHombre);
            panel1.Controls.Add(BotonGuardar);
            panel1.Controls.Add(textBoxSaldo);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BotonFoto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(128, 40);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 360);
            panel1.TabIndex = 5;
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(112, 272);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(536, 23);
            textBoxRuta.TabIndex = 12;
            textBoxRuta.TextChanged += textBoxRuta_TextChanged;
            // 
            // radioButtonMujer
            // 
            radioButtonMujer.AutoSize = true;
            radioButtonMujer.BackColor = Color.Transparent;
            radioButtonMujer.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonMujer.ForeColor = SystemColors.Control;
            radioButtonMujer.Location = new Point(400, 176);
            radioButtonMujer.Name = "radioButtonMujer";
            radioButtonMujer.Size = new Size(88, 37);
            radioButtonMujer.TabIndex = 11;
            radioButtonMujer.Text = "Mujer";
            radioButtonMujer.UseVisualStyleBackColor = false;
            radioButtonMujer.CheckedChanged += radioButtonMujer_CheckedChanged;
            // 
            // radioButtonHombre
            // 
            radioButtonHombre.AutoSize = true;
            radioButtonHombre.BackColor = Color.Transparent;
            radioButtonHombre.Checked = true;
            radioButtonHombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonHombre.ForeColor = SystemColors.Control;
            radioButtonHombre.Location = new Point(224, 176);
            radioButtonHombre.Name = "radioButtonHombre";
            radioButtonHombre.Size = new Size(107, 37);
            radioButtonHombre.TabIndex = 10;
            radioButtonHombre.TabStop = true;
            radioButtonHombre.Text = "Hombre";
            radioButtonHombre.UseVisualStyleBackColor = false;
            radioButtonHombre.CheckedChanged += radioButtonHombre_CheckedChanged;
            // 
            // textBoxSaldo
            // 
            textBoxSaldo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSaldo.Location = new Point(112, 224);
            textBoxSaldo.Margin = new Padding(2, 1, 2, 1);
            textBoxSaldo.Name = "textBoxSaldo";
            textBoxSaldo.Size = new Size(536, 35);
            textBoxSaldo.TabIndex = 9;
            textBoxSaldo.TextChanged += textBoxSaldo_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellido.Location = new Point(136, 80);
            textBoxApellido.Margin = new Padding(2, 1, 2, 1);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(512, 35);
            textBoxApellido.TabIndex = 8;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(128, 32);
            textBoxNombre.Margin = new Padding(2, 1, 2, 1);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(520, 35);
            textBoxNombre.TabIndex = 7;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Papyrus", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(32, 224);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 33);
            label5.TabIndex = 4;
            label5.Text = "Saldo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Papyrus", 15.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(32, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 33);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Papyrus", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 128);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 33);
            label3.TabIndex = 2;
            label3.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Papyrus", 15.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(32, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 33);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 33);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaApellido, ColumnaNombre, ColumnaNacimiento, ColumnaSexo, ColumnaSaldo, ColumnaFoto, ColumnaRuta, ColumnaEliminar });
            dataGridView1.Location = new Point(24, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1216, 238);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnaApellido
            // 
            ColumnaApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaApellido.HeaderText = "Apellido";
            ColumnaApellido.Name = "ColumnaApellido";
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaNombre.HeaderText = "Nombre";
            ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaNacimiento
            // 
            ColumnaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaNacimiento.HeaderText = "Fecha Nacimiento";
            ColumnaNacimiento.Name = "ColumnaNacimiento";
            // 
            // ColumnaSexo
            // 
            ColumnaSexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaSexo.HeaderText = "Sexo";
            ColumnaSexo.Name = "ColumnaSexo";
            // 
            // ColumnaSaldo
            // 
            ColumnaSaldo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaSaldo.HeaderText = "Saldo";
            ColumnaSaldo.Name = "ColumnaSaldo";
            // 
            // ColumnaFoto
            // 
            ColumnaFoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaFoto.HeaderText = "Foto";
            ColumnaFoto.Name = "ColumnaFoto";
            // 
            // ColumnaRuta
            // 
            ColumnaRuta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaRuta.HeaderText = "Ruta";
            ColumnaRuta.Name = "ColumnaRuta";
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnaEliminar.HeaderText = "Eliminar";
            ColumnaEliminar.Name = "ColumnaEliminar";
            ColumnaEliminar.Resizable = DataGridViewTriState.True;
            ColumnaEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnaEliminar.Text = "Eliminar";
            ColumnaEliminar.UseColumnTextForButtonValue = true;
            ColumnaEliminar.Width = 75;
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxFotoPerfil);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Formulario4";
            Text = "Formulario con Grid";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFotoPerfil).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGuardar;
        private Button BotonFoto;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBoxFotoPerfil;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxSaldo;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private RadioButton radioButtonMujer;
        private RadioButton radioButtonHombre;
        private TextBox textBoxRuta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaNacimiento;
        private DataGridViewTextBoxColumn ColumnaSexo;
        private DataGridViewTextBoxColumn ColumnaSaldo;
        private DataGridViewImageColumn ColumnaFoto;
        private DataGridViewTextBoxColumn ColumnaRuta;
        private DataGridViewButtonColumn ColumnaEliminar;
    }
}