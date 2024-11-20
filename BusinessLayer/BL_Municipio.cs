using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Municipio
    {
        DL_Municipio dL_Municipio = new DL_Municipio();
        public List<Municipio> GetMunicipios()
        {
            return dL_Municipio.GetMunicipios();
        }

        public Municipio GetMunicipio(int ID)
        {
            return dL_Municipio.GetMunicipio(ID);
        }
    }
}
