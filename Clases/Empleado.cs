using _2do_Parcial_LP2.ConexionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _2do_Parcial_LP2.Clases
{
    internal class Empleado
    {
        private int idEmpleado {  get; set; }
        private string CodigoEmpleado { get; set; } = null!;
        private string Cedula { get; set; } = null!;
        private string Nombre { get; set; } = null!;
        private string Apellido { get; set; } = null!;
        private string Cargo { get; set; } = null!;
        private string Departamento { get; set; } = null!;
        private DateTime FechaInicioEmpleo { get; set; } = DateTime.Now.Date;
        private string CargoEmpleado { get; set; } = null!;
        private string Email { get; set; } = null!;
        private string Direccion { get; set; } = null!;
        private string Telefono { get; set; } = null!;




        public void RegistrarEmpleado(string CodigoEmpleado,string Cedula ,string nombre, string apellido,string cargo,string departamento, string FechaInicio,string Email,string direccion, string telefono)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "insert into empleado (CodigoEmpleado,Cedula,Nombre,Apellido,Cargo,Departamento,FechaInicioEmpleo,Email,Direccion,Telefono) " +
                    "values('" + CodigoEmpleado + "','" + Cedula + "','" + nombre + "','" + apellido + "','" + cargo + "','" + departamento + "','" + FechaInicio + "','" + Email + "','" + direccion + "','" + telefono + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                myComand.ExecuteNonQuery();
                MessageBox.Show("se guardo los registros");

                objetoConexion.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"No se logro registrar los datos, Error:");
            }
        }
        public void MostrarEmpleado(DataGridView tablaEmpleado)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "select *from empleado";


                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaEmpleado.DataSource = dt;
                objetoConexion.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "No se mostraron los datos, Error: ");
            }
        }
        public void SeleccionarEmpleado(DataGridView tablaEmpleado,TextBox id, TextBox CodigoEmpleado, MaskedTextBox Cedula, TextBox Nombre, TextBox Apellido, ComboBox Cargo, TextBox Departamento, DateTimePicker FechaInicio, TextBox Email, TextBox Direccion, TextBox Telefono)
        {

            try
            {
                id.Text = tablaEmpleado.CurrentRow.Cells[0].Value.ToString();
                CodigoEmpleado.Text = tablaEmpleado.CurrentRow.Cells[1].Value.ToString();
                Cedula.Text = tablaEmpleado.CurrentRow.Cells[2].Value.ToString();
                Nombre.Text = tablaEmpleado.CurrentRow.Cells[3].Value.ToString();
                Apellido.Text = tablaEmpleado.CurrentRow.Cells[4].Value.ToString();
                Cargo.Text = tablaEmpleado.CurrentRow.Cells[5].Value.ToString();
                Departamento.Text = tablaEmpleado.CurrentRow.Cells[6].Value.ToString();
                FechaInicio.Text = tablaEmpleado.CurrentRow.Cells[7].Value.ToString();
                Email.Text = tablaEmpleado.CurrentRow.Cells[8].Value.ToString();
                Direccion.Text = tablaEmpleado.CurrentRow.Cells[9].Value.ToString();
                Telefono.Text = tablaEmpleado.CurrentRow.Cells[10].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los datos, Error:" + ex.ToString());
            }

        }

        public void ModificarEmpleado(int id,string CodigoEmpleado, string Cedula, string nombre, string apellido, string cargo, string departamento, string FechaInicio, string Email, string direccion, string telefono)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "update empleado set CodigoEmpleado='"+CodigoEmpleado+"',Cedula='" + Cedula +"', Nombre='" +
                    nombre + "', Apellido='" + apellido + "', Cargo='" + cargo +"', Departamento='" + departamento + "', FechaInicioEmpleo='" + FechaInicio + "', Email='" + Email + "', Direccion='" + direccion + "', Telefono='" + telefono +   "'where idEmpleado ='" + id + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                myComand.ExecuteNonQuery();
                MessageBox.Show("Se Modificaron los registros");

                objetoConexion.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show(  ex.ToString(),"No se logro modificar los datos, Error:");
            }

        }
    }

}
