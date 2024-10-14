using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Empleado
    {
        private DL_Empleado objdl_empleado = new DL_Empleado();

        public Empleado getEmpleadoByID(int userId)
        {
            return objdl_empleado.GetEmpleadoByID(userId);
        }
    }
}
