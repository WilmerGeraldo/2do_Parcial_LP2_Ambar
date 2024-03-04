using _2do_Parcial_LP2.ConexionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                MessageBox.Show("No se logro registrar los datos, Error:" + ex.ToString());
            }
        }
        public void MostrarCliente(DataGridView tablaEmpleado)
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
    }

}
