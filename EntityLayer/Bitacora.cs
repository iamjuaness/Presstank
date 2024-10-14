using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Bitacora
    {
        public int ID_Bitacora { get; set; }
        public int ID_Usuario { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Hora_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Hora_Salida { get; set; }
    }
}
