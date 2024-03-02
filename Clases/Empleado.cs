using System;
using System.Collections.Generic;
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
        private DateTime FechaInicioEmpleo { get; set; } = new DateTime(0000, 0, 0);
        private string CargoEmpleado { get; set; } = null!;
        private string Email { get; set; } = null!;
        private string Direccion { get; set; } = null!;
        private string Telefono { get; set; } = null!;

    }
}
