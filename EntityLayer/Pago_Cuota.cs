using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Pago_Cuota
    {
        public int ID_Pago { get; set; }
        public int Numero_Cuota { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Valor_Pago { get; set; }
        public int ID_Prestamo { get; set; }
    }
}
