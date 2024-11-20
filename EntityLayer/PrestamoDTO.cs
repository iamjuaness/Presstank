using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PrestamoDTO
    {
        public int ID_Prestamo { get; set; }
        public int Cantidad_Cuotas { get; set; }
        public decimal Monto_Restante { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
    }
}
