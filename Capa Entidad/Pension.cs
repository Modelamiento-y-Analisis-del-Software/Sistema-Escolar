using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pension
    {
        public int Id { get; set; }
        public Matricula EntMatricula { get; set; }
        public string Concepto { get; set; }
        public DateTime FecVencimiento { get; set; }
        public DateTime FecEmision { get; set; }
        public DateTime FecPago { get; set; }
        public bool estado { get; set; }
    }
}
