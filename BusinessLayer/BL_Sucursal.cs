using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Sucursal
    {
        DL_Sucursal objdl_sucursal = new DL_Sucursal();

        public List<Sucursal> GetSucursales()
        {
            return objdl_sucursal.GetSucursales();
        }
    }
}
