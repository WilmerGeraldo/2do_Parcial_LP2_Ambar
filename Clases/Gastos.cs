using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial_LP2.Clases
{
    internal class Gastos
    {
        private int idGastos { get; set; }
        private int NumeroCaja { get; set; }
        private string ConceptoGasto { get; set; } = null!;
        private decimal TotalGasto { get; set; }
        private string QuienRecibe { get; set; } = null!;
        private DateTime Fecha {  get; set; }
        private string QuienAutorizoGasto { get; set; } = null!;

    }
}
