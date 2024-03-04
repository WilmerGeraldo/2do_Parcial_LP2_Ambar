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
            objetoEmpleado.RegistrarEmpleado(txtCodigo.Text, txtCedula.Text, txtNombre.Text, txtApellido.Text, cboCargo.Text, txtDepartamento.Text, txtFechaInicio.Text, txtEmail.Text, txtDireccion.Text, txtTelefono.Text);
            objetoEmpleado.MostrarCliente(dgvRegistroEmpleado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Empleado objetoEmpleado=new Clases.Empleado();
            objetoEmpleado.MostrarCliente(dgvRegistroEmpleado);
        }
    }
}
