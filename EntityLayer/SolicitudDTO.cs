using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class SolicitudDTO
    {
        public int ID_Solicitud { get; set; }
        public DateTime Fecha_Solicitud { get; set; }
        public decimal Monto_Solicitado { get; set; }
        public int Periodo { get; set; }             // Cantidad de meses del periodo
        public string Estado_Solicitud { get; set; }  // Estado de la solicitud
        public string Empleado { get; set; }          // Nombre del empleado
    }

}
