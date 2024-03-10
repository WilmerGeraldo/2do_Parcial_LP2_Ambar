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
        public decimal SueldoBruto { get; set; }


        public void RegistrarEmpleado(string Cedula ,string nombre, string apellido,string cargo,string departamento, string FechaInicio,string Email,string direccion, string telefono, decimal sueldo)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "insert into empleado (Cedula,Nombre,Apellido,Cargo,Departamento,FechaInicioEmpleo,Email,Direccion,Telefono, SueldoBruto) " +
                    "values('" + Cedula + "','" + nombre + "','" + apellido + "','" + cargo + "','" + departamento + "','" + FechaInicio + "','" + Email + "','" + direccion + "','" + telefono + "','" + sueldo + "');";

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
        public void SeleccionarEmpleado(DataGridView tablaEmpleado,TextBox id, MaskedTextBox Cedula, TextBox Nombre, TextBox Apellido, ComboBox Cargo, TextBox Departamento, DateTimePicker FechaInicio, TextBox Email, TextBox Direccion, TextBox Telefono, TextBox SueldoBruto)
        {

            try
            {
                id.Text = tablaEmpleado.CurrentRow.Cells[0].Value.ToString();
                Cedula.Text = tablaEmpleado.CurrentRow.Cells[1].Value.ToString();
                Nombre.Text = tablaEmpleado.CurrentRow.Cells[2].Value.ToString();
                Apellido.Text = tablaEmpleado.CurrentRow.Cells[3].Value.ToString();
                Cargo.Text = tablaEmpleado.CurrentRow.Cells[4].Value.ToString();
                Departamento.Text = tablaEmpleado.CurrentRow.Cells[5].Value.ToString();
                FechaInicio.Text = tablaEmpleado.CurrentRow.Cells[6].Value.ToString();
                Email.Text = tablaEmpleado.CurrentRow.Cells[7].Value.ToString();
                Direccion.Text = tablaEmpleado.CurrentRow.Cells[8].Value.ToString();
                Telefono.Text = tablaEmpleado.CurrentRow.Cells[9].Value.ToString();
                SueldoBruto.Text = tablaEmpleado.CurrentRow.Cells[10].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"No se logro seleccionar los datos, Error:" );
            }

        }

        public void ModificarEmpleado(int id, string Cedula, string nombre, string apellido, string cargo, string departamento, string FechaInicio, string Email, string direccion, string telefono, decimal sueldo)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "update empleado set Cedula='" + Cedula +"', Nombre='" + nombre + "', Apellido='" + apellido + "', Cargo='" + cargo +"', Departamento='" + departamento + "', " +
                    "FechaInicioEmpleo='" + FechaInicio + "', Email='" + Email + "', Direccion='" + direccion + "', Telefono='" + telefono + "', SueldoBruto='" + sueldo + "'where idEmpleado ='" + id + "';";

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

        public void EliminarEmpleado(int id)
        {
            try
            {
                ConexionAmbarDB objetoConexion = new ConexionAmbarDB();
                String query = "Delete from empleado  where idEmpleado =  '" + id + "';";
                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                myComand.ExecuteNonQuery();
                MessageBox.Show("se a eliminado el registro");

                objetoConexion.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "No se logro eliminar los datos, Error:");
            }
        }
    }

}
