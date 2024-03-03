using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial_LP2.Clases
{
    internal class Nomina
    {
        private int idNomina {  get; set; }
        private string NumeroNomina { get; set; } = null!;
        private DateTime Fecha { get; set; } = new DateTime(0000, 0, 0);
        private string TipoNomina { get; set; } = null!;
        private string CedulaEmpleado { get; set; } = null!;
        private string NombreEmpleado { get; set; } = null!;
        private string ApellidoEmpleado { get; set; } = null!;
        private string CargoEmpleado { get; set; } = null!;
        private string Departamento { get; set; } = null!;
        private decimal SueldoBruto { get; set; }
        private decimal SeguroSocial {  get; set; }
        private decimal AFP {  get; set; }
        private decimal DescuentoCXC {  get; set; }
        private decimal SueldoNeto { get; set; }

    }
}
