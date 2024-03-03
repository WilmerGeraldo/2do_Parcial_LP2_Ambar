using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial_LP2.Clases
{
    internal class CXC
    {
        private int idCXC {  get; set; }
        private string Empleado { get; set; } = null!;
        private decimal TotalCXC { get; set; }
        private string TiempoPlazo { get; set; } = null!;
        private decimal CuotaDescontar { get; set; }
        private DateTime FechaPrestamo { get; set; } = DateTime.Now.Date;

    }
}
