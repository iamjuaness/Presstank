using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Prestamo
    {
        DL_Prestamo prestamo = new DL_Prestamo();

        public List<PrestamoDTO> GetPrestamos(int id)
        {
            return prestamo.GetPrestamos(id);
        }

        public Boolean CreatePrestamo(Prestamo newPrestamo)
        {
            return prestamo.CreatePrestamos(newPrestamo);
        }

        public Prestamo GetPrestamoById(int id)
        {
            return prestamo.GetPrestmoByID(id);
        }

        public Boolean ModifyCuotaAndMontoRestante(Decimal nuevoMonto, int idPrestamo)
        {
            return prestamo.ModifyCuotaAndMontoRestante(nuevoMonto, idPrestamo);
        }

    }
}
