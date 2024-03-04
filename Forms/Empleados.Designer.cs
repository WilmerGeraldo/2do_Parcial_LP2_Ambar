namespace _2do_Parcial_LP2.Forms
{
    partial class frmEmpleados
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
            txtNombre = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            txtApellido = new TextBox();
            txtCodigo = new TextBox();
            txtCedula = new TextBox();
            txtDepartamento = new TextBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            dgvRegistroEmpleado = new DataGridView();
            btnModificar = new Button();
            btnActualizar = new Button();
            cboCargo = new ComboBox();
            btnEliminar = new Button();
            dtpFechaInicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrar Empleados";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 109);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(297, 426);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(131, 52);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(203, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 31);
            txtApellido.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(203, 195);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 31);
            txtCodigo.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(203, 240);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(182, 31);
            txtCedula.TabIndex = 1;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(778, 109);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(196, 31);
            txtDepartamento.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(778, 171);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(196, 31);
            txtDireccion.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(778, 243);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(203, 339);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(182, 31);
            txtTelefono.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 153);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 291);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 2;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(607, 108);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 2;
            label5.Text = "Departamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 339);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 2;
            label6.Text = "Fecha de Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(615, 246);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 2;
            label7.Text = "Gmail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(694, 115);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 339);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 4;
            label9.Text = "Telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(112, 201);
            label10.Name = "label10";
            label10.Size = new Size(71, 25);
            label10.TabIndex = 4;
            label10.Text = "Codigo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(117, 246);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 4;
            label11.Text = "Cedula";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(615, 171);
            label13.Name = "label13";
            label13.Size = new Size(85, 25);
            label13.TabIndex = 5;
            label13.Text = "Direccion";
            // 
            // dgvRegistroEmpleado
            // 
            dgvRegistroEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroEmpleado.Location = new Point(0, 507);
            dgvRegistroEmpleado.Name = "dgvRegistroEmpleado";
            dgvRegistroEmpleado.RowHeadersWidth = 62;
            dgvRegistroEmpleado.Size = new Size(1133, 184);
            dgvRegistroEmpleado.TabIndex = 6;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(457, 425);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 55);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(617, 425);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 55);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(203, 288);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(182, 33);
            cboCargo.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(777, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 55);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(778, 339);
            dtpFechaInicio.MaxDate = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            dtpFechaInicio.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(196, 31);
            dtpFechaInicio.TabIndex = 10;
            dtpFechaInicio.Value = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 690);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnEliminar);
            Controls.Add(cboCargo);
            Controls.Add(btnActualizar);
            Controls.Add(btnModificar);
            Controls.Add(dgvRegistroEmpleado);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnRegistrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtEmail);
            Controls.Add(txtCodigo);
            Controls.Add(txtDepartamento);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmEmpleados";
            Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Button btnRegistrar;
        private TextBox txtApellido;
        private TextBox txtCodigo;
        private TextBox txtCedula;
        private TextBox txtDepartamento;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private DataGridView dgvRegistroEmpleado;
        private Button btnModificar;
        private Button btnActualizar;
        private ComboBox cboCargo;
        private Button btnEliminar;
        private DateTimePicker dtpFechaInicio;
    }
}