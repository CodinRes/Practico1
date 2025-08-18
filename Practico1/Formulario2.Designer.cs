namespace Practico1
{
    partial class Formulario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario2));

            // --- Inicialización de controles ---
            LNyA = new Label();
            LModificar = new Label();
            LDNI = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TDNI = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            checkBox3 = new CheckBox();
            label1 = new Label();
            TTelefono = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            pictureBox1 = new PictureBox();
            RBHombre = new RadioButton();
            RBMujer = new RadioButton();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // --- LNyA ---
            LNyA.AutoSize = true;
            LNyA.BackColor = SystemColors.ControlDarkDark;
            LNyA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNyA.Location = new Point(16, 8);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(144, 21);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            LNyA.Click += LNyA_Click;

            // --- LModificar ---
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.ControlDarkDark;
            LModificar.Font = new Font("Segoe UI", 12F);
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(160, 8);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(76, 21);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";

            // --- LDNI ---
            LDNI.AutoSize = true;
            LDNI.BackColor = SystemColors.ControlDarkDark;
            LDNI.Font = new Font("Segoe UI", 12F);
            LDNI.Location = new Point(48, 80);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(51, 21);
            LDNI.TabIndex = 2;
            LDNI.Text = "* DNI:";

            // --- LApellido ---
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.ControlDarkDark;
            LApellido.Font = new Font("Segoe UI", 12F);
            LApellido.Location = new Point(16, 120);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(81, 21);
            LApellido.TabIndex = 3;
            LApellido.Text = "* Apellido:";

            // --- LNombre ---
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.ControlDarkDark;
            LNombre.Font = new Font("Segoe UI", 12F);
            LNombre.Location = new Point(16, 160);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(82, 21);
            LNombre.TabIndex = 4;
            LNombre.Text = "* Nombre:";

            // --- TDNI ---
            TDNI.Location = new Point(104, 80);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(152, 23);
            TDNI.TabIndex = 5;
            TDNI.TextChanged += TextBox1_TextChanged;
            TDNI.KeyPress += TDNI_KeyPress;

            // --- TApellido ---
            TApellido.Location = new Point(104, 120);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(152, 23);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TextBox2_TextChanged;

            // --- TNombre ---
            TNombre.Location = new Point(104, 160);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(152, 23);
            TNombre.TabIndex = 7;
            TNombre.TextChanged += TextBox3_TextChanged;

            // --- button1 (Guardar) ---
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(24, 424);
            button1.Name = "button1";
            button1.Size = new Size(136, 64);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;

            // --- button2 (Eliminar) ---
            button2.Font = new Font("Segoe UI", 12F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(192, 424);
            button2.Name = "button2";
            button2.Size = new Size(136, 64);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;

            // --- button3 (Salir) ---
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(16, 680);
            button3.Name = "button3";
            button3.Size = new Size(112, 64);
            button3.TabIndex = 10;
            button3.Text = "Salir";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;

            // --- panel1 ---
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LNyA);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(LDNI);
            panel1.Controls.Add(TDNI);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(16, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 512);
            panel1.TabIndex = 11;

            // --- label2 ---
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 240);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 22;
            label2.Text = "Tarjetas de Credito:";

            // --- checkBox3 ---
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F);
            checkBox3.Location = new Point(160, 304);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 25);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Naranja";
            checkBox3.UseVisualStyleBackColor = true;

            // --- label1 ---
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 200);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 21;
            label1.Text = "Telefono:";

            // --- TTelefono ---
            TTelefono.Location = new Point(104, 200);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(152, 23);
            TTelefono.TabIndex = 20;
            TTelefono.KeyPress += TTelefono_KeyPress;

            // --- checkBox1 ---
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(160, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Mastercard";
            checkBox1.TextAlign = ContentAlignment.BottomCenter;
            checkBox1.UseVisualStyleBackColor = true;

            // --- checkBox2 ---
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F);
            checkBox2.Location = new Point(160, 240);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 25);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Visa";
            checkBox2.TextAlign = ContentAlignment.BottomCenter;
            checkBox2.UseVisualStyleBackColor = true;

            // --- pictureBox1 ---
            pictureBox1.Image = Properties.Resources.bussiness_man;
            pictureBox1.Location = new Point(384, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;

            // --- RBHombre ---
            RBHombre.AutoSize = true;
            RBHombre.Checked = true;
            RBHombre.Font = new Font("Segoe UI", 12F);
            RBHombre.Location = new Point(384, 208);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(85, 25);
            RBHombre.TabIndex = 15;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.TextAlign = ContentAlignment.BottomCenter;
            RBHombre.UseVisualStyleBackColor = true;
            RBHombre.CheckedChanged += RBHombre_CheckedChanged;

            // --- RBMujer ---
            RBMujer.AutoSize = true;
            RBMujer.Font = new Font("Segoe UI", 12F);
            RBMujer.Location = new Point(496, 208);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(69, 25);
            RBMujer.TabIndex = 16;
            RBMujer.Text = "Mujer";
            RBMujer.TextAlign = ContentAlignment.BottomCenter;
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;

            // --- label3 ---
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 8);
            label3.Name = "label3";
            label3.Size = new Size(198, 37);
            label3.TabIndex = 17;
            label3.Text = "Nuevo Cliente";

            // --- Formulario2 ---
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 761);
            Controls.Add(label3);
            Controls.Add(RBMujer);
            Controls.Add(RBHombre);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Name = "Formulario2";
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Campos privados de controles ---
        private Label LNyA;
        private Label LModificar;
        private Label LDNI;
        private Label LApellido;
        private Label LNombre;
        private TextBox TDNI;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private CheckBox checkBox3;
        private TextBox TTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}