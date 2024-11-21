using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Pago
    {
        private DL_Pago pago = new DL_Pago();

        public int GetCountPago(int idPrestamo)
        {
            return pago.GetCountPago(idPrestamo);
        }

        public Boolean CreatePago(Pago_Cuota pagoCuota)
        {
            return pago.CreatePago(pagoCuota);
        }
    }
}
