using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Solicitud
    {
        DL_Solicitud solicitud = new DL_Solicitud();

        public List<SolicitudDTO> GetSolicitudes()
        {
            return solicitud.GetSolicitudes();
        }

        public List<MisSolicitudesDTO> GetMisSolicitudes(int ID)
        {
            return solicitud.GetSolicitudesByID(ID);
        }
    }
}
