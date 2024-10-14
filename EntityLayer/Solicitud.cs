using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Solicitud
    {
        public int ID_Solicitud { get; set; }
        public DateTime Fecha_Solicitud { get; set; }
        public decimal Monto_Solicitado { get; set; }
        public int ID_Periodo { get; set; }
        public int ID_Estado { get; set; }
        public int ID_Empleado { get; set; }
    }
}
