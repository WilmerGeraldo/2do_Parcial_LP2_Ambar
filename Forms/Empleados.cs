using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_LP2.Forms
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Clases.Empleado objetoEmpleado = new Clases.Empleado();

            objetoEmpleado.RegistrarEmpleado(txtCodigo.Text, mtxtCedula.Text, txtNombre.Text, txtApellido.Text, cboCargo.Text, txtDepartamento.Text, dtpFechaInicio.Text, txtEmail.Text, txtDireccion.Text, txtTelefono.Text);
            objetoEmpleado.MostrarEmpleado(dgvRegistroEmpleado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Empleado objetoEmpleado = new Clases.Empleado();
            objetoEmpleado.MostrarEmpleado(dgvRegistroEmpleado);
        }



        private void dgvRegistroEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Clases.Empleado objetoEmpleado = new Clases.Empleado();
            objetoEmpleado.SeleccionarEmpleado(dgvRegistroEmpleado, txtId, txtCodigo, mtxtCedula, txtNombre, txtApellido, cboCargo, txtDepartamento, dtpFechaInicio, txtEmail, txtDireccion, txtTelefono);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(txtId.Text);
            Clases.Empleado objetoEmpleado = new Clases.Empleado();
            objetoEmpleado.ModificarEmpleado(idEmpleado, txtCodigo.Text, mtxtCedula.Text, txtNombre.Text, txtApellido.Text, cboCargo.Text, txtDepartamento.Text, dtpFechaInicio.Text, txtEmail.Text, txtDireccion.Text, txtTelefono.Text);
            objetoEmpleado.MostrarEmpleado(dgvRegistroEmpleado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(txtId.Text);
            Clases.Empleado objetoEmpleado = new Clases.Empleado();
            objetoEmpleado.EliminarEmpleado(idEmpleado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
