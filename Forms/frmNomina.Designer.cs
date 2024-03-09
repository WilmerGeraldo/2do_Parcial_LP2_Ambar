namespace _2do_Parcial_LP2.Forms
{
    partial class frmNomina
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dtpFechaNomina = new DateTimePicker();
            cboTipoNomina = new ComboBox();
            txtNúmeroNomina = new TextBox();
            mtxtCedulaEmpleado = new MaskedTextBox();
            txtNombreEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtCargoEmpleado = new TextBox();
            txtDepartamento = new TextBox();
            txtSueldoBruto = new TextBox();
            txtSeguroSocial = new TextBox();
            txtAFP = new TextBox();
            txtDescuentoCXC = new TextBox();
            txtSueldoNeto = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnModificar = new Button();
            btnRegistrar = new Button();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Nº. Nómina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 29);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 0;
            label2.Text = "Tipo de Nomina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 84);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 0;
            label3.Text = "Cédula Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 134);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 183);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 0;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(124, 229);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 0;
            label6.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(121, 275);
            label7.Name = "label7";
            label7.Size = new Size(109, 19);
            label7.TabIndex = 0;
            label7.Text = "Departamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(544, 86);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 0;
            label8.Text = "Sueldo Bruto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(793, 29);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 0;
            label9.Text = "Fecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(544, 137);
            label10.Name = "label10";
            label10.Size = new Size(101, 19);
            label10.TabIndex = 0;
            label10.Text = "Seguro Social";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(544, 185);
            label11.Name = "label11";
            label11.Size = new Size(35, 19);
            label11.TabIndex = 0;
            label11.Text = "AFP";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(544, 231);
            label12.Name = "label12";
            label12.Size = new Size(130, 19);
            label12.TabIndex = 0;
            label12.Text = "Descuento de CXC";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(544, 277);
            label13.Name = "label13";
            label13.Size = new Size(94, 19);
            label13.TabIndex = 0;
            label13.Text = "Sueldo Neto";
            // 
            // dtpFechaNomina
            // 
            dtpFechaNomina.Format = DateTimePickerFormat.Short;
            dtpFechaNomina.Location = new Point(847, 28);
            dtpFechaNomina.Name = "dtpFechaNomina";
            dtpFechaNomina.Size = new Size(122, 23);
            dtpFechaNomina.TabIndex = 3;
            // 
            // cboTipoNomina
            // 
            cboTipoNomina.FormattingEnabled = true;
            cboTipoNomina.Items.AddRange(new object[] { "Semanal", "Quicenal", "Mensual" });
            cboTipoNomina.Location = new Point(480, 28);
            cboTipoNomina.Name = "cboTipoNomina";
            cboTipoNomina.Size = new Size(201, 23);
            cboTipoNomina.TabIndex = 2;
            // 
            // txtNúmeroNomina
            // 
            txtNúmeroNomina.Location = new Point(124, 27);
            txtNúmeroNomina.Name = "txtNúmeroNomina";
            txtNúmeroNomina.Size = new Size(129, 23);
            txtNúmeroNomina.TabIndex = 1;
            // 
            // mtxtCedulaEmpleado
            // 
            mtxtCedulaEmpleado.Location = new Point(259, 82);
            mtxtCedulaEmpleado.Margin = new Padding(2);
            mtxtCedulaEmpleado.Mask = "000-0000000-0";
            mtxtCedulaEmpleado.Name = "mtxtCedulaEmpleado";
            mtxtCedulaEmpleado.Size = new Size(129, 23);
            mtxtCedulaEmpleado.TabIndex = 4;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(198, 133);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(190, 23);
            txtNombreEmpleado.TabIndex = 5;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(198, 179);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(190, 23);
            txtApellidoEmpleado.TabIndex = 6;
            // 
            // txtCargoEmpleado
            // 
            txtCargoEmpleado.Location = new Point(198, 227);
            txtCargoEmpleado.Name = "txtCargoEmpleado";
            txtCargoEmpleado.Size = new Size(190, 23);
            txtCargoEmpleado.TabIndex = 7;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(236, 273);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(190, 23);
            txtDepartamento.TabIndex = 8;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(651, 83);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(190, 23);
            txtSueldoBruto.TabIndex = 9;
            // 
            // txtSeguroSocial
            // 
            txtSeguroSocial.Location = new Point(651, 135);
            txtSeguroSocial.Name = "txtSeguroSocial";
            txtSeguroSocial.Size = new Size(190, 23);
            txtSeguroSocial.TabIndex = 10;
            // 
            // txtAFP
            // 
            txtAFP.Location = new Point(651, 183);
            txtAFP.Name = "txtAFP";
            txtAFP.Size = new Size(190, 23);
            txtAFP.TabIndex = 11;
            // 
            // txtDescuentoCXC
            // 
            txtDescuentoCXC.Location = new Point(681, 228);
            txtDescuentoCXC.Name = "txtDescuentoCXC";
            txtDescuentoCXC.Size = new Size(190, 23);
            txtDescuentoCXC.TabIndex = 12;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(651, 275);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(190, 23);
            txtSueldoNeto.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkOrange;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(572, 329);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 32);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOrange;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnActualizar.Location = new Point(460, 329);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 32);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkOrange;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnModificar.Location = new Point(348, 329);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 32);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkOrange;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnRegistrar.Location = new Point(236, 329);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(92, 32);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1000, 191);
            dataGridView1.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkOrange;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(681, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 32);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(998, 566);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtDepartamento);
            Controls.Add(txtCargoEmpleado);
            Controls.Add(txtApellidoEmpleado);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtDescuentoCXC);
            Controls.Add(txtAFP);
            Controls.Add(txtSeguroSocial);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(mtxtCedulaEmpleado);
            Controls.Add(txtNúmeroNomina);
            Controls.Add(cboTipoNomina);
            Controls.Add(dtpFechaNomina);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNomina";
            Text = "Nomina";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DateTimePicker dtpFechaNomina;
        private ComboBox cboTipoNomina;
        private TextBox txtNúmeroNomina;
        private MaskedTextBox mtxtCedulaEmpleado;
        private TextBox txtNombreEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtCargoEmpleado;
        private TextBox txtDepartamento;
        private TextBox txtSueldoBruto;
        private TextBox txtSeguroSocial;
        private TextBox txtAFP;
        private TextBox txtDescuentoCXC;
        private TextBox txtSueldoNeto;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnModificar;
        private Button btnRegistrar;
        private DataGridView dataGridView1;
        private Button btnSalir;
    }
}