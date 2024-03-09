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
            txtId = new TextBox();
            mtxtCedula = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Empleados";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 39);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(69, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(208, 232);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(92, 30);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(142, 66);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(129, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(142, 93);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.MaxLength = 6;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(129, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(545, 36);
            txtDepartamento.Margin = new Padding(2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(138, 23);
            txtDepartamento.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(545, 77);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(138, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(545, 120);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(142, 177);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(129, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(69, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(81, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 2;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(420, 41);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 2;
            label5.Text = "Departamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(419, 179);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 2;
            label6.Text = "Fecha de Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.Location = new Point(425, 124);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 19);
            label7.TabIndex = 2;
            label7.Text = "Gmail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(486, 45);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label9.Location = new Point(69, 179);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 4;
            label9.Text = "Telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label10.Location = new Point(73, 97);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 4;
            label10.Text = "Codigo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label11.Location = new Point(77, 124);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 4;
            label11.Text = "Cedula";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label13.Location = new Point(425, 79);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(73, 19);
            label13.TabIndex = 5;
            label13.Text = "Direccion";
            // 
            // dgvRegistroEmpleado
            // 
            dgvRegistroEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroEmpleado.Location = new Point(0, 277);
            dgvRegistroEmpleado.Margin = new Padding(2);
            dgvRegistroEmpleado.Name = "dgvRegistroEmpleado";
            dgvRegistroEmpleado.RowHeadersWidth = 62;
            dgvRegistroEmpleado.Size = new Size(800, 174);
            dgvRegistroEmpleado.TabIndex = 6;
            dgvRegistroEmpleado.CellMouseClick += dgvRegistroEmpleado_CellMouseClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(320, 231);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 32);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(432, 231);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 32);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(142, 149);
            cboCargo.Margin = new Padding(2);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(129, 23);
            cboCargo.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(544, 232);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 32);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(545, 175);
            dtpFechaInicio.Margin = new Padding(2);
            dtpFechaInicio.MaxDate = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            dtpFechaInicio.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(138, 23);
            dtpFechaInicio.TabIndex = 10;
            dtpFechaInicio.Value = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(0, 254);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(25, 23);
            txtId.TabIndex = 11;
            // 
            // mtxtCedula
            // 
            mtxtCedula.Location = new Point(142, 121);
            mtxtCedula.Margin = new Padding(2);
            mtxtCedula.Mask = "000-0000000-0";
            mtxtCedula.Name = "mtxtCedula";
            mtxtCedula.Size = new Size(129, 23);
            mtxtCedula.TabIndex = 4;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtxtCedula);
            Controls.Add(txtId);
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
            Controls.Add(txtEmail);
            Controls.Add(txtCodigo);
            Controls.Add(txtDepartamento);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtId;
        private MaskedTextBox mtxtCedula;
    }
}