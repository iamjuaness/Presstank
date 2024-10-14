using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Prestamo
    {
        public int ID_Prestamo { get; set; }
        public decimal Monto_Desembolsado { get; set; }
        public DateTime Fecha_Desembolso { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Solicitud { get; set; }
    }
}
