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

        public List<SolicitudDTO> GetSolicitudes(string estado)
        {
            return solicitud.GetSolicitudes(estado);
        }

        public List<MisSolicitudesDTO> GetMisSolicitudes(int ID)
        {
            return solicitud.GetSolicitudesByID(ID);
        }

        public Boolean crearSolicitud(Solicitud newSolicitud)
        {
            return solicitud.crearSolicitud(newSolicitud);
        }

        public Boolean cambiarEstadoSolicitud(string idSolicitud, string estado)
        {
            return solicitud.cambiarEstadoSolicitud(idSolicitud, estado);
        }
    }
}
