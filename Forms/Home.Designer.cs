namespace _2do_Parcial_LP2.Forms
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            btnNomina = new Button();
            btnEmpleados = new Button();
            pictureBox1 = new PictureBox();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            txtUsuario = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnNomina);
            panel1.Controls.Add(btnEmpleados);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 452);
            panel1.TabIndex = 0;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = Color.DarkOrange;
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNomina.Location = new Point(21, 235);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(157, 39);
            btnNomina.TabIndex = 1;
            btnNomina.Text = "Nomina";
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.DarkOrange;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Location = new Point(21, 176);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(157, 39);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("LCDMono", 90F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkOrange;
            lblTime.Location = new Point(8, 36);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(533, 106);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 38, 48);
            panel2.Controls.Add(lblTime);
            panel2.Location = new Point(228, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 179);
            panel2.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(297, 12);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(219, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 14);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnEmpleados;
        private PictureBox pictureBox1;
        private Button btnNomina;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private TextBox txtUsuario;
        private Label label2;
    }
}